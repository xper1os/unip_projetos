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
            _Comando.CommandText = " insert into Reservas values(@idreserva,   @idhospede,  @datcheckin," +
                                                                "@datcheckout, @qtdhospede, @idquarto, @idpagamento, @datapagamento, @valor, @datacadastro); ";
            _Comando.Parameters.Add("@idreserva", SqlDbType.Int).Value = vCodigo;
            _Comando.Parameters.Add("@idhospede", SqlDbType.Int).Value = _Cadastra.IdHospede;
            _Comando.Parameters.Add("@datcheckin", SqlDbType.Date).Value = _Cadastra.DataCheckIn;
            _Comando.Parameters.Add("@datcheckout", SqlDbType.Date).Value = _Cadastra.DataCheckOut;
            _Comando.Parameters.Add("@qtdhospede", SqlDbType.VarChar).Value = _Cadastra.QtdHospede;
            _Comando.Parameters.Add("@idquarto", SqlDbType.Int).Value = _Cadastra.IdQuarto;
            _Comando.Parameters.Add("@idpagamento", SqlDbType.Int).Value = _Cadastra.IdPagamento;
            _Comando.Parameters.Add("@datapagamento", SqlDbType.Date).Value = _Cadastra.DataPagamento;
            _Comando.Parameters.Add("@valor", SqlDbType.VarChar).Value = _Cadastra.Valor;
            _Comando.Parameters.Add("@datacadastro", SqlDbType.Date).Value = _Cadastra.DataCadastro;

            _Comando.ExecuteNonQuery();

            Conexao.FecharConexao();

        }

        public DataTable ListarQuartos()
        {   //aqui teremos o select
            _Conexao = Conexao.ObterConexao();

            _Comando = new SqlCommand();
            _Comando.Connection = _Conexao;
            _Comando.CommandText = " select idquarto, tipoquarto from Quarto " +
                                   " order by idquarto ;";

            _Tabela = new DataTable();
            _Adaptador = new SqlDataAdapter(_Comando);
            _Adaptador.Fill(_Tabela);

            Conexao.FecharConexao();

            return _Tabela;
        }

        public DataTable ListarTiposPagamentos()
        {   //aqui teremos o select
            _Conexao = Conexao.ObterConexao();

            _Comando = new SqlCommand();
            _Comando.Connection = _Conexao;
            _Comando.CommandText = " select idpagamento, tipopagamento from Pagamento " +
                                   " order by idpagamento ;";

            _Tabela = new DataTable();
            _Adaptador = new SqlDataAdapter(_Comando);
            _Adaptador.Fill(_Tabela);

            Conexao.FecharConexao();

            return _Tabela;
        }

        public void AtualizaReserva(clsModelReservas _Atualiza)
        {
            _Conexao = Conexao.ObterConexao();
            _Comando = new SqlCommand();
            _Comando.Connection = _Conexao;
            _Comando.CommandText = " update Reservas set idhospede = @idhospede, datcheckin = @datacheckin, datcheckout = @datacheckout, qtdhospede = @qtdhospede, idquarto = @idquarto, idpagamento = @idpagamento, datpagamento = @datpagamento, valor = @valor, datacadastro = @datacadastro " +
                " where idreserva = @idreserva";
            _Comando.Parameters.Add("@idreserva", SqlDbType.Int).Value = _Atualiza.IdReserva;
            _Comando.Parameters.Add("@idhospede", SqlDbType.Int).Value = _Atualiza.IdHospede;
            _Comando.Parameters.Add("@datacheckin", SqlDbType.DateTime).Value = _Atualiza.DataCheckIn;
            _Comando.Parameters.Add("@datacheckout", SqlDbType.DateTime).Value = _Atualiza.DataCheckIn;
            _Comando.Parameters.Add("@qtdhospede", SqlDbType.Int).Value = _Atualiza.QtdHospede;
            _Comando.Parameters.Add("@idquarto", SqlDbType.Int).Value = _Atualiza.IdQuarto;
            _Comando.Parameters.Add("@idpagamento", SqlDbType.Int).Value = _Atualiza.IdPagamento;
            _Comando.Parameters.Add("@datpagamento", SqlDbType.DateTime).Value = _Atualiza.DataPagamento;
            _Comando.Parameters.Add("@valor", SqlDbType.VarChar).Value = _Atualiza.Valor;
            _Comando.Parameters.Add("@datacadastro", SqlDbType.DateTime).Value = _Atualiza.DataCadastro;


            _Comando.ExecuteNonQuery();

            Conexao.FecharConexao();
        }


        public void ExcluirReserva(Int32 _Excluir)
        {
            _Conexao = Conexao.ObterConexao();
            _Comando = new SqlCommand();
            _Comando.Connection = _Conexao;
            _Comando.CommandText = " delete Reservas " +
                                    "where idreserva = @codigo";
            _Comando.Parameters.Add("@codigo", SqlDbType.Int).Value = _Excluir;
            _Comando.ExecuteNonQuery();

            Conexao.FecharConexao();
        }

        public DataTable ListarReservas()
        {   //aqui teremos o select
            _Conexao = Conexao.ObterConexao();

            _Comando = new SqlCommand();
            _Comando.Connection = _Conexao;
            _Comando.CommandText = " select idreserva, idhospede, datcheckin,datcheckout,qtdhospede,idquarto,idpagamento,datpagamento,valor,datacadastro from Reservas " +
                                   "order by idreserva desc; ";

            _Tabela = new DataTable();
            _Adaptador = new SqlDataAdapter(_Comando);
            _Adaptador.Fill(_Tabela);

            Conexao.FecharConexao();

            return _Tabela;
        }

    }
}
