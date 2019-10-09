using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace Bartenders
{
    public partial class Form1 : Form
    {

        
        SerialPort serial;
        public ArduinoCom arduino;
        public bool connected = false;
        public Form1()
        {
            InitializeComponent();
            connected = Form2.connected;
        }

        private void adminBtn_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(arduino);
            this.Hide();
            f2.ShowDialog();
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (connected == false)
            {
                this.arduino = new ArduinoCom("#", "%");
                if (this.arduino.ConnectAutomagically())
                {
                    MessageBox.Show("Connected!");
                    connected = true;
                }
                else
                {
                    MessageBox.Show("Arduino niet gevonden, probeer opnieuw");
                    this.Close();
                }
            }
            
        }
    }
}
