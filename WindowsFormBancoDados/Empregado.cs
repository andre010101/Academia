using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace WindowsFormBancoDados
{
    internal class Empregado
    {
        //public string nome;
        //public string funcao;
        //public string dataAdmissao;
        //public string salario;
        //public string comissao;

        public string nome;
        public int idGerente;
        public string funcao;
        public int idDepartamento;
        public DateTime dataAdmissao;
        public int salario;
        public int comissao;

        public Empregado(string nome, int idGerente, string funcao, int idDepartamento, DateTime dataAdmissao, int salario, int comissao)
        {
            this.nome = nome;
            this.idGerente = idGerente;
            this.funcao = funcao;
            this.idDepartamento = idDepartamento;
            this.dataAdmissao = dataAdmissao;
            this.salario = salario;
            this.comissao = comissao;
        }

        //public Empregado(string nome, string funcao, string dataAdmissao, string salario, string comissao)
        //{
        //    this.nome = nome;
        //    this.funcao = funcao;
        //    this.dataAdmissao = dataAdmissao;
        //    this.salario = salario;
        //    this.comissao = comissao;
        //}

        public bool gravarEmpregado()
        {
            Banco banco = new Banco();
            SqlConnection conn = banco.abrirConexao();
            SqlTransaction tran = conn.BeginTransaction();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.Transaction = tran;
            cmd.CommandType = CommandType.Text;
           
            cmd.CommandText = "INSERT INTO Empregado VALUES (@nome, @idGerente, @funcao,@idDepartamento, @dataAdmissao,@salario,@comissao);";
           
            cmd.Parameters.Add("@nome", SqlDbType.VarChar);
            cmd.Parameters.Add("@idGerente", SqlDbType.Int);
            cmd.Parameters.Add("@funcao", SqlDbType.VarChar); //SqlDbType.Int
            cmd.Parameters.Add("@idDepartamento", SqlDbType.Int);
            cmd.Parameters.Add("@dataAdmissao", SqlDbType.VarChar);
            cmd.Parameters.Add("@salario", SqlDbType.Int);
            cmd.Parameters.Add("@comissao", SqlDbType.Int);
       
            cmd.Parameters[0].Value = nome;
            cmd.Parameters[1].Value = idGerente;
            cmd.Parameters[2].Value = funcao;
            cmd.Parameters[3].Value = idDepartamento;
            cmd.Parameters[4].Value = dataAdmissao;
            cmd.Parameters[5].Value = salario;
            cmd.Parameters[6].Value = comissao;

            try
            {
                cmd.ExecuteNonQuery();
                tran.Commit();
                return true;
            }
            catch (Exception e)
            {
                tran.Rollback();
                return false;
            }
            finally
            {
                banco.fecharConexao();
            }
        }
    }
}
