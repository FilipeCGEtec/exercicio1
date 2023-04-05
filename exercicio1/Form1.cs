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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ex1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var fm = new frmImc();
            fm.Show();
        }

        private void tabuadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var fm = new frmTabuada();
            fm.Show();
        }

        private void postoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var fm = new frmPosto();
            fm.Show();
        }

        private void votaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var fm = new frmVotacao();
            fm.Show();
        }
    }
}
