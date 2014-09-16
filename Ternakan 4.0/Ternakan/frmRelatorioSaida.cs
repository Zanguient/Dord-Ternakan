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
    public partial class frmRelatorioSaida : Form
    {
        public frmRelatorioSaida()
        {
            InitializeComponent();
        }

        private void btImprimirRelatorioSaida_Click(object sender, EventArgs e)
        {
            if (txtAteSaida.Text == "  /  /" || txtDeSaida.Text == "  /  /")
                MessageBox.Show("Favor preencher o intervalo corretamente");
            else
            {
                VerRelatorio frm = new VerRelatorio();
                frm.carregarRelatorioSaida(Convert.ToDateTime(txtDeSaida.Text), Convert.ToDateTime(txtAteSaida.Text));
                frm.ShowDialog();
                Close();
            }
        }

        private void btSairRelatorioSaida_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmRelatorioSaida_Shown(object sender, EventArgs e)
        {

            Text += " - " + frmHome.NomeFazendaSelecionada;
        }
    }
}
