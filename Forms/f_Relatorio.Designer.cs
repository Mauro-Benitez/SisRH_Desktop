namespace SisRH_Desktop
{
    partial class f_Relatorio
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.checkBoxGastoINSS = new System.Windows.Forms.CheckBox();
            this.checkBoxGastoVT = new System.Windows.Forms.CheckBox();
            this.checkBoxGastoVR = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGerar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(124)))), ((int)(((byte)(243)))));
            this.label9.Location = new System.Drawing.Point(46, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(214, 37);
            this.label9.TabIndex = 57;
            this.label9.Text = "Gerar Relatório";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(432, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 16);
            this.label10.TabIndex = 56;
            // 
            // checkBoxGastoINSS
            // 
            this.checkBoxGastoINSS.AutoSize = true;
            this.checkBoxGastoINSS.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxGastoINSS.Location = new System.Drawing.Point(51, 183);
            this.checkBoxGastoINSS.Name = "checkBoxGastoINSS";
            this.checkBoxGastoINSS.Size = new System.Drawing.Size(165, 29);
            this.checkBoxGastoINSS.TabIndex = 62;
            this.checkBoxGastoINSS.Text = "Gastos em INSS";
            this.checkBoxGastoINSS.UseVisualStyleBackColor = true;
            this.checkBoxGastoINSS.CheckedChanged += new System.EventHandler(this.checkBoxGastoINSS_CheckedChanged);
            // 
            // checkBoxGastoVT
            // 
            this.checkBoxGastoVT.AutoSize = true;
            this.checkBoxGastoVT.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxGastoVT.Location = new System.Drawing.Point(51, 221);
            this.checkBoxGastoVT.Name = "checkBoxGastoVT";
            this.checkBoxGastoVT.Size = new System.Drawing.Size(148, 29);
            this.checkBoxGastoVT.TabIndex = 63;
            this.checkBoxGastoVT.Text = "Gastos em VT";
            this.checkBoxGastoVT.UseVisualStyleBackColor = true;
            // 
            // checkBoxGastoVR
            // 
            this.checkBoxGastoVR.AutoSize = true;
            this.checkBoxGastoVR.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxGastoVR.Location = new System.Drawing.Point(51, 259);
            this.checkBoxGastoVR.Name = "checkBoxGastoVR";
            this.checkBoxGastoVR.Size = new System.Drawing.Size(149, 29);
            this.checkBoxGastoVR.TabIndex = 64;
            this.checkBoxGastoVR.Text = "Gastos em VR";
            this.checkBoxGastoVR.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(124)))), ((int)(((byte)(243)))));
            this.label3.Location = new System.Drawing.Point(46, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 32);
            this.label3.TabIndex = 73;
            this.label3.Text = "Taxas e Cálculos";
            // 
            // btnGerar
            // 
            this.btnGerar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(124)))), ((int)(((byte)(243)))));
            this.btnGerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGerar.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerar.ForeColor = System.Drawing.Color.White;
            this.btnGerar.Location = new System.Drawing.Point(473, 505);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(129, 37);
            this.btnGerar.TabIndex = 74;
            this.btnGerar.Text = "Gerar Relatório";
            this.btnGerar.UseVisualStyleBackColor = false;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // f_Relatorio
            // 
            this.ClientSize = new System.Drawing.Size(682, 575);
            this.Controls.Add(this.btnGerar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkBoxGastoVR);
            this.Controls.Add(this.checkBoxGastoVT);
            this.Controls.Add(this.checkBoxGastoINSS);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "f_Relatorio";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sis.RH";
            this.Load += new System.EventHandler(this.f_Relatorio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox checkBoxGastoINSS;
        private System.Windows.Forms.CheckBox checkBoxGastoVT;
        private System.Windows.Forms.CheckBox checkBoxGastoVR;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGerar;
    }
}