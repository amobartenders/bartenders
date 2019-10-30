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
    public partial class Stock : Form
    {

        int amount;
        public Stock()
        {
            InitializeComponent();
        }

        private void IncrementByOneButton_Click(object sender, EventArgs e)
        {
            amount++;

            amountNumericUpDown.Text = amount.ToString();
        }

        private void IncrementBySixButton_Click(object sender, EventArgs e)
        {
            amount = amount + 6;

            amountNumericUpDown.Text = amount.ToString();
        }

        private void IncrementByTwelveButton_Click(object sender, EventArgs e)
        {
            amount = amount + 12;

            amountNumericUpDown.Text = amount.ToString();
        }

        private void IncrementByTwentyfourButton_Click(object sender, EventArgs e)
        {
            amount = amount + 24;

            amountNumericUpDown.Text = amount.ToString();
        }

        private void AmountNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (amount >= 240)
            {
                MessageBox.Show("Je kan niet meer bestellen");
            }
        }
    }
}
