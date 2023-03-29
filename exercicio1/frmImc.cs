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
            imc = peso/Math.Pow()
        }
    }
}
