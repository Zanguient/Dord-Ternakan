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
    public partial class frmIntervaloDe_Lactacao : Form
    {
        public frmIntervaloDe_Lactacao()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btSairRelatorioLactacao_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btConfirmarImpressaoLactacao_Click(object sender, EventArgs e)
        {
            VerRelatorio frm = new VerRelatorio();
            frm.carregarRelatorioLactacaoDia(Convert.ToDateTime(txtInicioLactacao.Text),
                Convert.ToDateTime(txtFimLactacao.Text));
            frm.ShowDialog();
        }

        private void frmIntervaloDe_Lactacao_Load(object sender, EventArgs e)
        {

        }

        private void frmIntervaloDe_Lactacao_Shown(object sender, EventArgs e)
        {
            Text += " - " + frmHome.NomeFazendaSelecionada;
        }
    }
}
