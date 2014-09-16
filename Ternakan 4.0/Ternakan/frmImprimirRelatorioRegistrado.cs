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
    public partial class frmImprimirRelatorioRegistrado : Form
    {
        public frmImprimirRelatorioRegistrado()
        {
            InitializeComponent();
        }

        private void btConfirmarImpressão_Click(object sender, EventArgs e)
        {
            VerRelatorio frm = new VerRelatorio();
            frm.carregarRelatorioGadoRegistrado(!cxMorto.Checked, !cxTrocado.Checked);
            frm.ShowDialog();
        }

        private void frmImprimirRelatorioRegistrado_Shown(object sender, EventArgs e)
        {
            Text += " - " + frmHome.NomeFazendaSelecionada;
        }
    }
}
