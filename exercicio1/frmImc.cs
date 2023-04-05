using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace exercicio1
{
    public partial class frmImc : Form
    {
        public frmImc()
        {
            InitializeComponent();
        }

        private void btncal_Click(object sender, EventArgs e)
        {
            double peso, altura, imc;
 
           peso = Convert.ToDouble(txtpeso.Text);
           altura = Convert.ToDouble(txtalt.Text);
            imc = peso / Math.Pow(altura, 2);

            if (imc < 18.5)
            {
                txtimc.Text = "Abaixo do peso.";
            }
            else if (imc >= 18.5 && imc < 29.9)
            {
                txtimc.Text = "Sobrepeso";
            }
            else if (imc >= 29.9 && imc < 30)
            {
                txtimc.Text = "Obesidade II";
            }
            else {
                txtimc.Text = "Obesidade III";
            }
        }

        private void btnlim_Click(object sender, EventArgs e)
        {
            txtalt.Clear();
            txtimc.Clear();
            txtpeso.Clear();
            txtalt.Focus();
        }

        private void btnvolt_Click(object sender, EventArgs e)
        {
            this.Hide();
            var fm = new Form1();
            fm.Show();
        }
    }
}
