using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cl_Model
{
    public class clsModelReservas : clsModelHospede
    {
        private int _IdReserva;
        private DateTime _DataCheckIn;
        private DateTime _DataCheckOut;
        private int _QtdHospede;
        private String _TipoQuarto;
        private String _TipoPagamento;
        private DateTime _DataPagamento;
        private Decimal _Valor;
        private DateTime _DataCadastro;

        public int IdReserva { get => _IdReserva; set => _IdReserva = value; }
        public DateTime DataCheckIn { get => _DataCheckIn; set => _DataCheckIn = value; }
        public DateTime DataCheckOut { get => _DataCheckOut; set => _DataCheckOut = value; }
        public int QtdHospede { get => _QtdHospede; set => _QtdHospede = value; }
        public string TipoQuarto { get => _TipoQuarto; set => _TipoQuarto = value; }
        public string TipoPagamento { get => _TipoPagamento; set => _TipoPagamento = value; }
        public DateTime DataPagamento { get => _DataPagamento; set => _DataPagamento = value; }
        public decimal Valor { get => _Valor; set => _Valor = value; }
        public DateTime DataCadastro { get => _DataCadastro; set => _DataCadastro = value; }
    }
}
