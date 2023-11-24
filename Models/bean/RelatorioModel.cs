using SisRH_Desktop.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisRH_Desktop.Model
{
    public class RelatorioModel
    {
       

        public HoleriteModel holerite { get; set; }

        public TaxaModel taxa { get; set; }

        public string taxaNome { get; set; }

        public RelatorioModel()
        {
        }
        public RelatorioModel(string nome)
        {
            this.taxaNome = nome;
        }


        public RelatorioModel(int id, string nomeDaTaxa, EnumTipo tipo, double valor, double valorPosTaxa, double porcentagem) 
        {
            this.taxa.id_Taxa = id;
            this.taxa.nomedaTaxa = nomeDaTaxa;
            this.taxa.tipo = tipo;
            this.taxa.Valor = valor;
            this.taxa.ValorPostaxa = valorPosTaxa;
            this.taxa.Porcentagem = porcentagem;


        }


















    }
}
