using SisRH_Desktop.Model;
using SisRH_Desktop.Models.dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SisRH_Desktop.Controller
{
    public class ControllerRelatorio
    {


        DaoRelatorio daoRelatorio = null;


        public TaxaModel GerarHoleiteComTaxa(FuncionarioModel funEntrada)
        {
            daoRelatorio = new DaoRelatorio();

            List<TaxaModel> listaSaida = daoRelatorio.HoleriteMaisTaxas(funEntrada);

            if (listaSaida != null && listaSaida.Count > 0)
            {
                return listaSaida[0];
            }

            else
            {
                MessageBox.Show("Erro, valor nulo");
                return null;
                
            }
           

        }
       



    }
}
