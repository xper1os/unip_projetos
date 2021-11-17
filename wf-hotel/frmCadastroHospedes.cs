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
    public partial class frmCadastroHospedes : Form
    {
        public frmCadastroHospedes()
        {
            InitializeComponent();
        }

        public void LimparCampos()
        {
            clsModelHospede _LimpaCampos = new clsModelHospede();

           // _LimpaCampos.IdHospede = Int32.Parse(txtCodigoHospede.Text = "");
            _LimpaCampos.PrimeiroNomeHospede = txtPrimeiroNomeHospede.Text = "";
            _LimpaCampos.UltimoNomeHospede = txtUltimoNomeHospede.Text = "";     

        }

        private void _btnSalvarHospede_Click(object sender, EventArgs e)
        {
            clsModelHospede _InsereHospede = new clsModelHospede();
            _InsereHospede.PrimeiroNomeHospede = txtPrimeiroNomeHospede.Text;
            _InsereHospede.UltimoNomeHospede = txtUltimoNomeHospede.Text;

            clsRegrasHospedes _SalvaHospede = new clsRegrasHospedes();
            _SalvaHospede.Salvar(_InsereHospede);
            MessageBox.Show("Dados Cadastrados com Sucesso!");

            //informa o proximo código à ser gerado na sequencia
            clsRegrasHospedes _ExibeId = new clsRegrasHospedes();
            txtCodigoHospede.Text = _ExibeId.ObterProximoID().ToString();

            LimparCampos();
        }

        private void frmCadastroHospedes_Load(object sender, EventArgs e)
        {
            //carrega o próximo código do hóspede ao abrir a tela 
            clsRegrasHospedes _ExibeId = new clsRegrasHospedes();
            txtCodigoHospede.Text = _ExibeId.ObterProximoID().ToString();

        }

        private void _btnUpdateHospede_Click(object sender, EventArgs e)
        {
            //pega os dados do formulario
            clsModelHospede _AtualizaHospede = new clsModelHospede();
            _AtualizaHospede.IdHospede = Int32.Parse(txtCodigoHospede.Text);
            _AtualizaHospede.PrimeiroNomeHospede = txtPrimeiroNomeHospede.Text;
            _AtualizaHospede.UltimoNomeHospede = txtUltimoNomeHospede.Text;

            clsRegrasHospedes _AtualizaDados = new clsRegrasHospedes();
            _AtualizaDados.Atualiza(_AtualizaHospede);
            MessageBox.Show("Dados Atualizados com Sucesso!");

            LimparCampos();

        }

        private void btnExcluirHospede_Click(object sender, EventArgs e)
        {
            //pega os dados do formulario
            clsModelHospede _ExcluirHospede = new clsModelHospede();
            _ExcluirHospede.IdHospede = Int32.Parse(txtCodigoHospede.Text);

            clsRegrasHospedes _ExcluirDados = new clsRegrasHospedes();
            _ExcluirDados.Excluir(_ExcluirHospede.IdHospede);
            MessageBox.Show("Dados Deletados com Sucesso!");

            LimparCampos();
        }

        private void btnBuscaHospede_Click(object sender, EventArgs e)
        {
            frmListaHospedes vHospedes = new frmListaHospedes();
            vHospedes.ShowDialog();

            //_Hospede vem da frmListaHospedes
            if (vHospedes._Hospede.IdHospede >= 0)
            {
                txtCodigoHospede.Text = vHospedes._Hospede.IdHospede.ToString();
                txtPrimeiroNomeHospede.Text = vHospedes._Hospede.PrimeiroNomeHospede.ToString();
                txtUltimoNomeHospede.Text = vHospedes._Hospede.UltimoNomeHospede.ToString();

            }
        }
    }
}
