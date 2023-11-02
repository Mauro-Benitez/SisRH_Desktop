namespace SisRH_Desktop
{
    partial class f_TelaInicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f_TelaInicial));
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.btnTaxas = new System.Windows.Forms.Button();
            this.btnRelatorio = new System.Windows.Forms.Button();
            this.btnAutomacao = new System.Windows.Forms.Button();
            this.btn_Gerenciar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panel_form = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelPrincipal.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel_form.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(58)))), ((int)(((byte)(99)))));
            this.panelPrincipal.Controls.Add(this.panel2);
            this.panelPrincipal.Controls.Add(this.btnTaxas);
            this.panelPrincipal.Controls.Add(this.btnRelatorio);
            this.panelPrincipal.Controls.Add(this.btnAutomacao);
            this.panelPrincipal.Controls.Add(this.btn_Gerenciar);
            this.panelPrincipal.Controls.Add(this.panel3);
            this.panelPrincipal.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelPrincipal.Location = new System.Drawing.Point(0, 0);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(257, 575);
            this.panelPrincipal.TabIndex = 0;
            this.panelPrincipal.Paint += new System.Windows.Forms.PaintEventHandler(this.panelPrincipal_Paint);
            // 
            // btnTaxas
            // 
            this.btnTaxas.BackColor = System.Drawing.Color.Transparent;
            this.btnTaxas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTaxas.FlatAppearance.BorderSize = 0;
            this.btnTaxas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(64)))), ((int)(((byte)(108)))));
            this.btnTaxas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(64)))), ((int)(((byte)(108)))));
            this.btnTaxas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaxas.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaxas.ForeColor = System.Drawing.Color.White;
            this.btnTaxas.Image = global::SisRH_Desktop.Properties.Resources.icon_taxas_32;
            this.btnTaxas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTaxas.Location = new System.Drawing.Point(0, 420);
            this.btnTaxas.Name = "btnTaxas";
            this.btnTaxas.Size = new System.Drawing.Size(250, 80);
            this.btnTaxas.TabIndex = 5;
            this.btnTaxas.Text = "   Cálculo de Taxas";
            this.btnTaxas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTaxas.UseVisualStyleBackColor = false;
            this.btnTaxas.Click += new System.EventHandler(this.btnTaxas_Click);
            // 
            // btnRelatorio
            // 
            this.btnRelatorio.BackColor = System.Drawing.Color.Transparent;
            this.btnRelatorio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRelatorio.FlatAppearance.BorderSize = 0;
            this.btnRelatorio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(64)))), ((int)(((byte)(108)))));
            this.btnRelatorio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(64)))), ((int)(((byte)(108)))));
            this.btnRelatorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRelatorio.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelatorio.ForeColor = System.Drawing.Color.White;
            this.btnRelatorio.Image = global::SisRH_Desktop.Properties.Resources.icon_relat_32;
            this.btnRelatorio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRelatorio.Location = new System.Drawing.Point(0, 320);
            this.btnRelatorio.Name = "btnRelatorio";
            this.btnRelatorio.Size = new System.Drawing.Size(250, 80);
            this.btnRelatorio.TabIndex = 4;
            this.btnRelatorio.Text = "   Gerar Relatório";
            this.btnRelatorio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRelatorio.UseVisualStyleBackColor = false;
            this.btnRelatorio.Click += new System.EventHandler(this.btnRelatorio_Click);
            // 
            // btnAutomacao
            // 
            this.btnAutomacao.BackColor = System.Drawing.Color.Transparent;
            this.btnAutomacao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAutomacao.FlatAppearance.BorderSize = 0;
            this.btnAutomacao.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(64)))), ((int)(((byte)(108)))));
            this.btnAutomacao.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(64)))), ((int)(((byte)(108)))));
            this.btnAutomacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAutomacao.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAutomacao.ForeColor = System.Drawing.Color.White;
            this.btnAutomacao.Image = global::SisRH_Desktop.Properties.Resources.icon_automacao_32;
            this.btnAutomacao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAutomacao.Location = new System.Drawing.Point(0, 220);
            this.btnAutomacao.Name = "btnAutomacao";
            this.btnAutomacao.Size = new System.Drawing.Size(250, 80);
            this.btnAutomacao.TabIndex = 3;
            this.btnAutomacao.Text = "   Criar Automação";
            this.btnAutomacao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAutomacao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAutomacao.UseVisualStyleBackColor = false;
            this.btnAutomacao.Click += new System.EventHandler(this.btnAutomacao_Click);
            // 
            // btn_Gerenciar
            // 
            this.btn_Gerenciar.BackColor = System.Drawing.Color.Transparent;
            this.btn_Gerenciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Gerenciar.FlatAppearance.BorderSize = 0;
            this.btn_Gerenciar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(64)))), ((int)(((byte)(108)))));
            this.btn_Gerenciar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(64)))), ((int)(((byte)(108)))));
            this.btn_Gerenciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Gerenciar.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Gerenciar.ForeColor = System.Drawing.Color.White;
            this.btn_Gerenciar.Image = global::SisRH_Desktop.Properties.Resources.icon_colaboradores_32;
            this.btn_Gerenciar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Gerenciar.Location = new System.Drawing.Point(0, 120);
            this.btn_Gerenciar.Name = "btn_Gerenciar";
            this.btn_Gerenciar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_Gerenciar.Size = new System.Drawing.Size(250, 80);
            this.btn_Gerenciar.TabIndex = 2;
            this.btn_Gerenciar.Text = "       Gerenciar \r\n    Colaboradores";
            this.btn_Gerenciar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Gerenciar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Gerenciar.UseVisualStyleBackColor = false;
            this.btn_Gerenciar.Click += new System.EventHandler(this.btn_Gerenciar_Click);
            this.btn_Gerenciar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_Gerenciar_MouseClick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(55)))), ((int)(((byte)(96)))));
            this.panel3.Controls.Add(this.button6);
            this.panel3.Controls.Add(this.button5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 525);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(257, 50);
            this.panel3.TabIndex = 1;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Transparent;
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(64)))), ((int)(((byte)(108)))));
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(64)))), ((int)(((byte)(108)))));
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Image = global::SisRH_Desktop.Properties.Resources.icon_logout_16;
            this.button6.Location = new System.Drawing.Point(215, 3);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(30, 44);
            this.button6.TabIndex = 1;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(64)))), ((int)(((byte)(108)))));
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(64)))), ((int)(((byte)(108)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Image = global::SisRH_Desktop.Properties.Resources.icon_config_16;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(0, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(210, 44);
            this.button5.TabIndex = 0;
            this.button5.Text = " Configurações";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // panel_form
            // 
            this.panel_form.Controls.Add(this.pictureBox2);
            this.panel_form.Location = new System.Drawing.Point(251, 0);
            this.panel_form.Name = "panel_form";
            this.panel_form.Size = new System.Drawing.Size(682, 575);
            this.panel_form.TabIndex = 1;
            this.panel_form.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_form_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SisRH_Desktop.Properties.Resources.logo_320;
            this.pictureBox2.Location = new System.Drawing.Point(157, 210);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(380, 133);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::SisRH_Desktop.Properties.Resources.icon_perfil_108;
            this.pictureBox1.Location = new System.Drawing.Point(3, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(84, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_4);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(55)))), ((int)(((byte)(96)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(257, 100);
            this.panel2.TabIndex = 6;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint_1);
            this.panel2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseClick);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(90, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Gerente RH";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(90, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(132, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Matheus Borges";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // f_TelaInicial
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.ClientSize = new System.Drawing.Size(933, 575);
            this.Controls.Add(this.panel_form);
            this.Controls.Add(this.panelPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "f_TelaInicial";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sis.RH";
            this.Load += new System.EventHandler(this.f_TelaInicial_Load);
            this.panelPrincipal.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel_form.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnTaxas;
        private System.Windows.Forms.Button btnRelatorio;
        private System.Windows.Forms.Button btnAutomacao;
        private System.Windows.Forms.Button btn_Gerenciar;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Panel panel_form;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

