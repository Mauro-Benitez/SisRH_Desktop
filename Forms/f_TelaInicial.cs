using SisRH_Desktop.Controller;
using SisRH_Desktop.Model;
using SisRH_Desktop.View.forms;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tela_Login_Sis_RH;

namespace SisRH_Desktop
{
    public partial class f_TelaInicial : Form
    {
        private Form FormAtivo;
        string login;
        string senha;
        FuncionarioModel funcionariioLogado = null;


        public f_TelaInicial()
        {
            InitializeComponent();
        }
        public f_TelaInicial(string login, string senha)
        {
            this.login = login;
            this.senha = senha; 
            InitializeComponent();
            FuncionarioLogado();
        }
        private void FuncionarioLogado()
        {
            FuncionarioModel funEntrada = new FuncionarioModel(login, senha);
            ControllerFuncionario controllerFuncionario = new ControllerFuncionario();
            FuncionarioModel funSaida = controllerFuncionario.CarregarDadosLogado(funEntrada);

            lblNome.Text = funSaida.nome;
            lblCargo.Text = funSaida.cargo;

            funcionariioLogado = funSaida;


        }

        private void FormShow(Form frm)
        {
            FecharFormAtivo();
            FormAtivo = frm;
            frm.TopLevel = false;
            panel_form.Controls.Add(FormAtivo);
            frm.BringToFront();
            frm.Show();
        }
       
        private void FecharFormAtivo()
        {
            if (FormAtivo != null)
            {
                FormAtivo.Close();
            }
        }
       
        private void btnAtivo(Button btn)
        {
            
            foreach (Control ctrl in panelPrincipal.Controls)
            {
                ctrl.ForeColor = Color.White;
                if (ctrl is Button button)
                {
                    button.BackColor =Color.FromArgb(56, 58, 99);
                }
            }         
                        


                btn.BackColor= Color.FromArgb(104, 124, 243);
             
        }       

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void panel_form_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Gerenciar_Click(object sender, EventArgs e)
        {
            btnAtivo(btn_Gerenciar);
            FormShow(new f_ListarColab());
        }

        

        private void btnAutomacao_Click(object sender, EventArgs e)
        {
            btnAtivo(btnAutomacao);
            FormShow(new f_CriarAutomacoes());
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            btnAtivo(btnRelatorio);
            FormShow(new f_Relatorio());
        }

        private void btnTaxas_Click(object sender, EventArgs e)
        {
            btnAtivo(btnTaxas);
            FormShow(new f_Taxas());
        }

        private void f_TelaInicial_Load(object sender, EventArgs e)
        {

        }

        private void panelPrincipal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
         
            //FormShow(new f_Perfil2());
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        
        

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {

        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
        }

        private void btn_Gerenciar_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void pictureBox1_Click_3(object sender, EventArgs e)
        {

        }
       

        private void label2_Click_1(object sender, EventArgs e)
        {
            

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {
           
        }

        private void panel2_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        
        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void pbImagemLogin_Click(object sender, EventArgs e)
        {
            
                FormShow(new f_Perfil2(login,senha));
                foreach (Control ctrl in panelPrincipal.Controls)
                {
                    ctrl.BackColor = BackColor = Color.FromArgb(56, 58, 99);

                }
            

        }
    }
}
