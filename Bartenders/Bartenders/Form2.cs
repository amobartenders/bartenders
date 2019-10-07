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
    
    public partial class Form2 : Form
    {
        SerialPort serial;
        public ArduinoCom arduino;
        public Form2()
        {

            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (usernameBox.Text == "Admin" && passwordBox.Text == "Admin")
            {
                Form3 f3 = new Form3();
                this.Hide();
                f3.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Wrong input");
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;


            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int num1 = (int)MessageBox.Show("Click ok to connect, this might take a while! Meanwhile the application will be stuck.");
            this.arduino = new ArduinoCom("#", "%");
            if (this.arduino.ConnectAutomagically())
            {
                int num2 = (int)MessageBox.Show("Connected!");
            }
            else
            {
                int num3 = (int)MessageBox.Show("Arduino not found - reboot arduino and try again!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.arduino.SendMessage("#SCAN_ONCE%");
            int num1 = (int)MessageBox.Show(this.arduino.waitForMessage());
            string res = this.arduino.getTagId(this.arduino.waitForMessage());

            //MessageBox.Show(res);

            if (res == "0x9D0xEC0x9E0x77")
            {
                MessageBox.Show("ja");
            }
            else
            {
                MessageBox.Show("nee");
            }

        }

    }
}
