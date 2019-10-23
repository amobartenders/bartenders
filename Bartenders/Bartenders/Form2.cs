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
        Form3 f3 = new Form3();

        public Form2()
        {
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
                int num = (int)f3.ShowDialog();
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
            while (res.Length <= 10) {
                Program.arduino.SendMessage("#SCAN_ONCE%");
                Program.arduino.waitForMessage();
                res = Program.arduino.getTagId(Program.arduino.waitForMessage());
            }

            

            if (res == "0x9D0xEC0x9E0x77")
            {
                this.Hide();
                f3.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show(res);
                //MessageBox.Show("Gebruiker bestaat niet, probeer het opnieuw");
            }       

        }

    }
}
