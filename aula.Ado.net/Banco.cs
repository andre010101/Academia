using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula.Ado.net
{
    internal class Banco
    {
        private string conec = "Data Source=localhost;Initial Catalog=aula;" + "User ID=usuarioAtos; password=admin123; language=Portuguese";

        private SqlConnection cn;

        private void conecao()
        {
            cn = new SqlConnection(conec);
        }

        public SqlConnection abrirConexao()
        {
            try
            {
                conecao();
                cn.Open();

                return cn;  
            }
            catch(Exception ex)
            {
                return null;
            }

        }

        public void fecharConexao()
        {
            try
            {
                cn.Close();
            }
            catch(Exception ex)
            {
                throw;
            }
        }

        public DataTable executaConsulta(string sql)
        {
            try
            {
               abrirConexao();

                SqlCommand sqlCommand = new SqlCommand(sql, cn);
                sqlCommand.ExecuteNonQuery();

                SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                return dt;
                
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                fecharConexao();
            }
        }
    }
}
