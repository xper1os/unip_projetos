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
        private int _TipoQuarto;
       

        public frmCadastroReserva()
        {
            
            InitializeComponent();

        }


        clsModelHospede _ConsultaHopsede = new clsModelHospede();
        clsReservasDal _ConsultaHospedeDal = new clsReservasDal();
        DateTime thisDay = DateTime.Today;

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

           // txtCodigoHospede.Text = "";

         }

        private void txtCheckOut_TextChanged(object sender, EventArgs e)
        {         
            _CheckIn = DateTime.Parse(txtCheckIn.Text);
            _CheckOut = DateTime.Parse(txtCheckOut.Text);
            _Soma = _CheckOut - _CheckIn;
            _Diarias = int.Parse(_Soma.Days.ToString());
            _Diarias++;
            txtDiarias.Text = _Diarias.ToString();
            _TipoQuarto = 10;

           _ValorFinal = _Diarias * 150;
            

            txtValorTotal.Text = _ValorFinal.ToString("C2");
        }

        private void _btnCadastraReserva_Click(object sender, EventArgs e)
        {
            clsModelReservas _InsereReserva = new clsModelReservas();

            _InsereReserva.IdReserva = Int32.Parse(txtCodigoReserva.Text);
            _InsereReserva.IdHospede = Int32.Parse(txtCodigoHospede.Text);
            _InsereReserva.PrimeiroNomeHospede = txtPrimeiroNomeHospede.Text;
            _InsereReserva.UltimoNomeHospede = txtUltimoNomeHospede.Text;
            _InsereReserva.DataCheckIn = DateTime.Parse(txtCheckIn.Text);
            _InsereReserva.DataCheckOut = DateTime.Parse(txtCheckOut.Text);
            _InsereReserva.QtdHospede = Int32.Parse(txtQtdHospedes.Text);
            _InsereReserva.IdQuarto = Int32.Parse(cmbTipoQuarto.SelectedValue.ToString());
            _InsereReserva.IdPagamento = Int32.Parse(cmbTipoPagamento.SelectedValue.ToString());
            _InsereReserva.DataPagamento = DateTime.Parse(txtDataPagamento.Text = DateTime.Now.ToString("d-M-yyyy"));
            _InsereReserva.Valor = txtValorTotal.Text;
            _InsereReserva.DataCadastro = DateTime.Parse(txtDataCadastro.Text = DateTime.Now.ToString("d-M-yyyy"));


            clsReservasDal _SalvaReserva = new clsReservasDal();
            _SalvaReserva.CadastrarReserva(_InsereReserva);
            MessageBox.Show("Dados Cadastrados com Sucesso!");

            //informa o proximo código à ser gerado na sequencia
            clsHospedeDal _ExibeId = new clsHospedeDal();
            txtCodigoReserva.Text = _SalvaReserva.ObterProximoID().ToString();
            txtCodigoHospede.Text = _ExibeId.ObterProximoID().ToString();
        }

        private void carregaQuartos()
        {
            cmbTipoQuarto.DataSource = _ConsultaHospedeDal.ListarQuartos();
            cmbTipoQuarto.DisplayMember = "tipoquarto";
            cmbTipoQuarto.ValueMember = "idquarto";
        }

        private void carregaPagamentos()
        {
            cmbTipoPagamento.DataSource = _ConsultaHospedeDal.ListarTiposPagamentos();
            cmbTipoPagamento.DisplayMember = "tipopagamento";
            cmbTipoPagamento.ValueMember = "idpagamento";
        }


        private void frmCadastroReserva_Load(object sender, EventArgs e)
        {
            clsHospedeDal _ExibeId = new clsHospedeDal();
            carregaQuartos();
            carregaPagamentos();
            txtDataPagamento.Text = DateTime.Now.ToString("d-M-yyyy");
            txtDataCadastro.Text = DateTime.Now.ToString("d-M-yyyy");
            
            txtCodigoReserva.Text = _ExibeId.ObterProximoID().ToString();

        }

        private void _btnUpdateReserva_Click(object sender, EventArgs e)
        {
            //pega os dados do formulario
            clsModelReservas _AtualizaReservas = new clsModelReservas();
            clsModelHospede _AtualizaHospede = new clsModelHospede();

            _AtualizaReservas.IdHospede = Int32.Parse(txtCodigoHospede.Text);
            _AtualizaHospede.PrimeiroNomeHospede = txtPrimeiroNomeHospede.Text;
            _AtualizaHospede.UltimoNomeHospede = txtUltimoNomeHospede.Text;
            _AtualizaReservas.DataCheckIn = DateTime.Parse(txtCheckIn.Text);
            _AtualizaReservas.DataCheckOut = DateTime.Parse(txtCheckOut.Text);
            _AtualizaReservas.QtdHospede = Int32.Parse(txtQtdHospedes.Text);
            _AtualizaReservas.IdQuarto = Int32.Parse(cmbTipoQuarto.SelectedValue.ToString());
            _AtualizaReservas.DataPagamento = DateTime.Parse(txtDataPagamento.Text = DateTime.Now.ToString("d-M-yyyy"));
            _AtualizaReservas.Valor = txtValorTotal.Text;
            _AtualizaReservas.DataCadastro = DateTime.Parse(txtDataCadastro.Text = DateTime.Now.ToString("d-M-yyyy"));

            clsReservasDal _AtualizaDados = new clsReservasDal();
            clsHospedeDal _Atualiza = new clsHospedeDal();
            _AtualizaDados.AtualizaReserva(_AtualizaReservas);
            _Atualiza.AtualizaHospede(_AtualizaHospede);
            MessageBox.Show("Dados Atualizados com Sucesso!");

        
        }

        private void _btnExcluirReserva_Click(object sender, EventArgs e)
        {
            //pega os dados do formulario
            clsModelReservas _ExcluirReserva = new clsModelReservas();
            _ExcluirReserva.IdReserva = Int32.Parse(txtCodigoReserva.Text);

            clsReservasDal _ExcluirDados = new clsReservasDal();
            _ExcluirDados.ExcluirReserva(_ExcluirReserva.IdReserva);
            MessageBox.Show("Dados Deletados com Sucesso!");
        }

        private void _btnPesquisarReserva_Click(object sender, EventArgs e)
        {
            frmListaReserva vReservas = new frmListaReserva();
            vReservas.ShowDialog();

            //_Hospede vem da frmListaHospedes
            if (vReservas._Reservas.IdReserva >= 0)
            {
                txtCodigoReserva.Text = vReservas._Reservas.IdReserva.ToString();
                txtCodigoHospede.Text = vReservas._Reservas.IdHospede.ToString();
                txtCheckIn.Text = vReservas._Reservas.DataCheckIn.ToString();
                txtCheckOut.Text = vReservas._Reservas.DataCheckOut.ToString();
                txtQtdHospedes.Text = vReservas._Reservas.QtdHospede.ToString();
                cmbTipoQuarto.SelectedValue.ToString();
                cmbTipoPagamento.SelectedValue.ToString();
                txtDataPagamento.Text = vReservas._Reservas.DataPagamento.ToString();
                txtValorTotal.Text = vReservas._Reservas.Valor.ToString();
                txtDataCadastro.Text = vReservas._Reservas.DataCadastro.ToString();
               // txtPrimeiroNomeHospede.Text = vReservas._Reservas.PrimeiroNomeHospede.ToString();

            }
        }
    }
}
