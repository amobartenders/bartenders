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
    public partial class Form3 : Form
    {
        
        
        
        public Form3()
        {

            InitializeComponent();
        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (Form1 f1 = new Form1())
            f1.ShowDialog();
            Show();
            this.Close();
            

        }

        private void productButton_Click(object sender, EventArgs e)
        {
            if(naamEditBox.Text != null || prijsBox.Text != null)
            {
                string naam = naamEditBox.Text;
                string prijs = prijsBox.Text;

            }

            //((Label)f1.Controls["prijsLabel"]).Text = prijsBox.Text;
        }

        private void productButton1_Click(object sender, EventArgs e)
        {
            //((Label)f1.Controls["naamLabel1"]).Text = naamEditBox1.Text;
            //((Label)f1.Controls["prijsLabel1"]).Text = prijsBox1.Text;
        }

        private void productButton2_Click(object sender, EventArgs e)
        {
            //((Label)f1.Controls["naamLabel2"]).Text = naamEditBox2.Text;
            //((Label)f1.Controls["prijsLabel2"]).Text = prijsBox2.Text;
        }

        private void productButton3_Click(object sender, EventArgs e)
        {
            //((Label)f1.Controls["naamLabel3"]).Text = naamEditBox3.Text;
            //((Label)f1.Controls["prijsLabel3"]).Text = prijsBox3.Text;
        }

        private void productButton4_Click(object sender, EventArgs e)
        {
            //((Label)f1.Controls["naamLabel4"]).Text = naamEditBox4.Text;
            //((Label)f1.Controls["prijsLabel4"]).Text = prijsBox4.Text;
        }

        private void productButton5_Click(object sender, EventArgs e)
        {
            //((Label)f1.Controls["naamLabel5"]).Text = naamEditBox5.Text;
            //((Label)f1.Controls["prijsLabel5"]).Text = prijsBox5.Text;
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            imgBox.ImageLocation = openFileDialog1.FileName;
        }

        private void Form3_Load_1(object sender, EventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
