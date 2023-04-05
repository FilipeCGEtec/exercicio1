namespace exercicio1
{
    partial class frmPosto
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
            this.txtLit = new System.Windows.Forms.TextBox();
            this.txtFim = new System.Windows.Forms.TextBox();
            this.lblLitro = new System.Windows.Forms.Label();
            this.lblFim = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblTipo = new System.Windows.Forms.Label();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtLit
            // 
            this.txtLit.Location = new System.Drawing.Point(230, 86);
            this.txtLit.Name = "txtLit";
            this.txtLit.Size = new System.Drawing.Size(100, 20);
            this.txtLit.TabIndex = 0;
            // 
            // txtFim
            // 
            this.txtFim.Location = new System.Drawing.Point(230, 135);
            this.txtFim.Name = "txtFim";
            this.txtFim.Size = new System.Drawing.Size(100, 20);
            this.txtFim.TabIndex = 1;
            // 
            // lblLitro
            // 
            this.lblLitro.AutoSize = true;
            this.lblLitro.Location = new System.Drawing.Point(140, 89);
            this.lblLitro.Name = "lblLitro";
            this.lblLitro.Size = new System.Drawing.Size(84, 13);
            this.lblLitro.TabIndex = 2;
            this.lblLitro.Text = "Informe os Litros";
            // 
            // lblFim
            // 
            this.lblFim.AutoSize = true;
            this.lblFim.Location = new System.Drawing.Point(164, 138);
            this.lblFim.Name = "lblFim";
            this.lblFim.Size = new System.Drawing.Size(60, 13);
            this.lblFim.TabIndex = 3;
            this.lblFim.Text = "Preço Final";
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(341, 204);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 4;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(260, 204);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 5;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(179, 204);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(121, 51);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(103, 13);
            this.lblTipo.TabIndex = 7;
            this.lblTipo.Text = "Tipo de Combustivel";
            // 
            // txtTipo
            // 
            this.txtTipo.Location = new System.Drawing.Point(230, 48);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(100, 20);
            this.txtTipo.TabIndex = 8;
            // 
            // frmPosto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.lblFim);
            this.Controls.Add(this.lblLitro);
            this.Controls.Add(this.txtFim);
            this.Controls.Add(this.txtLit);
            this.Name = "frmPosto";
            this.Text = "frmPosto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLit;
        private System.Windows.Forms.TextBox txtFim;
        private System.Windows.Forms.Label lblLitro;
        private System.Windows.Forms.Label lblFim;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.TextBox txtTipo;
    }
}