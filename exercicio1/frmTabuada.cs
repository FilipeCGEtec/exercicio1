using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicio1
{
    public partial class frmTabuada : Form
    {
        public frmTabuada()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double x, result;
            int i;

            x = Convert.ToDouble(txtNum.Text);
            for (i = 1; i <= 10; i++) {
                result = x * i;

                txtResult.Text = String.Concat(txtResult.Text, " \n\n ", result.ToString());
            }
        }

        private void btnCalcular2_Click(object sender, EventArgs e)
        {
            double x, result;
            int i;
            i = 1;
            x = Convert.ToDouble(txtNum.Text);

            while (i <= 10) {
                result = x * i;
                i++;
                txtResult.Text = String.Concat(txtResult.Text, " \n\n ", result.ToString());
            }
        }

        private void btnCalcular3_Click(object sender, EventArgs e)
        {
            double x, result;
            int i;
            i = 1;
            x = Convert.ToDouble(txtNum.Text);

            do
            {
                result = x * i;
                i++;
                txtResult.Text = String.Concat(txtResult.Text, " \n\n ", result.ToString());
            } while (i <= 10);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNum.Clear();
            txtResult.Clear();
            txtNum.Focus();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            var fm = new Form1();
            fm.Show();
        }
    }
}
