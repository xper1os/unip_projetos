using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

using cl_Dal;
using cl_Model;

namespace cl_Regras
{
    public class clsRegrasHospedes
    {
        private clsHospedeDal _HospedeDal = new clsHospedeDal();
        private clsReservasDal _ReservaDal = new clsReservasDal();

        public Int32 ObterProximoID()
        {
            return _HospedeDal.ObterProximoID();
        }

        public void Salvar(clsModelHospede _Hospede)
        {

         _HospedeDal.SalvarHospede(_Hospede);

        }

        public void Atualiza(clsModelHospede _Atualiza)
        {
            _HospedeDal.AtualizaHospede(_Atualiza);
        }

        public void Excluir(Int32 _Excluir)
        {
            _HospedeDal.ExcluirHospede(_Excluir);
        }

        public DataTable ListarTodos()
        {
            clsHospedeDal _LIstaHospedes = new clsHospedeDal();

            return _LIstaHospedes.ListarHospedes();
        }


    }
}
