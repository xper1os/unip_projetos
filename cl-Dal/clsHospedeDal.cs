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
            _Comando.CommandText = " insert into Hospedes values(@codigo,@primeironome,@ultimonome,@cpf,@rg,@email,@logradouro,@numero,@complemento,@bairro,@cidade,@uf,@cep,@datcadastro) ";
            _Comando.Parameters.Add("@codigo", SqlDbType.Int).Value = vCodigo;
            _Comando.Parameters.Add("@primeironome", SqlDbType.VarChar).Value = _Insere.PrimeiroNomeHospede;
            _Comando.Parameters.Add("@ultimonome", SqlDbType.VarChar).Value = _Insere.UltimoNomeHospede;
            _Comando.Parameters.Add("@cpf", SqlDbType.Decimal).Value = _Insere.Cpf;
            _Comando.Parameters.Add("@rg", SqlDbType.VarChar).Value = _Insere.Rg;
            _Comando.Parameters.Add("@email", SqlDbType.VarChar).Value = _Insere.Email;
            _Comando.Parameters.Add("@logradouro", SqlDbType.VarChar).Value = _Insere.Logradouro;
            _Comando.Parameters.Add("@numero", SqlDbType.Int).Value = _Insere.Numero;
            _Comando.Parameters.Add("@complemento", SqlDbType.VarChar).Value = _Insere.Complemento;
            _Comando.Parameters.Add("@bairro", SqlDbType.VarChar).Value = _Insere.Bairro;
            _Comando.Parameters.Add("@cidade", SqlDbType.VarChar).Value = _Insere.Cidade;
            _Comando.Parameters.Add("@uf", SqlDbType.VarChar).Value = _Insere.Uf;
            _Comando.Parameters.Add("@cep", SqlDbType.VarChar).Value = _Insere.Cep;
            _Comando.Parameters.Add("@datcadastro", SqlDbType.VarChar).Value = _Insere.Datcadastro;

            _Comando.ExecuteNonQuery();

            Conexao.FecharConexao();

        }

        public void AtualizaHospede(clsModelHospede _Atualiza)
        {
            _Conexao = Conexao.ObterConexao();
            _Comando = new SqlCommand();
            _Comando.Connection = _Conexao;
            _Comando.CommandText = " update Hospedes set idhospede = @codigo, primeironome = @primeironome, ultimonome = @ultimonome, cpf = @cpf, rg = @rg, email = @email, logradouro = @logradouro, numero = @numero, complemento = @complemento,bairro = @bairro, cidade = @cidade,uf = @uf, cep = @cep, datcadastro = @datcadastro " +
                "where idhospede = @codigo";
            _Comando.Parameters.Add("@codigo", SqlDbType.Int).Value = _Atualiza.IdHospede;
            _Comando.Parameters.Add("@primeironome", SqlDbType.VarChar).Value = _Atualiza.PrimeiroNomeHospede;
            _Comando.Parameters.Add("@ultimonome", SqlDbType.VarChar).Value = _Atualiza.UltimoNomeHospede;
            _Comando.Parameters.Add("@cpf", SqlDbType.Decimal).Value = _Atualiza.Cpf;
            _Comando.Parameters.Add("@rg", SqlDbType.VarChar).Value = _Atualiza.Rg;
            _Comando.Parameters.Add("@email", SqlDbType.VarChar).Value = _Atualiza.Email;
            _Comando.Parameters.Add("@logradouro", SqlDbType.VarChar).Value = _Atualiza.Logradouro;
            _Comando.Parameters.Add("@numero", SqlDbType.Int).Value = _Atualiza.Numero;
            _Comando.Parameters.Add("@complemento", SqlDbType.VarChar).Value = _Atualiza.Complemento;
            _Comando.Parameters.Add("@bairro", SqlDbType.VarChar).Value = _Atualiza.Bairro;
            _Comando.Parameters.Add("@cidade", SqlDbType.VarChar).Value = _Atualiza.Cidade;
            _Comando.Parameters.Add("@uf", SqlDbType.VarChar).Value = _Atualiza.Uf;
            _Comando.Parameters.Add("@cep", SqlDbType.VarChar).Value = _Atualiza.Cep;
            _Comando.Parameters.Add("@datcadastro", SqlDbType.VarChar).Value = _Atualiza.Datcadastro;
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
            _Comando.CommandText = " select idhospede,primeironome,ultimonome,cpf,rg,email,logradouro,numero,complemento,bairro,cidade,uf,cep,datcadastro  from Hospedes " +
                                   "order by idhospede desc; ";

            _Tabela = new DataTable();
            _Adaptador = new SqlDataAdapter(_Comando);
            _Adaptador.Fill(_Tabela);

            Conexao.FecharConexao();

            return _Tabela;
        }

    }
}
