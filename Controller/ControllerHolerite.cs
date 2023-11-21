using SisRH_Desktop.Model;
using SisRH_Desktop.Models.dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisRH_Desktop.Controller
{
    public class ControllerHolerite
    {
        DaoHolerite daoholerite = null;
        DaoFuncionario daoFuncionario = null;



        public HoleriteModel GerarHolerite (FuncionarioModel funEntrada)
        {
            daoFuncionario = new DaoFuncionario ();
            daoholerite = new DaoHolerite();
            FuncionarioModel funSaida = daoFuncionario.CarregarTodosOsDadosFuncionarios(funEntrada.registro);


            HoleriteModel holeriteEntrada = new HoleriteModel(funSaida);

            HoleriteModel holeriteSaida = daoholerite.InserirDados(holeriteEntrada, funSaida);

            return holeriteEntrada;

        }






    }
}
