using SisRH_Desktop.Controller;
using SisRH_Desktop.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SisRH_Desktop.View.forms
{
    public partial class f_Perfil2 : Form
    {
        public f_Perfil2(string email, string senha)
        {
            CarregarDados(email, senha);
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        private void CarregarDados(string email, string senha)
        {

            ControllerFuncionario ContFuncionario = new ControllerFuncionario();
            FuncionarioModel funEntrada = new FuncionarioModel(email, senha);
            FuncionarioModel funcionario = ContFuncionario.CarregarDadosLogado(funEntrada);
            txtNome.Text = funcionario.nome;
            txtCargo.Text = funcionario.cargo;
            txtEndereco.Text = funcionario.endereco;
            txtEmail.Text = funcionario.email;            
            txtTelefone.Text = funcionario.telefone;
            dtNascimento.Value = funcionario.data_nascimento;
            dtContratacao.Value = funcionario.data_contratacao;
            txtHoras.Text = funcionario.horas_mensais.ToString();
            txtSalario.Text = funcionario.salario_bruto.ToString();
            txtVR.Text = funcionario.valor_vr.ToString();
            txtVT.Text = funcionario.valor_vt.ToString();
            txtAtivo.Text = funcionario.ativo.ToString();
            txtNivel.Text = funcionario.nivel_acesso.ToString();


            int nivelAcesso = (int)funcionario.nivel_acesso;

            if (nivelAcesso == 1)
            {
                checkBoxAcesso.Checked = true;
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
