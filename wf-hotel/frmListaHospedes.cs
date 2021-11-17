using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using cl_Regras;
using cl_Model;

namespace wf_hotel
{
    public partial class frmListaHospedes : Form
    {
        // variavel do tipo da classe Dal
        private clsRegrasHospedes _ListaHospedes;

        public clsModelHospede _Hospede = new clsModelHospede();

        public frmListaHospedes()
        {
            InitializeComponent();
        }


        public void CarregaHospedes()
        {
            _ListaHospedes = new clsRegrasHospedes();
            dgListaHospedes.AutoGenerateColumns = true;
            dgListaHospedes.DataSource = _ListaHospedes.ListarTodos();
        }

        private void frmListaHospedes_Load(object sender, EventArgs e)
        {
            _Hospede.IdHospede = -1;        
            CarregaHospedes();
            FormatarGrid();
        }

        private void SelecionaEstadoGridHospedes()
        {
            Int32 vi = 0;

            vi = dgListaHospedes.CurrentRow.Index;

            _Hospede.IdHospede = Int32.Parse(dgListaHospedes[0, vi].Value.ToString());
            _Hospede.PrimeiroNomeHospede = dgListaHospedes[1, vi].Value.ToString();
            _Hospede.UltimoNomeHospede = dgListaHospedes[2, vi].Value.ToString();
        }

        private void FormatarGrid()
        {
            dgListaHospedes.ReadOnly = true;
            dgListaHospedes.MultiSelect = false;
            dgListaHospedes.Columns[0].HeaderText = "Código";
            dgListaHospedes.Columns[1].HeaderText = "Primeiro Nome";
            dgListaHospedes.Columns[2].HeaderText = "Último Nome";

            dgListaHospedes.ScrollBars = ScrollBars.Vertical;
            dgListaHospedes.Columns[0].Width = 100;
            dgListaHospedes.Columns[1].Width = 100;
            dgListaHospedes.Columns[2].Width = 100;
        }

        private void btnFechaListaHospede_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _btnUpdateHospede_Click(object sender, EventArgs e)
        {
            CarregaHospedes();
        }

        private void btnSelecionaHospede_Click(object sender, EventArgs e)
        {
            SelecionaEstadoGridHospedes();
            this.Close();
        }
    }
}
