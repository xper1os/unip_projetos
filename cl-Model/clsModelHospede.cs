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

        public int IdHospede { get => _idHospede; set => _idHospede = value; }
        public string PrimeiroNomeHospede { get => _PrimeiroNomeHospede; set => _PrimeiroNomeHospede = value; }
        public string UltimoNomeHospede { get => _UltimoNomeHospede; set => _UltimoNomeHospede = value; }
    }
}
