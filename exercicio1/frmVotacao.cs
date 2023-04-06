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
    public partial class frmVotacao : Form
    {
        public frmVotacao()
        {
            InitializeComponent();
        }
        int cand1 = 0, cand2 = 0, cand3 = 0, final;

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            var fm = new Form1();
            fm.Show();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtFinal.Clear();
            txtVoto.Clear();
            txtVoto.Focus();
        }

        private void btnFim_Click(object sender, EventArgs e)
        {
            double vencedor;

            if (cand1 > cand2 && cand1 > cand3)
            {
                vencedor = (cand1 * 100) / final;
                txtFinal.Text = "José da Silva recebeu " + cand1 + " votos oque equivale a " + vencedor + "% dos votos.";
            }
            else
            if (cand2 > cand1 && cand2 > cand3)
            {
                vencedor = (cand2 * 100) / final;
                txtFinal.Text = "Maria Juruma recebeu" + cand2 + " votos oque equivale a " + vencedor + "% dos votos.";
            }
            else
            if (cand3 > cand2 && cand3 > cand1)
            {
                vencedor = (cand3 * 100) / final;
                txtFinal.Text = "João da Tapioca recebeu " + cand3 + " votos oque equivale a " + vencedor + "% dos votos.";
            }
            else
            {
                txtFinal.Text = "Empate";
            }
        }

        private void btnVotar_Click(object sender, EventArgs e)
        {
            Double voto;

            voto = Convert.ToDouble(txtVoto.Text);
            if (voto == 1)
            {
                cand1++;
                final++;
                txtVoto.Clear();
            }
            else if (voto == 2)
            {
                cand2++;
                final++;
                txtVoto.Clear();
            }
            else if (voto == 3)
            {
                cand3++;
                final++;
                txtVoto.Clear();
            }
            else {
                txtVoto.Clear();
            }
        }
    }
}
