using SisRH_Desktop.Model;
using SisRH_Desktop.Models.dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisRH_Desktop.Controller
{
    public class ControllerTaxa
    {
        DaoHolerite daoHolerite = null;
        DaoTaxa  daoTaxa = null;
        DaoRelatorio daoRelatorio = null;

        public HoleriteModel adicionarTaxa(TaxaModel taxa, FuncionarioModel FunEntrada )
        {

            daoHolerite = new DaoHolerite();

            daoTaxa = new DaoTaxa();

            HoleriteModel holeriteSaida = new HoleriteModel();

            holeriteSaida = daoTaxa.InserirTaxa(taxa, FunEntrada);

            return null;

        }


        







    }
}
