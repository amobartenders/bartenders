using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bartenders
{
    public partial class Form2 : Form
    {
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
    }
}
