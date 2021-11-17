using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//**************************************
//adiciona biblioteca de acesso a dados.
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace cl_Dal
{
    public class Conexao
    {
        private static SqlConnection _Conexao;
        private static SqlCommand _Comando;
        private static SqlDataAdapter _Adaptador;
        private static DataTable _Tabela;
        private static String _StringConexao = "Data Source=DESKTOP-8SVNND4; " +
                                               "Initial Catalog=base_hotel_konoha; " +
                                               "Integrated Security=True;";

        //abre uma conexao com o banco de dados.
        public static SqlConnection ObterConexao()
        {
            try
            {
                _Conexao = new SqlConnection(_StringConexao);
                _Conexao.Open();
                return _Conexao;

            }
            catch (Exception)
            {
                return null;
                throw;
            }

        }

        public static void FecharConexao()
        {
            if (_Conexao.State == ConnectionState.Open)
            {
                _Conexao.Close();
            }
        }

    }
}
