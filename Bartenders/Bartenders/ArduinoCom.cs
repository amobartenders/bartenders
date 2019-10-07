using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Windows.Forms;

namespace Bartenders
{
    public class ArduinoCom
    {
        private string bufferedData = (string)null;
        private SerialPort serialPort;
        private string messageBeginMarker;
        private string messageEndMarker;

        public ArduinoCom(string messageBeginMarker, string messageEndMarker)
        {
            this.messageBeginMarker = messageBeginMarker;
            this.messageEndMarker = messageEndMarker;
        }

        public bool ConnectByHand(string port)
        {
            this.serialPort = new SerialPort();
            this.serialPort.BaudRate = 9600;
            this.serialPort.PortName = port;
            this.serialPort.Open();
            if (!this.serialPort.IsOpen)
                return false;
            this.serialPort.WriteLine("A");
            this.serialPort.DiscardInBuffer();
            this.serialPort.DiscardOutBuffer();
            return true;
        }

        public bool ConnectAutomagically()
        {
            string[] portNames = SerialPort.GetPortNames();
            this.serialPort = new SerialPort();
            foreach (string str in portNames)
            {
                this.serialPort.BaudRate = 9600;
                try
                {
                    this.serialPort.PortName = str;
                    this.serialPort.Open();
                    if (this.serialPort.IsOpen)
                    {
                        this.serialPort.ReadTimeout = 200;
                        if (this.serialPort.ReadLine().Substring(0, 1) == "A")
                        {
                            this.serialPort.WriteLine("A");
                            this.serialPort.DiscardInBuffer();
                            this.serialPort.DiscardOutBuffer();
                            return true;
                        }
                    }
                }
                catch
                {
                    this.serialPort.Close();
                }
            }
            return false;
        }

        public bool SendMessage(string message)
        {
            if (this.serialPort.IsOpen)
            {
                try
                {
                    this.serialPort.Write(message);
                    return true;
                }
                catch (Exception ex)
                {
                    int num = (int)MessageBox.Show("Could not write to serial port: " + ex.Message);
                }
            }
            return false;
        }

        public string waitForMessage()
        {
            this.serialPort.ReadTimeout = 1000;
            string str = (string)null;
            while (str == null)
            {
                try
                {
                    str = this.serialPort.ReadLine();
                }
                catch
                {
                }
            }
            return str;
        }

        public List<string> getMessages()
        {
            if (!this.serialPort.IsOpen || this.serialPort.BytesToRead <= 0)
                return (List<string>)null;
            try
            {
                string str = this.serialPort.ReadExisting();
                if (str != null)
                    this.bufferedData += str;
                string removeNextMessage = this.FindAndRemoveNextMessage();
                List<string> stringList = new List<string>();
                for (; removeNextMessage != null; removeNextMessage = this.FindAndRemoveNextMessage())
                    stringList.Add(removeNextMessage);
                return stringList.Count > 0 ? stringList : (List<string>)null;
            }
            catch
            {
                return (List<string>)null;
            }
        }

        public string FindAndRemoveNextMessage()
        {
            int startIndex = this.bufferedData.IndexOf(this.messageBeginMarker);
            if (startIndex != -1)
            {
                int num = this.bufferedData.IndexOf(this.messageEndMarker, startIndex);
                if (num != -1)
                {
                    string str = this.bufferedData.Substring(startIndex, num - startIndex + 1);
                    this.bufferedData = this.bufferedData.Substring(num + 1);
                    return str;
                }
            }
            return (string)null;
        }

        public string getTagId(string message)
        {
            message = this.stripMessage(message);
            if (!message.StartsWith("KEY"))
                return (string)null;
            message = message.Substring(message.IndexOf(':') + 1);
            return message;
        }

        public string stripMessage(string message)
        {
            if (message.StartsWith("#"))
                message = message.Substring(1);
            if (message.Contains("%"))
                message = message.Substring(0, message.IndexOf('%'));
            return message;
        }
    }
}
