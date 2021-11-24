using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using cl_Dal;
using cl_Model;

namespace wf_hotel
{
    public partial class frmListaReserva : Form
    {
        public frmListaReserva()
        {
            InitializeComponent();
        }

        private clsReservasDal _ListaReservas;

        public clsModelReservas _Reservas = new clsModelReservas();

        private void frmListaReserva_Load(object sender, EventArgs e)
        {
            _Reservas.IdReserva = -1;
            CarregaReservas();
        }

        public void CarregaReservas()
        {
            _ListaReservas = new clsReservasDal();
            dgListaReservas.AutoGenerateColumns = true;
            dgListaReservas.DataSource = _ListaReservas.ListarReservas();
        }


        private void SelecionaEstadoGridReservas()
        {
            Int32 vi = 0;


            vi = dgListaReservas.CurrentRow.Index;

            _Reservas.IdReserva = Int32.Parse(dgListaReservas[0, vi].Value.ToString());
            _Reservas.IdHospede = Int32.Parse(dgListaReservas[1, vi].Value.ToString());
            _Reservas.DataCheckIn = DateTime.Parse(dgListaReservas[2, vi].Value.ToString());
            _Reservas.DataCheckOut = DateTime.Parse(dgListaReservas[3, vi].Value.ToString());
            _Reservas.QtdHospede = Int32.Parse(dgListaReservas[4, vi].Value.ToString());
            _Reservas.IdQuarto = Int32.Parse(dgListaReservas[5, vi].Value.ToString());
            _Reservas.IdPagamento = Int32.Parse(dgListaReservas[6, vi].Value.ToString());
            _Reservas.DataPagamento = DateTime.Parse(dgListaReservas[7, vi].Value.ToString());
            _Reservas.Valor = dgListaReservas[8, vi].Value.ToString();
            _Reservas.DataCadastro = DateTime.Parse(dgListaReservas[9, vi].Value.ToString());
            
          //  _Reservas.UltimoNomeHospede = dgListaReservas[11, vi].Value.ToString();
        }

        private void btnSelecionaHospede_Click(object sender, EventArgs e)
        {

            SelecionaEstadoGridReservas();
            this.Close();
        }

        private void btnFechaListaHospede_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
