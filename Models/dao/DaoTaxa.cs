using SisRH_Desktop.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisRH_Desktop.Models.dao
{
    public class DaoTaxa
    {
        private SqlConnection con;
        private SqlCommand cmd;

        private readonly string url = @"Data Source=DESKTOP-DNIRGUH\SQLEXPRESS;Initial Catalog=BD_Funcionario;"
        + "Integrated Security=true;";




        public HoleriteModel InserirTaxa(TaxaModel taxaEntrada, FuncionarioModel funcionarioModel)
        {
            try
            {
                // Conexao
                con = new SqlConnection(url);

                String sql = "INSERT INTO TB_Taxa (id_Funcionario,tipo,nome_taxa,Valor,porcentagem_taxa,ValorPosTaxa) " +
                    "values (@id_Funcionario,@tipo, @nome_taxa,@Valor,@porcentagem_taxa,@ValorPosTaxa) SET @id_Taxa = SCOPE_IDENTITY();;";
                cmd = new SqlCommand(sql, con);

                cmd.Parameters.AddWithValue("@id_Funcionario", funcionarioModel.registro);
                cmd.Parameters.AddWithValue("@tipo", taxaEntrada.tipo.ToString()); ;
                cmd.Parameters.AddWithValue("@nome_taxa", taxaEntrada.nomedaTaxa);
                cmd.Parameters.AddWithValue("@ValorPosTaxa", (decimal)taxaEntrada.ValorPostaxa);
                cmd.Parameters.AddWithValue("@Valor", (decimal)taxaEntrada.Valor);
                cmd.Parameters.AddWithValue("@porcentagem_taxa", taxaEntrada.Porcentagem);
                cmd.Parameters.Add("@id_Taxa", SqlDbType.Int, 4).Direction = ParameterDirection.Output;


                con.Open();
                cmd.ExecuteNonQuery();
                taxaEntrada.id_Taxa = Convert.ToInt32(cmd.Parameters["@id_Taxa"].Value);
                //holeriteEntrada.Outras_Taxas = taxaEntrada;


            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }

            finally
            {
                con.Close();
            }

            return null; 




        }
    }
}
