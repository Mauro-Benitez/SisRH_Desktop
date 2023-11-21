using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisRH_Desktop.Model
{
    public class TaxaModel
    {
        public int id { get; set; }
        public string nome { get; set; }
        public HoleriteModel holerite { get; set; }
        public FuncionarioModel funcionario { get; set; }
        double valor_base { get; set; }
        int desconto_acresimo { get; set; }
        int ativo { get; set; }
    }
}
