using Microsoft.Win32;
using SisRH_Desktop.Enum;
using SisRH_Desktop.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SisRH_Desktop.Models.dao
{
    public class DaoFuncionario
    {

        private SqlConnection con;
        private SqlCommand cmd;

        private readonly string url = @"Data Source=DESKTOP-DNIRGUH\SQLEXPRESS;Initial Catalog=BD_Funcionario;"
        + "Integrated Security=true;";

        public FuncionarioModel Inserir(FuncionarioModel FuncEntrada)
        {

            try
            {
                // Conexao
                con = new SqlConnection(url);

                String sql = "insert into TB_funcionario(nome,endereco,email,telefone, data_nascimento,data_contratacao,horas_mensais,valor_vt,valor_vr,nivel_acesso,senha,ativo,salario_bruto,cargo)" +
                    " values " +
                    "(@nome,@endereco,@email,@telefone,@data_nascimento,@data_contratacao,@horas_mensais,@valor_vt,@valor_vr,@nivel_acesso,@senha,@ativo,@salario_bruto,@cargo) SET @RegistroRetorno = SCOPE_IDENTITY();;";
                cmd = new SqlCommand(sql, con);


                // parâmetros

                cmd.Parameters.AddWithValue("@nome", FuncEntrada.nome);
                cmd.Parameters.AddWithValue("@endereco", FuncEntrada.endereco);
                cmd.Parameters.AddWithValue("@email", FuncEntrada.email);
                cmd.Parameters.AddWithValue("@telefone", FuncEntrada.telefone);
                cmd.Parameters.AddWithValue("@data_nascimento", FuncEntrada.data_nascimento);
                cmd.Parameters.AddWithValue("@data_contratacao", FuncEntrada.data_contratacao);
                cmd.Parameters.AddWithValue("@horas_mensais", FuncEntrada.horas_mensais);
                cmd.Parameters.Add("@valor_vt", SqlDbType.Decimal).Value = Convert.ToDecimal(FuncEntrada.valor_vt);
                cmd.Parameters.Add("@valor_vr", SqlDbType.Decimal).Value = Convert.ToDecimal(FuncEntrada.valor_vr);
                cmd.Parameters.AddWithValue("@nivel_acesso", (int)FuncEntrada.nivel_acesso);
                cmd.Parameters.AddWithValue("@senha", FuncEntrada.senha);
                cmd.Parameters.AddWithValue("@ativo", (int)FuncEntrada.ativo);
                cmd.Parameters.Add("@salario_bruto", SqlDbType.Decimal).Value = Convert.ToDecimal(FuncEntrada.salario_bruto);
                cmd.Parameters.AddWithValue("@cargo", FuncEntrada.cargo);
                cmd.Parameters.Add("@RegistroRetorno", SqlDbType.Int, 4).Direction = ParameterDirection.Output;

                //  tenta realizar a conexão com o BD
                con.Open();
                cmd.ExecuteNonQuery();
                FuncEntrada.registro = Convert.ToInt32(cmd.Parameters["@RegistroRetorno"].Value);
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

            return FuncEntrada;

        }


        public List<FuncionarioModel> ListarTodos(FuncionarioModel funcEntrada)
        {
            FuncionarioModel funcSaida;
            List<FuncionarioModel> listaFunSaida = new List<FuncionarioModel>();

            try
            {

                // Conexao
                con = new SqlConnection(url);
                String sql = "select registro, nome, email, cargo, nivel_acesso, ativo from TB_funcionario where ativo = 1 ";
                cmd = new SqlCommand(sql, con);
                //cmd.Parameters.AddWithValue("@ativo", 1);
                con.Open();
                SqlDataReader listaFuncionarios = cmd.ExecuteReader();

                while (listaFuncionarios.Read())
                {
                    funcSaida = new FuncionarioModel(listaFuncionarios.GetInt32(0), listaFuncionarios.GetString(1),
                        listaFuncionarios.GetString(2), listaFuncionarios.GetString(3),
                        (EnumAcessos)listaFuncionarios.GetInt32(4), (EnumAtivo)listaFuncionarios.GetInt32(5));
                    listaFunSaida.Add(funcSaida);
                }




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

            return listaFunSaida;
        }


        public List<FuncionarioModel> ListarPorNome(FuncionarioModel funcEntrada)
        {
            FuncionarioModel funcSaida;
            List<FuncionarioModel> listaFunSaida = new List<FuncionarioModel>();

            try
            {

                // Conexao
                con = new SqlConnection(url);
                String sql = "select registro, nome, email, cargo, nivel_acesso, ativo from TB_funcionario where nome like @nome and ativo = 1";
                cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@nome", "%" + funcEntrada.nome + "%");
                con.Open();
                SqlDataReader listaFuncionarios = cmd.ExecuteReader();

                while (listaFuncionarios.Read())
                {
                    funcSaida = new FuncionarioModel(listaFuncionarios.GetInt32(0), listaFuncionarios.GetString(1),
                        listaFuncionarios.GetString(2), listaFuncionarios.GetString(3),
                        (EnumAcessos)listaFuncionarios.GetInt32(4), (EnumAtivo)listaFuncionarios.GetInt32(5));


                    //funcSaida = new FuncionarioModel(listaFuncionarios.GetInt32(0), listaFuncionarios.GetString(1), listaFuncionarios.GetString(2),
                    //                                 (EnumAcessos)listaFuncionarios.GetInt32(3), (EnumAtivo)listaFuncionarios.GetInt32(4),listaFuncionarios.GetString(5));


                    //funcSaida = new FuncionarioModel(listaFuncionarios.GetInt32(0),listaFuncionarios.GetString(1), listaFuncionarios.GetString(2),
                    //    listaFuncionarios.GetString(3), listaFuncionarios.GetString(4), listaFuncionarios.GetDateTime(5),
                    //    listaFuncionarios.GetDateTime(6), listaFuncionarios.GetInt32(7), (double)listaFuncionarios.GetDecimal(8),
                    //    (double)listaFuncionarios.GetDecimal(9), (double)listaFuncionarios.GetDecimal(10), listaFuncionarios.GetInt32(11),
                    //    listaFuncionarios.GetString(11), listaFuncionarios.GetInt32(12), listaFuncionarios.GetString(13));

                    listaFunSaida.Add(funcSaida);
                }




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

            return listaFunSaida;
        }


        public FuncionarioModel Desativar(FuncionarioModel funEntrada )
        {
            try
            {
                con = new SqlConnection(url);
                string sql = "UPDATE TB_funcionario " +
                         "SET ativo = 2" +
                         "WHERE registro = @registro;";

                cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@registro", funEntrada.registro);
                con.Open();
                cmd.ExecuteReader();
                return funEntrada;


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


        }


        public FuncionarioModel CarregarTodosOsDadosFuncionarios(int registro)
        {
            FuncionarioModel funcSaida = null;
            //List<FuncionarioModel> listaFunSaida = new List<FuncionarioModel>();
            try
            {
                con = new SqlConnection(url);
                String sql = "select * from TB_funcionario where registro = @registro";

                cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@registro", registro);
                con.Open();
                SqlDataReader listaFuncionarios = cmd.ExecuteReader();

                while (listaFuncionarios.Read())
                {
                    funcSaida = new FuncionarioModel(listaFuncionarios.GetInt32(0), listaFuncionarios.GetString(1),
                        listaFuncionarios.GetString(2), listaFuncionarios.GetString(3), listaFuncionarios.GetString(4),
                        listaFuncionarios.GetDateTime(5), listaFuncionarios.GetDateTime(6), listaFuncionarios.GetInt32(7),
                        (double)listaFuncionarios.GetDecimal(8), (double)listaFuncionarios.GetDecimal(9), (double)listaFuncionarios.GetDecimal(10),
                        (EnumAcessos)listaFuncionarios.GetInt32(11), listaFuncionarios.GetString(12), (EnumAtivo)listaFuncionarios.GetInt32(13),
                        listaFuncionarios.GetString(14));

                    //listaFunSaida.Add(funcSaida);
                }



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

            return funcSaida;
        }


        public FuncionarioModel Atualizar(FuncionarioModel FuncEntrada)
        {
            try
            {
                con = new SqlConnection(url);
                String sql = "UPDATE TB_funcionario " +
                              "SET nome=@nome, endereco=@endereco, email=@email, telefone=@telefone, data_nascimento=@data_nascimento," +
                              "data_contratacao=@data_contratacao, horas_mensais=@horas_mensais, valor_vt=@valor_vt, valor_vr=@valor_vr," +
                              "salario_bruto=@salario_bruto, nivel_acesso=@nivel_acesso, senha=@senha, ativo=@ativo, cargo=@cargo " +
                              "WHERE registro=@registro";

                cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@nome", FuncEntrada.nome);
                cmd.Parameters.AddWithValue("@endereco", FuncEntrada.endereco);
                cmd.Parameters.AddWithValue("@email", FuncEntrada.email);
                cmd.Parameters.AddWithValue("@telefone", FuncEntrada.telefone);
                cmd.Parameters.AddWithValue("@data_nascimento", FuncEntrada.data_nascimento);
                cmd.Parameters.AddWithValue("@data_contratacao", FuncEntrada.data_contratacao);
                cmd.Parameters.AddWithValue("@horas_mensais", FuncEntrada.horas_mensais);
                cmd.Parameters.Add("@valor_vt", SqlDbType.Decimal).Value = Convert.ToDecimal(FuncEntrada.valor_vt);
                cmd.Parameters.Add("@valor_vr", SqlDbType.Decimal).Value = Convert.ToDecimal(FuncEntrada.valor_vr);
                cmd.Parameters.Add("@salario_bruto", SqlDbType.Decimal).Value = Convert.ToDecimal(FuncEntrada.salario_bruto);
                cmd.Parameters.AddWithValue("@nivel_acesso", (int)FuncEntrada.nivel_acesso);
                cmd.Parameters.AddWithValue("@senha", FuncEntrada.senha);
                cmd.Parameters.AddWithValue("@ativo", (int)FuncEntrada.ativo);
                cmd.Parameters.AddWithValue("@cargo", FuncEntrada.cargo);
                cmd.Parameters.AddWithValue("@registro", FuncEntrada.registro);
                con.Open();
                cmd.ExecuteReader();

                return FuncEntrada;

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

           
        }

        public FuncionarioModel Login (FuncionarioModel funEntrada)
        {
            FuncionarioModel funcSaida = null;
            try
            {
                con = new SqlConnection(url);
                String sql = "select * from TB_funcionario where email= @email and senha = @senha and ativo = 1";
                cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@email", funEntrada.email);
                cmd.Parameters.AddWithValue("@senha", funEntrada.senha);
                
                con.Open();

                SqlDataReader listaFuncionarios = cmd.ExecuteReader();

                while (listaFuncionarios.Read())
                {
                    funcSaida = new FuncionarioModel(listaFuncionarios.GetInt32(0), listaFuncionarios.GetString(1),
                        listaFuncionarios.GetString(2), listaFuncionarios.GetString(3), listaFuncionarios.GetString(4),
                        listaFuncionarios.GetDateTime(5), listaFuncionarios.GetDateTime(6), listaFuncionarios.GetInt32(7),
                        (double)listaFuncionarios.GetDecimal(8), (double)listaFuncionarios.GetDecimal(9), (double)listaFuncionarios.GetDecimal(10),
                        (EnumAcessos)listaFuncionarios.GetInt32(11), listaFuncionarios.GetString(12), (EnumAtivo)listaFuncionarios.GetInt32(13),
                        listaFuncionarios.GetString(14));

                }



            }

            catch (SqlException ex)
            {
               MessageBox.Show(ex.Message);
            }

            finally
            {
                con.Close();
            }


            return funcSaida;
        }


        public FuncionarioModel CarregarDadosLogados(FuncionarioModel funEntrada)
        {
            FuncionarioModel funcSaida = null;
          
            try
            {
                con = new SqlConnection(url);
                String sql = "select * from TB_funcionario where email = @email and senha = @senha";

                cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@email", funEntrada.email);
                cmd.Parameters.AddWithValue("@senha", funEntrada.senha);

                con.Open();
                SqlDataReader listaFuncionarios = cmd.ExecuteReader();

                while (listaFuncionarios.Read())
                {
                    funcSaida = new FuncionarioModel(listaFuncionarios.GetInt32(0), listaFuncionarios.GetString(1),
                        listaFuncionarios.GetString(2), listaFuncionarios.GetString(3), listaFuncionarios.GetString(4),
                        listaFuncionarios.GetDateTime(5), listaFuncionarios.GetDateTime(6), listaFuncionarios.GetInt32(7),
                        (double)listaFuncionarios.GetDecimal(8), (double)listaFuncionarios.GetDecimal(9), (double)listaFuncionarios.GetDecimal(10),
                        (EnumAcessos)listaFuncionarios.GetInt32(11), listaFuncionarios.GetString(12), (EnumAtivo)listaFuncionarios.GetInt32(13),
                        listaFuncionarios.GetString(14));

                  
                }



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

            return funcSaida;
        }

    }
}
