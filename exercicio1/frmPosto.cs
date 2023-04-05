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
    public partial class frmPosto : Form
    {
        public frmPosto()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double val, lit, des;
            char tip;

            tip = Convert.ToChar(txtTipo);
            lit = Convert.ToDouble(txtLit);

            if (tip == 'G')
            {
                if (lit <= 20)
                {
                    des = (5.50 * (3 / 100)) * lit;
                    val = (5.50 * lit) - des;
                }
                else
                {
                    des = (5.50 * (5 / 100)) * lit;
                    val = (5.50 * lit) - des;
                }
            }
            else if (tip == 'A') {
                if (lit <= 20) {
                    des = (4.90 * (4 / 100)) * lit;
                    val = (4.90 * lit) - des * 1;
                }
                else
                {
                    des = (4.90 * (6 / 100)) * lit;
                    val = (4.90 * lit) - des;
                }
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtTipo.Clear();
            txtLit.Clear();
            txtFim.Clear();
            txtTipo.Focus();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            var fm = new Form1();
            fm.Show();
        }
    }
}
