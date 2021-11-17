using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using cl_Model;
using cl_Regras;
using cl_Dal;

namespace wf_hotel
{
    public partial class frmCadastroReserva : Form
    {
        private TimeSpan _Soma;
        private DateTime _CheckOut;
        private DateTime _CheckIn;
        private int _Diarias;
        private float _ValorFinal;
       

        public frmCadastroReserva()
        {
            InitializeComponent();
        }

        clsModelHospede _ConsultaHopsede = new clsModelHospede();
        clsReservasDal _ConsultaHospedeDal = new clsReservasDal();
 

        private void monthCalendarReservas_DateChanged(object sender, DateRangeEventArgs e)
        {
            txtCheckIn.Text = monthCalendarReservas.SelectionStart.ToShortDateString();
            txtCheckOut.Text = monthCalendarReservas.SelectionEnd.ToShortDateString();

        }

        private void btnBuscaHospede_Click(object sender, EventArgs e)
        {
            _ConsultaHopsede.IdHospede = Int32.Parse(txtCodigoHospede.Text);
            _ConsultaHopsede = _ConsultaHospedeDal.ConsultaNome(_ConsultaHopsede);

            txtPrimeiroNomeHospede.Text = _ConsultaHopsede.PrimeiroNomeHospede;
            txtUltimoNomeHospede.Text = _ConsultaHopsede.UltimoNomeHospede;

            txtCodigoHospede.Text = "";

         }

        private void txtCheckOut_TextChanged(object sender, EventArgs e)
        {         
            _CheckIn = DateTime.Parse(txtCheckIn.Text);
            _CheckOut = DateTime.Parse(txtCheckOut.Text);
            _Soma = _CheckOut - _CheckIn;
            _Diarias = int.Parse(_Soma.Days.ToString());
            _Diarias++;
            txtDiarias.Text = _Diarias.ToString();

            if (cmbTipoQuarto.Text == "A")
            {
                _ValorFinal = _Diarias * 150;
            }

            txtValorTotal.Text = _ValorFinal.ToString("C2");
        }

       
    }
}
