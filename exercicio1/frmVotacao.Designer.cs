namespace exercicio1
{
    partial class frmVotacao
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtVoto = new System.Windows.Forms.TextBox();
            this.txtFinal = new System.Windows.Forms.TextBox();
            this.lblVoto = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnFim = new System.Windows.Forms.Button();
            this.btnVotar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtVoto
            // 
            this.txtVoto.Location = new System.Drawing.Point(238, 90);
            this.txtVoto.Name = "txtVoto";
            this.txtVoto.Size = new System.Drawing.Size(211, 20);
            this.txtVoto.TabIndex = 0;
            // 
            // txtFinal
            // 
            this.txtFinal.Location = new System.Drawing.Point(140, 137);
            this.txtFinal.Name = "txtFinal";
            this.txtFinal.Size = new System.Drawing.Size(309, 20);
            this.txtFinal.TabIndex = 1;
            // 
            // lblVoto
            // 
            this.lblVoto.AutoSize = true;
            this.lblVoto.Location = new System.Drawing.Point(137, 93);
            this.lblVoto.Name = "lblVoto";
            this.lblVoto.Size = new System.Drawing.Size(77, 13);
            this.lblVoto.TabIndex = 3;
            this.lblVoto.Text = "Insira seu Voto";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(137, 49);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(312, 13);
            this.lblTitulo.TabIndex = 4;
            this.lblTitulo.Text = "1- Jossé da Silva (js), 2- Maria Juruma(mj), 3- João da Tapioca (jt)";
            // 
            // btnFim
            // 
            this.btnFim.Location = new System.Drawing.Point(174, 221);
            this.btnFim.Name = "btnFim";
            this.btnFim.Size = new System.Drawing.Size(275, 23);
            this.btnFim.TabIndex = 5;
            this.btnFim.Text = "Finalizar Votação";
            this.btnFim.UseVisualStyleBackColor = true;
            this.btnFim.Click += new System.EventHandler(this.btnFim_Click);
            // 
            // btnVotar
            // 
            this.btnVotar.Location = new System.Drawing.Point(174, 180);
            this.btnVotar.Name = "btnVotar";
            this.btnVotar.Size = new System.Drawing.Size(75, 23);
            this.btnVotar.TabIndex = 6;
            this.btnVotar.Text = "Votar";
            this.btnVotar.UseVisualStyleBackColor = true;
            this.btnVotar.Click += new System.EventHandler(this.btnVotar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(276, 180);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 7;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(374, 180);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 8;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // frmVotacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnVotar);
            this.Controls.Add(this.btnFim);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblVoto);
            this.Controls.Add(this.txtFinal);
            this.Controls.Add(this.txtVoto);
            this.Name = "frmVotacao";
            this.Text = "frmVotacao";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtVoto;
        private System.Windows.Forms.TextBox txtFinal;
        private System.Windows.Forms.Label lblVoto;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnFim;
        private System.Windows.Forms.Button btnVotar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnVoltar;
    }
}