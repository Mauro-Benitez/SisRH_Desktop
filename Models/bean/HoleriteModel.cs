using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using SisRH_Desktop.Enum;
using SisRH_Desktop.Models.dao;

namespace SisRH_Desktop.Model
{
    public class HoleriteModel
    {
        DaoHolerite daoHolerite = null;

        public int Id_Holerite { get;  set; }
        public FuncionarioModel Funcionario { get; set; }

        public DateTime Data_emissão = DateTime.Now;

        public EnumMes Mes_referencia = EnumMes.Novembro;

        public int Dias_trabalhados = 30;
        public double Salario_bruto { get; set; }
        public double salario_liquido { get; set; }

        public string NomeEmpresa = "SISRH";
        public double Desconto_INSS { get; private set; }

        public double Desconto_FGTS = 8.0;

        public double Desconto_VT = 5.0;
        public TaxaModel Outras_Taxas { get; set; }

        public HoleriteModel()
        {
        }

        public HoleriteModel(int id_Holerite)
        {
            Id_Holerite = id_Holerite;
            CalculoInss();
            SalarioLiquido();
            
        }

        public HoleriteModel(FuncionarioModel funcionario)
        {
            Funcionario = funcionario;
            Salario_bruto = funcionario.salario_bruto;
            CalculoInss();
            SalarioLiquido();
            daoHolerite = new DaoHolerite();
            Outras_Taxas = daoHolerite.HoleriteMaisTaxas(funcionario);
        }

        private void CalculoInss()
        {
            if(Funcionario.salario_bruto <= 1.320)
            {
                Desconto_INSS = 7.5;
            }

            else if(Funcionario.salario_bruto >= 1.320 && Funcionario.salario_bruto <= 2.571)
            {
                Desconto_INSS = 9.0;
            }
            else if(Funcionario.salario_bruto >= 2.571 && Funcionario.salario_bruto <= 3.856)
            {
                Desconto_INSS = 12.0;
            }

            else
            {
                //para quem ganha entre  3.856 e 7.507
                Desconto_INSS = 14.0;
            }
                      
           
        }
        public double ValorDescontoInss()
        {
            double inss = Desconto_INSS;
            double salarioBruto = Funcionario.salario_bruto;

            double desconto = salarioBruto * inss/100;

            return desconto;
        }

        public double ValorDescontoFGTS()
        {
            double fgts = Desconto_FGTS;
            double salarioBruto = Funcionario.salario_bruto;

            double desconto = salarioBruto * fgts/100;

            return desconto;
        }
        public double ValorDescontoVT()
        {
            double VT = Desconto_VT;
            double salarioBruto = Funcionario.salario_bruto;

            double desconto = salarioBruto * VT/100;

            return desconto;
        }

        public double ValorTotalDescontos()
        {
            double totalDescontos = ValorDescontoInss() + ValorDescontoFGTS() + ValorDescontoVT();

            return totalDescontos;
        }
        public void SalarioLiquido()
        {

            salario_liquido = Salario_bruto - ValorTotalDescontos();

        }
       


    }
}
