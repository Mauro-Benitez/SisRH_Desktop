namespace SisRH_Desktop
{
    partial class f_Taxas
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
            this.label5 = new System.Windows.Forms.Label();
            this.txtNomeFuncionario = new System.Windows.Forms.TextBox();
            this.textValorTaxa = new System.Windows.Forms.TextBox();
            this.checkBoxDesconto = new System.Windows.Forms.CheckBox();
            this.CheckBoxAcrescimo = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.txtNomeTaxa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(124)))), ((int)(((byte)(243)))));
            this.label5.Location = new System.Drawing.Point(61, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(249, 32);
            this.label5.TabIndex = 73;
            this.label5.Text = "Adicionar Nova Taxa";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtNomeFuncionario
            // 
            this.txtNomeFuncionario.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeFuncionario.Location = new System.Drawing.Point(174, 150);
            this.txtNomeFuncionario.Name = "txtNomeFuncionario";
            this.txtNomeFuncionario.Size = new System.Drawing.Size(379, 32);
            this.txtNomeFuncionario.TabIndex = 74;
            this.txtNomeFuncionario.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textValorTaxa
            // 
            this.textValorTaxa.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textValorTaxa.Location = new System.Drawing.Point(172, 253);
            this.textValorTaxa.Name = "textValorTaxa";
            this.textValorTaxa.Size = new System.Drawing.Size(379, 32);
            this.textValorTaxa.TabIndex = 75;
            this.textValorTaxa.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // checkBoxDesconto
            // 
            this.checkBoxDesconto.AutoSize = true;
            this.checkBoxDesconto.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxDesconto.Location = new System.Drawing.Point(185, 324);
            this.checkBoxDesconto.Name = "checkBoxDesconto";
            this.checkBoxDesconto.Size = new System.Drawing.Size(113, 29);
            this.checkBoxDesconto.TabIndex = 76;
            this.checkBoxDesconto.Text = "Desconto";
            this.checkBoxDesconto.UseVisualStyleBackColor = true;
            this.checkBoxDesconto.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // CheckBoxAcrescimo
            // 
            this.CheckBoxAcrescimo.AutoSize = true;
            this.CheckBoxAcrescimo.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckBoxAcrescimo.Location = new System.Drawing.Point(312, 324);
            this.CheckBoxAcrescimo.Name = "CheckBoxAcrescimo";
            this.CheckBoxAcrescimo.Size = new System.Drawing.Size(121, 29);
            this.CheckBoxAcrescimo.TabIndex = 77;
            this.CheckBoxAcrescimo.Text = "Acréscimo";
            this.CheckBoxAcrescimo.UseVisualStyleBackColor = true;
            this.CheckBoxAcrescimo.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(101, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 25);
            this.label3.TabIndex = 78;
            this.label3.Text = "Nome:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(80, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 25);
            this.label4.TabIndex = 79;
            this.label4.Text = "Valor(%):";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(110, 324);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 25);
            this.label6.TabIndex = 80;
            this.label6.Text = "Tipo:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(124)))), ((int)(((byte)(243)))));
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionar.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.ForeColor = System.Drawing.Color.White;
            this.btnAdicionar.Location = new System.Drawing.Point(479, 387);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(129, 45);
            this.btnAdicionar.TabIndex = 81;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // txtNomeTaxa
            // 
            this.txtNomeTaxa.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeTaxa.Location = new System.Drawing.Point(174, 199);
            this.txtNomeTaxa.Name = "txtNomeTaxa";
            this.txtNomeTaxa.Size = new System.Drawing.Size(379, 32);
            this.txtNomeTaxa.TabIndex = 82;
            this.txtNomeTaxa.TextChanged += new System.EventHandler(this.txtNomeTaxa_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 25);
            this.label1.TabIndex = 83;
            this.label1.Text = "Nome da Taxa:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // f_Taxas
            // 
            this.ClientSize = new System.Drawing.Size(682, 575);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNomeTaxa);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CheckBoxAcrescimo);
            this.Controls.Add(this.checkBoxDesconto);
            this.Controls.Add(this.textValorTaxa);
            this.Controls.Add(this.txtNomeFuncionario);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "f_Taxas";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sis.RH";
            this.Load += new System.EventHandler(this.f_Taxas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNomeFuncionario;
        private System.Windows.Forms.TextBox textValorTaxa;
        private System.Windows.Forms.CheckBox checkBoxDesconto;
        private System.Windows.Forms.CheckBox CheckBoxAcrescimo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.TextBox txtNomeTaxa;
        private System.Windows.Forms.Label label1;
    }
}