using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            decimal a, b;
            decimal.TryParse(txtA.Text, out a);
            decimal.TryParse(txtB.Text, out b);
            txtAnswer.Text = (a + b).ToString();
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            decimal a, b;
            decimal.TryParse(txtA.Text, out a);
            decimal.TryParse(txtB.Text, out b);
            txtAnswer.Text = (a - b).ToString();
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            decimal a, b;
            decimal.TryParse(txtA.Text, out a);
            decimal.TryParse(txtB.Text, out b);
            txtAnswer.Text = (a * b).ToString();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            decimal a, b;
            decimal.TryParse(txtA.Text, out a);
            decimal.TryParse(txtB.Text, out b);
            if (b == 0)
                txtAnswer.Text = "除數不得為零";
            else
                txtAnswer.Text = (a / b).ToString();
        }

        private void btnAC_Click(object sender, EventArgs e)
        {
            txtA.Clear();
            txtB.Clear();
            txtAnswer.Clear();
        }
    }
}
