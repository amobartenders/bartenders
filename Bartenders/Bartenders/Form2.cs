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
        Form3 form3 = new Form3();
        SerialPort serial;
        public ArduinoCom arduino;

        public Form2( ArduinoCom arduino)
        {
            this.arduino = arduino;
            //connected = Form1.connected;
            InitializeComponent();


        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            if (usernameBox.Text == "Admin" && passwordBox.Text == "Admin")
            {

               
                this.Hide();
                f3.ShowDialog();
                this.Close();

                this.Hide();
                int num = (int)form3.ShowDialog();
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
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Text = "Gereed, Scan je tag.";
            string res = "";
            while (res == "") {
                this.arduino.SendMessage("#SCAN_ONCE%");
                this.arduino.waitForMessage();
                res = this.arduino.getTagId(this.arduino.waitForMessage());
            }

            

            if (res == "0x9D0xEC0x9E0x77")
            {
                Form3 f3 = new Form3();
                this.Hide();
                f3.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Gebruiker bestaat niet, probeer het opnieuw");
            }       

        }

    }
}
