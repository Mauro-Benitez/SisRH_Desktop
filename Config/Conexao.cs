using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SisRH_Desktop.Model
{
    internal class Conexao
    {
        SqlConnection sqlConn;

        public Conexao(string connstring) {
            sqlConn = new SqlConnection(connstring);
        }
        public Conexao() {
            sqlConn = new SqlConnection("Data Source=DESKTOP-SJ6LJ9P;Initial Catalog=sisrh;Integrated Security=true");
        }
        private bool TryConn()
        {
            try
            {
                sqlConn.Open();    

            }
            catch
            {
                return false;
            }

            return true;
        }
        public int NonQuery(string query)
        {
            SqlCommand sqlCommand = new SqlCommand{CommandText = query};

            bool tryConn = TryConn();

            if (tryConn)
            {
                return sqlCommand.ExecuteNonQuery();
                
            }
            else { return -1; }              
        }

        public SqlDataReader Query(string query)
        {
            SqlCommand sqlCommand = new SqlCommand { CommandText = query };

            bool tryConn = TryConn();

            if (tryConn)
            {
                return sqlCommand.ExecuteReader();
            }
            else { return null; }
        }

    }
}
