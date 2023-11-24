using SisRH_Desktop.Controller;
using SisRH_Desktop.Enum;
using SisRH_Desktop.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SisRH_Desktop.Models.dao
{
    public class DaoRelatorio
    {

        private SqlConnection con;
        private SqlCommand cmd;

        private readonly string url = @"Data Source=DESKTOP-DNIRGUH\SQLEXPRESS;Initial Catalog=BD_Funcionario;"
        + "Integrated Security=true;";

        public DaoRelatorio()
        {
        }

        public List<TaxaModel> HoleriteMaisTaxas(FuncionarioModel funcionarioEntrada)
        {
            RelatorioModel relatorioSaida = new RelatorioModel();
            List<TaxaModel> taxaLista = new List<TaxaModel>();
            TaxaModel taxaModel = null;
            try
            {

                // Conexao
                con = new SqlConnection(url);
                String sql = @" SELECT 
                              
                              t.id_Taxa AS ID_Taxa,
                              t.nome_taxa AS Nome_Taxa,                             
                              t.Valor AS Valor,
	                          t.ValorPosTaxa AS ValorPosTaxa,
                              t.porcentagem_taxa AS Porcentagem_Taxa
                                FROM 
                                TB_funcionario f
                                LEFT JOIN 
                                TB_Holerite h ON f.registro = h.id_funcionario
                                LEFT JOIN 
                                TB_Taxa t ON f.registro = t.id_Funcionario
                                WHERE 
                                f.registro =@registro;";
                cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@registro", funcionarioEntrada.registro);
                con.Open();
                SqlDataReader relatorio = cmd.ExecuteReader();

                while (relatorio.Read())
                {
                    taxaModel = new TaxaModel(1, "nome teste", 200.00, 6000.00, 3.0); ;

                    taxaLista.Add(taxaModel);
                }


                

            }
             catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                con.Close();
            }

            return taxaLista;
        }   



    }
}
