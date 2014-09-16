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
    public partial class frmRelatorioEntrada : Form
    {
        public frmRelatorioEntrada()
        {
            InitializeComponent();
        }

        private void btImprimirRelatorioSaida_Click(object sender, EventArgs e)
        {
            if (txtAteEntrada.Text == "  /  /" || txtDeEntrada.Text == "  /  /")
                MessageBox.Show("Favor preencher o intervalo corretamente");
            else
            {
                VerRelatorio frm = new VerRelatorio();
                frm.carregarRelatorioEntrada(Convert.ToDateTime(txtDeEntrada.Text), Convert.ToDateTime(txtAteEntrada.Text));
                frm.ShowDialog();
                Close();
            }
        }

        private void btSairRelatorioEntrada_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmRelatorioEntrada_Shown(object sender, EventArgs e)
        {

            Text += " - " + frmHome.NomeFazendaSelecionada;
        }
    }
}
