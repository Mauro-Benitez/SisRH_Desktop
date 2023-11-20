using Microsoft.Win32;
using SisRH_Desktop.Controller;
using SisRH_Desktop.Enum;
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

namespace SisRH_Desktop.Forms
{
    public partial class f_AtualizarColaborador : Form
    {
        int registroColaborador;
        public f_AtualizarColaborador(int registro)
        {
            registroColaborador = registro;
            InitializeComponent();
            CarregarDados(registro);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void f_AtualizarColaborador_Load(object sender, EventArgs e)
        {

        }

        private void CarregarDados(int registro)
        {
            ControllerFuncionario ContFuncionario = new ControllerFuncionario();
            FuncionarioModel funcionario = ContFuncionario.CarregarTodosOsDados(registro);
            txtNome.Text = funcionario.nome;
            txtCargo.Text = funcionario.cargo;
            txtEndereco.Text = funcionario.endereco;
            txtEmail.Text = funcionario.email;
            txtSenha.Text = funcionario.senha;
            txtTelefone.Text = funcionario.telefone;
            dtNascimento.Value = funcionario.data_nascimento;
            dtContratacao.Value = funcionario.data_contratacao;
            txtHoras.Text = funcionario.horas_mensais.ToString();
            txtSalarioBruto.Text = funcionario.salario_bruto.ToString();
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


        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            EnumAcessos Acesso = EnumAcessos.Colaborador;
            EnumAtivo Ativo = EnumAtivo.Sim;
            int horasMensais = int.Parse(txtHoras.Text);
            double VR = double.Parse(txtVR.Text);
            double VT = double.Parse(txtVT.Text);
            double salarioBruto = double.Parse(txtSalarioBruto.Text);

            if (checkBoxAcesso.Checked)
            {
                Acesso = EnumAcessos.AdministradorRH;
            }                  
                        
           
            try
            {
                ControllerFuncionario contFuncionario = new ControllerFuncionario();
                FuncionarioModel funcionarioEnt = new FuncionarioModel(registroColaborador, txtNome.Text, txtEndereco.Text, txtEmail.Text,
                                                                  txtTelefone.Text, dtNascimento.Value, dtContratacao.Value,
                                                                  horasMensais, VT, VR, salarioBruto, Acesso, txtSenha.Text,
                                                                  Ativo, txtCargo.Text);

                FuncionarioModel funcionarioSaida = contFuncionario.Atualizar(funcionarioEnt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            
            }

            finally
            {
                MessageBox.Show("Funcionário Atualizado!");
                limparcampos();
                this.Close();
            }
        }



        private void limparcampos()
        {
            txtNome.Text = string.Empty;
            txtCargo.Text = string.Empty;
            txtEndereco.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtSenha.Text = string.Empty;
            txtTelefone.Text = string.Empty;
            dtNascimento.Text = string.Empty;
            dtContratacao.Text = string.Empty;
            txtHoras.Text = string.Empty;
            txtSalarioBruto.Text = string.Empty;
            txtSalarioBruto.Text = string.Empty;
            txtVR.Text = string.Empty;
            txtVT.Text = string.Empty;

        }

        private void btnDesativar_Click(object sender, EventArgs e)
        {

            DialogResult resultado = MessageBox.Show("Deseja realmente desativar o colaborador(a)?", "Aviso", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);

            if (resultado == DialogResult.Yes)
            {
                try
                {
                    FuncionarioModel funEntrada = new FuncionarioModel(registroColaborador);
                    ControllerFuncionario conFuncionario = new ControllerFuncionario();
                    FuncionarioModel funSaida = conFuncionario.Desativar(funEntrada);
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    MessageBox.Show("Funcionário desativado");
                    limparcampos();
                    this.Close();
                }
            }

           


        }
    }
}
