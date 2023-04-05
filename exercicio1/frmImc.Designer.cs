namespace exercicio1
{
    partial class frmImc
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
            this.lblalt = new System.Windows.Forms.Label();
            this.lblpeso = new System.Windows.Forms.Label();
            this.lblimc = new System.Windows.Forms.Label();
            this.txtalt = new System.Windows.Forms.TextBox();
            this.txtpeso = new System.Windows.Forms.TextBox();
            this.txtimc = new System.Windows.Forms.TextBox();
            this.btnvolt = new System.Windows.Forms.Button();
            this.btncal = new System.Windows.Forms.Button();
            this.btnlim = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblalt
            // 
            this.lblalt.AutoSize = true;
            this.lblalt.Location = new System.Drawing.Point(44, 43);
            this.lblalt.Name = "lblalt";
            this.lblalt.Size = new System.Drawing.Size(63, 13);
            this.lblalt.TabIndex = 0;
            this.lblalt.Text = "Digite altura";
            // 
            // lblpeso
            // 
            this.lblpeso.AutoSize = true;
            this.lblpeso.Location = new System.Drawing.Point(44, 82);
            this.lblpeso.Name = "lblpeso";
            this.lblpeso.Size = new System.Drawing.Size(60, 13);
            this.lblpeso.TabIndex = 1;
            this.lblpeso.Text = "Digite peso";
            // 
            // lblimc
            // 
            this.lblimc.AutoSize = true;
            this.lblimc.Location = new System.Drawing.Point(44, 134);
            this.lblimc.Name = "lblimc";
            this.lblimc.Size = new System.Drawing.Size(26, 13);
            this.lblimc.TabIndex = 2;
            this.lblimc.Text = "IMC";
            // 
            // txtalt
            // 
            this.txtalt.Location = new System.Drawing.Point(150, 43);
            this.txtalt.Name = "txtalt";
            this.txtalt.Size = new System.Drawing.Size(100, 20);
            this.txtalt.TabIndex = 3;
            // 
            // txtpeso
            // 
            this.txtpeso.Location = new System.Drawing.Point(150, 82);
            this.txtpeso.Name = "txtpeso";
            this.txtpeso.Size = new System.Drawing.Size(100, 20);
            this.txtpeso.TabIndex = 4;
            // 
            // txtimc
            // 
            this.txtimc.Location = new System.Drawing.Point(150, 134);
            this.txtimc.Name = "txtimc";
            this.txtimc.Size = new System.Drawing.Size(100, 20);
            this.txtimc.TabIndex = 5;
            // 
            // btnvolt
            // 
            this.btnvolt.Location = new System.Drawing.Point(47, 205);
            this.btnvolt.Name = "btnvolt";
            this.btnvolt.Size = new System.Drawing.Size(75, 23);
            this.btnvolt.TabIndex = 6;
            this.btnvolt.Text = "Voltar";
            this.btnvolt.UseVisualStyleBackColor = true;
            this.btnvolt.Click += new System.EventHandler(this.btnvolt_Click);
            // 
            // btncal
            // 
            this.btncal.Location = new System.Drawing.Point(175, 205);
            this.btncal.Name = "btncal";
            this.btncal.Size = new System.Drawing.Size(75, 23);
            this.btncal.TabIndex = 7;
            this.btncal.Text = "Calcular";
            this.btncal.UseVisualStyleBackColor = true;
            this.btncal.Click += new System.EventHandler(this.btncal_Click);
            // 
            // btnlim
            // 
            this.btnlim.Location = new System.Drawing.Point(287, 205);
            this.btnlim.Name = "btnlim";
            this.btnlim.Size = new System.Drawing.Size(75, 23);
            this.btnlim.TabIndex = 8;
            this.btnlim.Text = "Limpar";
            this.btnlim.UseVisualStyleBackColor = true;
            this.btnlim.Click += new System.EventHandler(this.btnlim_Click);
            // 
            // frmImc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnlim);
            this.Controls.Add(this.btncal);
            this.Controls.Add(this.btnvolt);
            this.Controls.Add(this.txtimc);
            this.Controls.Add(this.txtpeso);
            this.Controls.Add(this.txtalt);
            this.Controls.Add(this.lblimc);
            this.Controls.Add(this.lblpeso);
            this.Controls.Add(this.lblalt);
            this.Name = "frmImc";
            this.Text = "frmImc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblalt;
        private System.Windows.Forms.Label lblpeso;
        private System.Windows.Forms.Label lblimc;
        private System.Windows.Forms.TextBox txtalt;
        private System.Windows.Forms.TextBox txtpeso;
        private System.Windows.Forms.TextBox txtimc;
        private System.Windows.Forms.Button btnvolt;
        private System.Windows.Forms.Button btncal;
        private System.Windows.Forms.Button btnlim;
    }
}