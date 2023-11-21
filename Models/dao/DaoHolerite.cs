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
    public class DaoHolerite
    {


        private SqlConnection con;
        private SqlCommand cmd;

        private readonly string url = @"Data Source=DESKTOP-DNIRGUH\SQLEXPRESS;Initial Catalog=BD_Funcionario;"
        + "Integrated Security=true;";



        public HoleriteModel InserirDados(HoleriteModel holeEntrada, FuncionarioModel funEntrada)
        {
            try
            {
                // Conexao
                con = new SqlConnection(url);

                String sql = "INSERT INTO TB_Holerite (id_funcionario, nome_funcionario, data_emissao, mes_referencia, dias_trabalhados, SalarioBruto, SalarioLiquido, nome_empresa, desconto_inss, desconto_fgts, desconto_vt) " +
                    "values (@id_registro,@nome_funcionario,@data_emissao,@mes_referencia,@dias_trabalhados,@SalarioBruto,@SalarioLiquido,@nome_empresa,@desconto_inss,@desconto_fgts,@desconto_vt) SET @id_holerite = SCOPE_IDENTITY();;";
                cmd = new SqlCommand(sql, con);

                cmd.Parameters.AddWithValue("@id_registro", funEntrada.registro);
                cmd.Parameters.AddWithValue("@nome_funcionario", funEntrada.nome);
                cmd.Parameters.AddWithValue("@data_emissao", holeEntrada.Data_emissão);
                cmd.Parameters.AddWithValue("@mes_referencia", (int)holeEntrada.Mes_referencia);  
                cmd.Parameters.AddWithValue("@dias_trabalhados", holeEntrada.Dias_trabalhados);
                cmd.Parameters.AddWithValue("@SalarioBruto", holeEntrada.Salario_bruto);
                cmd.Parameters.AddWithValue("@SalarioLiquido", holeEntrada.salario_liquido);
                cmd.Parameters.AddWithValue("@nome_empresa", holeEntrada.NomeEmpresa);
                cmd.Parameters.AddWithValue("@desconto_inss", holeEntrada.Desconto_INSS);
                cmd.Parameters.AddWithValue("@desconto_fgts", holeEntrada.Desconto_FGTS);
                cmd.Parameters.AddWithValue("@desconto_vt", holeEntrada.Desconto_VT);
                cmd.Parameters.Add("@id_holerite", SqlDbType.Int, 4).Direction = ParameterDirection.Output;


                con.Open();
                cmd.ExecuteNonQuery();
                holeEntrada.Id_Holerite = Convert.ToInt32(cmd.Parameters["@id_holerite"].Value);


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

            return holeEntrada;




        }






    }
}
