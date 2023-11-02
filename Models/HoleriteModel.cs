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
        int id{ get; set; }
        FuncionarioModel funcionario { get; set; }
        DateTime data_emissão { get; set; }
        int mes_referencia { get; set; }
        double salario_liquido { get; set; }
    }
}
