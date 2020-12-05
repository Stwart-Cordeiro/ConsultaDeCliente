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
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            Timedgv_Tick(sender, e);
            dgvDados.Columns[0].HeaderText = "Telefone";
            dgvDados.Columns[0].Width = 100;
            dgvDados.Columns[1].HeaderText = "CPF/CNPJ";
            dgvDados.Columns[1].Width = 150;
            dgvDados.Columns[2].HeaderText = "Fila - Suporte";
            dgvDados.Columns[2].Width = 100;            
            dgvDados.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;

        }

        private void CopyPasteButton_Click(object sender, EventArgs e)
        {
            if (dgvDados.GetCellCount(DataGridViewElementStates.Selected) > 0)
            {
               Clipboard.SetDataObject(dgvDados.GetClipboardContent());               
            }
        }

        private void Timedgv_Tick(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLCliente bll = new BLLCliente(cx);
            dgvDados.DataSource = bll.Localizar();
        }

        private void dgvDados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CopyPasteButton_Click(sender, e);
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            frmPesquisa pesquisa = new frmPesquisa();
            pesquisa.ShowDialog();
        }
    }
}
