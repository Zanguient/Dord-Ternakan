using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ternakan
{
    public partial class frmMenuLactacao : Form
    {
        public frmMenuLactacao()
        {
            InitializeComponent();
        }

        private void btLactacaoDiaria_MouseHover(object sender, EventArgs e)
        {
            txtInformacao.Text = "Incluir e alterar produção diária de leite.";
        }

        private void btVacaLactacao_MouseHover(object sender, EventArgs e)
        {
            txtInformacao.Text = "Incluir e retirar as vacas em lactação.";
        }

        private void frmMenuLactacao_Shown(object sender, EventArgs e)
        {
            Text += " - " + frmHome.NomeFazendaSelecionada;
        }

        private void btVacaLactacao_Click(object sender, EventArgs e)
        {
            frmVacasLactacao frm = new frmVacasLactacao();
            frm.ShowDialog();
        }

        private void btLactacaoDiaria_Click(object sender, EventArgs e)
        {
            frmLactacaoDiaria frm = new frmLactacaoDiaria();
            frm.ShowDialog();
        }
    }
}
