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
    public class clsReservasDal
    {
        private SqlConnection _Conexao;
        private SqlCommand _Comando;
        private DataTable _Tabela;
        private SqlDataAdapter _Adaptador;
        private SqlDataReader _Dr;

        

        public clsModelHospede ConsultaNome(clsModelHospede _IdHospede)
        {
            _Conexao = Conexao.ObterConexao();
            _Comando = new SqlCommand();
            _Comando.Connection = _Conexao;
            _Comando.CommandText = " SELECT primeironome, ultimonome FROM Hospedes " +
                " WHERE idhospede =" + _IdHospede.IdHospede;
            _Dr = _Comando.ExecuteReader();

            clsModelHospede _ConsultaNome = new clsModelHospede();

            while (_Dr.Read())
            {
                _ConsultaNome.PrimeiroNomeHospede = _Dr["primeironome"].ToString();
                _ConsultaNome.UltimoNomeHospede = _Dr["ultimonome"].ToString();
            }
            _Dr.Close();

            return _ConsultaNome;
        }

        public Int32 ObterProximoID()
        {
            Int32 vCodigo = 0;
            _Conexao = Conexao.ObterConexao();
            _Comando = new SqlCommand();
            _Comando.Connection = _Conexao;
            _Comando.CommandText = " select isnull(max(idreserva), 0) + 1 as codigo " +
                                   " from Reservas ";
            vCodigo = Int32.Parse(_Comando.ExecuteScalar().ToString());

            Conexao.FecharConexao();
            return vCodigo;
        }

        public void CadastrarReserva(clsModelReservas _Cadastra)
        {
            
            Int32 vCodigo = ObterProximoID();
            _Conexao = Conexao.ObterConexao();
            _Comando = new SqlCommand();
            _Comando.Connection = _Conexao;
            _Comando.CommandText = " insert into Reservas values(@codigoReserva, @codigoHospede, @dataCheckIn," +
                "@dataCheckOut, @qtdHospede, @tipoQuarto, @tipoPagamento, @dataPagamento, @valor, @dataCadastro); ";
            _Comando.Parameters.Add("@codigoReserva", SqlDbType.Int).Value = vCodigo;
            _Comando.Parameters.Add("@codigoHospede", SqlDbType.Int).Value = _Cadastra.IdHospede;
            _Comando.Parameters.Add("@dataCheckIn", SqlDbType.Date).Value = _Cadastra.DataCheckIn;
            _Comando.Parameters.Add("@dataCheckOut", SqlDbType.Date).Value = _Cadastra.DataCheckOut;
            _Comando.Parameters.Add("@qtdHospede", SqlDbType.VarChar).Value = _Cadastra.QtdHospede;
          // _Comando.Parameters.Add("@tipoQuarto", SqlDbType.VarChar).Value = _Cadastra.TipoQuarto;
          //  _Comando.Parameters.Add("@tipoPagamento", SqlDbType.VarChar).Value = _Cadastra.TipoPagamento;
          //  _Comando.Parameters.Add("@dataPagamento", SqlDbType.VarChar).Value = _Cadastra.DataPagamento;
          //  _Comando.Parameters.Add("@valor", SqlDbType.VarChar).Value = _Cadastra.Valor;
          //  _Comando.Parameters.Add("@dataCadastro", SqlDbType.VarChar).Value = _Cadastra.DataCadastro;
            
            _Comando.ExecuteNonQuery();

            Conexao.FecharConexao();

        }

    }
}
