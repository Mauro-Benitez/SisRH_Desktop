using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SisRH_Desktop.Model
{
    internal class HoleriteModel
    {
        public int Id_Holerite { get; set; }
        public FuncionarioModel Funcionario { get; set; }
        public DateTime Data_emissão { get; set; }
        public int Mes_referencia { get; set; }
        public int Dias_trabalhados { get; set; }
        public double Salario_bruto { get; set; }
        public double salario_liquido { get; set; }

        public string NomeEmpresa = "SISRH";
        public double Desconto_INSS {  get; set; }
        public double Desconto_FGTS { get; set; }
        public double Desconto_VT{ get; set; }

        public HoleriteModel(int id_Holerite)
        {
            Id_Holerite = id_Holerite;
        }

        public HoleriteModel(FuncionarioModel funcionario)
        {
            Funcionario = funcionario;
        }





    }
}
