using SisRH_Desktop.Controller;
using SisRH_Desktop.Model;
using SisRH_Desktop.Models.dao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tela_Login_Sis_RH;

namespace SisRH_Desktop.View.forms
{
    public partial class f_Perfil2 : Form
    {
        string login;
        string senha;


        public f_Perfil2(string login,string senha)
        {
            InitializeComponent();
            this.login = login;
            this.senha = senha;
            CarregarDados();
           
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        private void CarregarDados()
        {
            try
            {
                FuncionarioModel funEntrada = new FuncionarioModel(login, senha);
                ControllerFuncionario controllerFuncionario = new ControllerFuncionario();
                FuncionarioModel funSaida = controllerFuncionario.CarregarDadosLogado(funEntrada);
                
                txtNome.Text = funSaida.nome;
                txtCargo.Text = funSaida.cargo;
                txtEndereco.Text = funSaida.endereco;              
                txtEmail.Text = funSaida.email;
                txtTelefone.Text = funSaida.telefone;
                dtNascimento.Value = funSaida.data_nascimento;
                dtContratacao.Value = funSaida.data_contratacao;
                txtHoras.Text = funSaida.horas_mensais.ToString();
                txtSalario.Text =  funSaida.salario_bruto.ToString("f2");
                txtVR.Text = funSaida.valor_vr.ToString("f2");
                txtVT.Text = funSaida.valor_vt.ToString("f2");
                txtAtivo.Text = funSaida.ativo.ToString();
                txtNivel.Text = funSaida.nivel_acesso.ToString();
                txtRegistro.Text = funSaida.registro.ToString();


                int nivelAcesso = (int)funSaida.nivel_acesso;

                if (nivelAcesso == 1)
                {
                    checkBoxAcesso.Checked = true;
                }

            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtHoras_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtSalario_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtVR_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtVT_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
