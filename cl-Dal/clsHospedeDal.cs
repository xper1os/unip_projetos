using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using cl_Model;

//**************************************
//adiciona biblioteca de acesso a dados.
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;


namespace cl_Dal
{
    public class clsHospedeDal
    {
        private SqlConnection _Conexao;
        private SqlCommand _Comando;
        private DataTable _Tabela;
        private SqlDataAdapter _Adaptador;

        public Int32 ObterProximoID()
        {
            Int32 vCodigo = 0;
            _Conexao = Conexao.ObterConexao();
            _Comando = new SqlCommand();
            _Comando.Connection = _Conexao;
            _Comando.CommandText = " select isnull(max(idhospede), 0) + 1 as codigo " +
                                   " from Hospedes ";
            vCodigo = Int32.Parse(_Comando.ExecuteScalar().ToString());

            Conexao.FecharConexao();
            return vCodigo;
        }

        public void SalvarHospede(clsModelHospede _Insere)
        {   
            Int32 vCodigo = ObterProximoID();
            _Conexao = Conexao.ObterConexao();
            _Comando = new SqlCommand();
            _Comando.Connection = _Conexao;
            _Comando.CommandText = " insert into Hospedes values(@codigo, @primeironome, @ultimonome); ";
            _Comando.Parameters.Add("@codigo", SqlDbType.Int).Value = vCodigo;
            _Comando.Parameters.Add("@primeironome", SqlDbType.VarChar).Value = _Insere.PrimeiroNomeHospede;
            _Comando.Parameters.Add("@ultimonome", SqlDbType.VarChar).Value = _Insere.UltimoNomeHospede;
            _Comando.ExecuteNonQuery();

            Conexao.FecharConexao();

        }

        public void AtualizaHospede(clsModelHospede _Atualiza)
        {
            _Conexao = Conexao.ObterConexao();
            _Comando = new SqlCommand();
            _Comando.Connection = _Conexao;
            _Comando.CommandText = " update Hospedes set primeironome = @primeironome, ultimonome = @ultimonome " +
                "where idhospede = @codigo";
            _Comando.Parameters.Add("@codigo", SqlDbType.Int).Value = _Atualiza.IdHospede;
            _Comando.Parameters.Add("@primeironome", SqlDbType.VarChar).Value = _Atualiza.PrimeiroNomeHospede;
            _Comando.Parameters.Add("@ultimonome", SqlDbType.VarChar).Value = _Atualiza.UltimoNomeHospede;
            _Comando.ExecuteNonQuery();

            Conexao.FecharConexao();
        }

        public void ExcluirHospede(Int32 _Excluir)
        {
            _Conexao = Conexao.ObterConexao();
            _Comando = new SqlCommand();
            _Comando.Connection = _Conexao;
            _Comando.CommandText = " delete Hospedes " +
                                    "where idhospede = @codigo";
            _Comando.Parameters.Add("@codigo", SqlDbType.Int).Value = _Excluir;
            _Comando.ExecuteNonQuery();

            Conexao.FecharConexao();
        }

        public DataTable ListarHospedes()
        {   //aqui teremos o select
            _Conexao = Conexao.ObterConexao();

            _Comando = new SqlCommand();
            _Comando.Connection = _Conexao;
            _Comando.CommandText = " select idhospede, primeironome, ultimonome from Hospedes " +
                                   "order by idhospede desc; ";

            _Tabela = new DataTable();
            _Adaptador = new SqlDataAdapter(_Comando);
            _Adaptador.Fill(_Tabela);

            Conexao.FecharConexao();

            return _Tabela;
        }

    }
}
