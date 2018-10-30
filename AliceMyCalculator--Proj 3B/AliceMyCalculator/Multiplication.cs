using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AliceMyCalculator
{
    public partial class Multiplication : Form
    {
        public Multiplication()
        {
            InitializeComponent();
        }

       private void Multiply_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        { 
            decimal Result1;

            decimal Number1 = Decimal.Parse(txtNumber1.Text, NumberStyles.AllowCurrencySymbol
                | NumberStyles.AllowDecimalPoint | NumberStyles.AllowLeadingSign
                | NumberStyles.AllowTrailingSign | NumberStyles.AllowThousands);

            decimal Number2 = Decimal.Parse(txtNumber2.Text, NumberStyles.AllowCurrencySymbol
                | NumberStyles.AllowDecimalPoint | NumberStyles.AllowLeadingSign
                | NumberStyles.AllowTrailingSign | NumberStyles.AllowThousands);

            Result1 = Number1 * Number2;

            txtNumber1.Text = Number1.ToString();
            txtNumber2.Text = Number2.ToString();
            txtResult1.Text = Result1.ToString();
            
        }

        private void txtNumber1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

      
        }
    }

