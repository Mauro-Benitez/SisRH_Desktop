using SisRH_Desktop.Controller;
using SisRH_Desktop.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisRH_Desktop.Model
{
    public class TaxaModel
    {
        public int id_Taxa { get; set; }
        public string nomedaTaxa { get; set; }
        public HoleriteModel holerite { get; set; }
        public FuncionarioModel funcionario { get; set; }
        public double Valor { get; set; }
        public double ValorPostaxa{ get; set; }
        public double Porcentagem { get; set; }
        public EnumAtivo ativo { get; set; }
        public EnumTipo tipo { get; set; }

        public TaxaModel()
        {
        }

        public TaxaModel(string nomedaTaxa, double Porcentagem, EnumTipo tipo, FuncionarioModel funcionario)
        {
            ControllerHolerite contHolerite = new ControllerHolerite();


            HoleriteModel holerite = contHolerite.GerarHolerite(funcionario);

            this.holerite = holerite;
            this.nomedaTaxa = nomedaTaxa;
            this.Porcentagem = Porcentagem;
            this.tipo = tipo;
            this.funcionario = funcionario;
            this.Valor = ValorTaxa();

           

            if (tipo == EnumTipo.Acresimo)
            {
                double valor = ValorTaxa();
                holerite.salario_liquido += valor;
                ValorPostaxa = holerite.salario_liquido += valor;
            }


            else
            {
                double valor = ValorTaxa();
                holerite.salario_liquido -= valor;
                ValorPostaxa = holerite.salario_liquido -= valor;

            }


        }

        public TaxaModel(int id_Taxa, string nomedaTaxa,  double valor, double valorPosTaxa, double Porcentagem)
        {            
                this.id_Taxa = id_Taxa;
                this.nomedaTaxa = nomedaTaxa;
                this.Porcentagem = Porcentagem;     
                this.Valor = valor;
                this.ValorPostaxa = valorPosTaxa;                   
        }



        public TaxaModel(int id_Taxa, FuncionarioModel funcionario, HoleriteModel holerite)
        {
            this.id_Taxa = id_Taxa;
            this.funcionario = funcionario;
            this.holerite = holerite;
            Valor = ValorTaxa();
        }

        public TaxaModel(string nomedaTaxa)
        {
            this.nomedaTaxa = nomedaTaxa;

        }

        public double ValorTaxa()
        {
            return holerite.salario_liquido * Porcentagem/100;

        }












    }
}
