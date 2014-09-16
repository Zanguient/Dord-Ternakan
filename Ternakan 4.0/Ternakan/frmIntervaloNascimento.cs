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
    public partial class frmIntervaloNascimento : Form
    {
        public frmIntervaloNascimento()
        {
            InitializeComponent();
        }

        private void btConfirmarImpressaoLactacao_Click(object sender, EventArgs e)
        {
            DateTime dtDe = DateTime.Today, dtAte = DateTime.Today;
            try 
	{	        
		dtDe = Convert.ToDateTime(txtInicioLactacao.Text);
                dtAte = Convert.ToDateTime(txtFimLactacao.Text);
	}
	catch (Exception)
	{
		
		MessageBox.Show("Digite as datas corretamente");
	}
            VerRelatorio frm = new VerRelatorio();
            frm.carregarRelatorioNatalidade(dtDe, dtAte);
            frm.ShowDialog();
        }

        private void btSairRelatorioLactacao_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmIntervaloNascimento_Shown(object sender, EventArgs e)
        {

            Text += " - " + frmHome.NomeFazendaSelecionada;
        }
    }
}
