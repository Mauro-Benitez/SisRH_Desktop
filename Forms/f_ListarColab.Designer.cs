namespace SisRH_Desktop
{
    partial class f_ListarColab
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f_ListarColab));
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnEmitir = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnAtualizarDados = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.panelBusca = new System.Windows.Forms.Panel();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.lvFuncionario = new System.Windows.Forms.ListView();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.panel4.SuspendLayout();
            this.panelBusca.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnEmitir);
            this.panel4.Controls.Add(this.btnNovo);
            this.panel4.Controls.Add(this.btnAtualizarDados);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(597, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(255, 719);
            this.panel4.TabIndex = 1;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // btnEmitir
            // 
            this.btnEmitir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(124)))), ((int)(((byte)(243)))));
            this.btnEmitir.FlatAppearance.BorderSize = 0;
            this.btnEmitir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmitir.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmitir.ForeColor = System.Drawing.Color.White;
            this.btnEmitir.Location = new System.Drawing.Point(48, 234);
            this.btnEmitir.Margin = new System.Windows.Forms.Padding(0);
            this.btnEmitir.Name = "btnEmitir";
            this.btnEmitir.Size = new System.Drawing.Size(175, 38);
            this.btnEmitir.TabIndex = 3;
            this.btnEmitir.Text = "Emitir Holerite";
            this.btnEmitir.UseMnemonic = false;
            this.btnEmitir.UseVisualStyleBackColor = false;
            this.btnEmitir.Click += new System.EventHandler(this.btnEmitir_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(124)))), ((int)(((byte)(243)))));
            this.btnNovo.FlatAppearance.BorderSize = 0;
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovo.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.ForeColor = System.Drawing.Color.White;
            this.btnNovo.Location = new System.Drawing.Point(48, 302);
            this.btnNovo.Margin = new System.Windows.Forms.Padding(0);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(175, 38);
            this.btnNovo.TabIndex = 2;
            this.btnNovo.Text = "Cadastrar Novo";
            this.btnNovo.UseMnemonic = false;
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnAtualizarDados
            // 
            this.btnAtualizarDados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(124)))), ((int)(((byte)(243)))));
            this.btnAtualizarDados.FlatAppearance.BorderSize = 0;
            this.btnAtualizarDados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizarDados.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizarDados.ForeColor = System.Drawing.Color.White;
            this.btnAtualizarDados.Location = new System.Drawing.Point(48, 372);
            this.btnAtualizarDados.Margin = new System.Windows.Forms.Padding(0);
            this.btnAtualizarDados.Name = "btnAtualizarDados";
            this.btnAtualizarDados.Size = new System.Drawing.Size(175, 38);
            this.btnAtualizarDados.TabIndex = 1;
            this.btnAtualizarDados.Text = "Atualizar Dados";
            this.btnAtualizarDados.UseMnemonic = false;
            this.btnAtualizarDados.UseVisualStyleBackColor = false;
            this.btnAtualizarDados.Click += new System.EventHandler(this.btnAtualizarDados_Click);
            // 
            // txtNome
            // 
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNome.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(8, 42);
            this.txtNome.Margin = new System.Windows.Forms.Padding(0);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(484, 34);
            this.txtNome.TabIndex = 5;
            // 
            // panelBusca
            // 
            this.panelBusca.Controls.Add(this.btnAtualizar);
            this.panelBusca.Controls.Add(this.lvFuncionario);
            this.panelBusca.Controls.Add(this.btnBuscar);
            this.panelBusca.Controls.Add(this.txtNome);
            this.panelBusca.Location = new System.Drawing.Point(-2, 1);
            this.panelBusca.Margin = new System.Windows.Forms.Padding(2);
            this.panelBusca.Name = "panelBusca";
            this.panelBusca.Size = new System.Drawing.Size(600, 718);
            this.panelBusca.TabIndex = 10;
            this.panelBusca.Paint += new System.Windows.Forms.PaintEventHandler(this.panelBusca_Paint);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(124)))), ((int)(((byte)(243)))));
            this.btnAtualizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAtualizar.BackgroundImage")));
            this.btnAtualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAtualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtualizar.FlatAppearance.BorderSize = 0;
            this.btnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizar.Location = new System.Drawing.Point(556, 41);
            this.btnAtualizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(36, 36);
            this.btnAtualizar.TabIndex = 6;
            this.btnAtualizar.UseVisualStyleBackColor = false;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // lvFuncionario
            // 
            this.lvFuncionario.AllowColumnReorder = true;
            this.lvFuncionario.CheckBoxes = true;
            this.lvFuncionario.FullRowSelect = true;
            this.lvFuncionario.GridLines = true;
            this.lvFuncionario.HideSelection = false;
            this.lvFuncionario.HoverSelection = true;
            this.lvFuncionario.Location = new System.Drawing.Point(8, 84);
            this.lvFuncionario.Name = "lvFuncionario";
            this.lvFuncionario.Size = new System.Drawing.Size(585, 629);
            this.lvFuncionario.TabIndex = 0;
            this.lvFuncionario.UseCompatibleStateImageBehavior = false;
            this.lvFuncionario.View = System.Windows.Forms.View.Details;
            this.lvFuncionario.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.lvFuncionario_ItemChecked);
            this.lvFuncionario.SelectedIndexChanged += new System.EventHandler(this.lvFuncionario_SelectedIndexChanged);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(124)))), ((int)(((byte)(243)))));
            this.btnBuscar.BackgroundImage = global::SisRH_Desktop.Properties.Resources.icon_search_32;
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Location = new System.Drawing.Point(506, 41);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(36, 36);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // f_ListarColab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(852, 719);
            this.Controls.Add(this.panelBusca);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "f_ListarColab";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Sis.RH";
            this.TransparencyKey = System.Drawing.Color.Turquoise;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.f_ListarColab_Load);
            this.panel4.ResumeLayout(false);
            this.panelBusca.ResumeLayout(false);
            this.panelBusca.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnAtualizarDados;
        private System.Windows.Forms.Button btnEmitir;
        public System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Panel panelBusca;
        private System.Windows.Forms.ListView lvFuncionario;
        private System.Windows.Forms.Button btnAtualizar;
    }
}