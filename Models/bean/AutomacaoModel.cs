using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisRH_Desktop.Model
{
    internal class AutomacaoModel
    {
        int id { get; set; }
        HoleriteModel holerite { get; set; }
        int agendamento { get; set; }
        int ativo { get; set; }
    }
}
