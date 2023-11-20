using SisRH_Desktop.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisRH_Desktop.Model
{
    public class FuncionarioModel
    {
        public int registro { get; set; }
        public string nome { get; set; }
        public string endereco { get; set; }
        public string email { get; set; }
        public string telefone { get; set; }
        public DateTime data_nascimento{ get; set; }
        public DateTime data_contratacao { get; set; }
        public int horas_mensais { get; set; }
        public double valor_vt { get; set; }
        public double valor_vr { get; set; }
        public double salario_bruto { get; set; }
        public EnumAcessos nivel_acesso { get; set; }
        public string senha { get; set; }
        public EnumAtivo ativo { get; set; }
        public string cargo { get; set; }


        public FuncionarioModel()
        {

        }

        public FuncionarioModel(int registro)
        {
            this.registro = registro;
        }

        public FuncionarioModel(int registro, string nome, string email, string cargo, EnumAcessos nivel, EnumAtivo ativo)
        {
            this.registro = registro;
            this.nome = nome;
            this.email = email;
            this.cargo = cargo;
            this.nivel_acesso = nivel;
            this.ativo = ativo;
            
        }

        public FuncionarioModel( string nome)
        {
            
            this.nome = nome;
        }
        public FuncionarioModel(string email, string senha)
        {
            this.email = email;
            this.senha = senha;
        }

        public FuncionarioModel(int registro, string nome, string email, EnumAcessos nivel_acesso, EnumAtivo ativo, string cargo) 
        {
            this.nome = nome;
            this.email = email;
            this.nivel_acesso = nivel_acesso;
            this.ativo = ativo;
            this.cargo = cargo;

        }

        public FuncionarioModel(string nome, string endereco, string email, string telefone, DateTime data_nascimento, DateTime data_contratacao, int horas_mensais, double valor_vt, double valor_vr, double salario_bruto, EnumAcessos nivel_acesso, string senha, EnumAtivo ativo, string cargo)
        {
            this.nome = nome;
            this.endereco = endereco;
            this.email = email;
            this.telefone = telefone;
            this.data_nascimento = data_nascimento;
            this.data_contratacao = data_contratacao.Date;
            this.horas_mensais = horas_mensais;
            this.valor_vt = valor_vt;
            this.valor_vr = valor_vr;
            this.salario_bruto = salario_bruto;
            this.nivel_acesso = nivel_acesso;
            this.senha = senha;
            this.ativo = ativo;
            this.cargo = cargo;
        }

        public FuncionarioModel(int registro, string nome, string endereco, string email, string telefone, DateTime data_nascimento, DateTime data_contratacao, int horas_mensais, double valor_vt, double valor_vr, double salario_bruto, EnumAcessos nivel_acesso, string senha, EnumAtivo ativo, string cargo)
        {
            this.registro = registro;
            this.nome = nome;
            this.endereco = endereco;
            this.email = email;
            this.telefone = telefone;
            this.data_nascimento = data_nascimento;
            this.data_contratacao = data_contratacao.Date;
            this.horas_mensais = horas_mensais;
            this.valor_vt = valor_vt;
            this.valor_vr = valor_vr;
            this.salario_bruto = salario_bruto;
            this.nivel_acesso = nivel_acesso;
            this.senha = senha;
            this.ativo = ativo;
            this.cargo = cargo;
        }

       
    }

















}
