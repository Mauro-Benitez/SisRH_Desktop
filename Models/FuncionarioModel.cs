using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisRH_Desktop.Model
{
    internal class FuncionarioModel
    {
        int registro { get; set; }
        string nome { get; set; }
        string endereco { get; set; }
        int telefone { get; set; }
        DateTime data_nascimento{ get; set; }
        DateTime data_contratacao { get; set; }
        double horas_mensais { get; set; }
        double valor_vt { get; set; }
        double valor_vr { get; set; }
        double salario_bruto { get; set; }
        int nivel_acesso { get; set; }
        string senha { get; set; }
        int ativo { get; set; }
        string cargo { get; set; }

    }
}
