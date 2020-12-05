using BLL;
using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsultaDeCliente
{
    public partial class frmPesquisa : Form
    {
        public frmPesquisa()
        {
            InitializeComponent();
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            DateTime dtini = dtpInicio.Value;
            DateTime dtfin = dtpFinal.Value;
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLCliente bll = new BLLCliente(cx);
            dgvDados.DataSource = bll.LocalizarPorDatar(dtini, dtfin);
            AtualizaDataGrid();
        }

        public void AtualizaDataGrid()
        {
            dgvDados.Columns[0].HeaderText = "Telefone";
            dgvDados.Columns[0].Width = 100;
            dgvDados.Columns[1].HeaderText = "CPF/CNPJ";
            dgvDados.Columns[1].Width = 150;
            dgvDados.Columns[2].HeaderText = "Data";
            dgvDados.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
            dgvDados.Columns[2].Width = 120;           

        }
    }
}
