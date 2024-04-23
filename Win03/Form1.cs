using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            int score;
            score = int.Parse(txtScore.Text);
            if(score < 60)
            {
                txtResult.Text = "不及格";
                txtResult.BackColor = Color.LightYellow;
                txtResult.ForeColor = Color.Red;
            }
            else
            {
                txtResult.Text = "及格";
                txtResult.BackColor = Color.Blue;
                txtResult.ForeColor = Color.White;

            }
        }
    }
}
