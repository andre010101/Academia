using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace aula.Ado.net
{
    internal class Pessoa
    {
        public int id;
        public string nome;
        public float peso;

        public bool gravar()
        {
            Banco db = new Banco();
            SqlConnection cn = db.abrirConexao();

            SqlTransaction transacao = cn.BeginTransaction();

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = cn;
            cmd.Transaction = transacao;
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "insert into pessoas values (@nome , @peso);";
            cmd.Parameters.Add("nome", SqlDbType.VarChar);
            cmd.Parameters.Add("peso", SqlDbType.Float);
            cmd.Parameters[0].Value = nome;
            cmd.Parameters[1].Value = peso;

            try
            {
                cmd.ExecuteNonQuery();
                transacao.Commit();
                return true;
            }
            catch (Exception ex)
            {
                transacao.Rollback();
                return false;
            }
            finally
            {
                db.fecharConexao();
            }
        }


    }
}
