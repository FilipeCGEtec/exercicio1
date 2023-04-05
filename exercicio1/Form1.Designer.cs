namespace exercicio1
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exerciciosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ex1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.postoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.votaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabuadaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exerciciosToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exerciciosToolStripMenuItem
            // 
            this.exerciciosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ex1ToolStripMenuItem,
            this.postoToolStripMenuItem,
            this.votaçãoToolStripMenuItem,
            this.tabuadaToolStripMenuItem});
            this.exerciciosToolStripMenuItem.Name = "exerciciosToolStripMenuItem";
            this.exerciciosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.exerciciosToolStripMenuItem.Text = "exercicios";
            // 
            // ex1ToolStripMenuItem
            // 
            this.ex1ToolStripMenuItem.Name = "ex1ToolStripMenuItem";
            this.ex1ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ex1ToolStripMenuItem.Text = "imc";
            this.ex1ToolStripMenuItem.Click += new System.EventHandler(this.ex1ToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.sairToolStripMenuItem.Text = "sair";
            // 
            // postoToolStripMenuItem
            // 
            this.postoToolStripMenuItem.Name = "postoToolStripMenuItem";
            this.postoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.postoToolStripMenuItem.Text = "posto ";
            this.postoToolStripMenuItem.Click += new System.EventHandler(this.postoToolStripMenuItem_Click);
            // 
            // votaçãoToolStripMenuItem
            // 
            this.votaçãoToolStripMenuItem.Name = "votaçãoToolStripMenuItem";
            this.votaçãoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.votaçãoToolStripMenuItem.Text = "votação";
            this.votaçãoToolStripMenuItem.Click += new System.EventHandler(this.votaçãoToolStripMenuItem_Click);
            // 
            // tabuadaToolStripMenuItem
            // 
            this.tabuadaToolStripMenuItem.Name = "tabuadaToolStripMenuItem";
            this.tabuadaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tabuadaToolStripMenuItem.Text = "tabuada";
            this.tabuadaToolStripMenuItem.Click += new System.EventHandler(this.tabuadaToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exerciciosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ex1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem postoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem votaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tabuadaToolStripMenuItem;
    }
}

