using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cl_Model
{
    public class clsModelHospede
    {
        private int _idHospede;
        private String _PrimeiroNomeHospede;
        private String _UltimoNomeHospede;
        private Decimal _Cpf;
        private String _Rg;
        private String _Email;
        private String _Logradouro;
        private int _Numero;
        private String _Complemento;
        private String _Bairro;
        private String _Cidade;
        private String _Uf;
        private String _Cep;
        private DateTime _Datcadastro;

        public int IdHospede { get => _idHospede; set => _idHospede = value; }
        public string PrimeiroNomeHospede { get => _PrimeiroNomeHospede; set => _PrimeiroNomeHospede = value; }
        public string UltimoNomeHospede { get => _UltimoNomeHospede; set => _UltimoNomeHospede = value; }
        public decimal Cpf { get => _Cpf; set => _Cpf = value; }
        public string Rg { get => _Rg; set => _Rg = value; }
        public string Email { get => _Email; set => _Email = value; }
        public string Logradouro { get => _Logradouro; set => _Logradouro = value; }
        public int Numero { get => _Numero; set => _Numero = value; }
        public string Complemento { get => _Complemento; set => _Complemento = value; }
        public string Bairro { get => _Bairro; set => _Bairro = value; }
        public string Cidade { get => _Cidade; set => _Cidade = value; }
        public string Uf { get => _Uf; set => _Uf = value; }
        public string Cep { get => _Cep; set => _Cep = value; }
        public DateTime Datcadastro { get => _Datcadastro; set => _Datcadastro = value; }
    }
}
