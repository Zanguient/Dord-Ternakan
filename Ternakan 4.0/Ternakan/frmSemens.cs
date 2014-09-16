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
    public partial class frmSemens : Form
    {
        bool alterar = new bool();
        bool mudouDeTab = new bool();
        public frmSemens()
        {
            InitializeComponent();
            btAlterar.Location = new Point(225, 303);
            lblAlterar.Location = new Point(223, 356);
            gbAlterar.Visible = false;
            alterar = false;
            this.mudouDeTab = true;
            rbColocar.Checked = true;
        }

        private void limpar()
        {
            txtCaneca.Clear();
            txtNome.Clear();
            txtQuantidade.Clear();
            txtRaca.Clear();
            txtRegistro.Clear();
            txtQuantidadeAlterar.Clear();
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            if (alterar == false)
            {
                btAlterar.Location = new Point(150, 309);
                lblAlterar.Location = new Point(148, 362);
                gbAlterar.Location = new Point(206, 303);
                gbAlterar.Visible = true;
                alterar = true;
            }
            else
            {
                if (txtQuantidadeAlterar.Text != "")
                {
                    //commit
                    txtQuantidadeAlterar.Clear();
                    gbAlterar.Visible = false;
                    btAlterar.Location = new Point(225, 303);
                    lblAlterar.Location = new Point(223, 356);
                    alterar = false;
                }
                else
                    MessageBox.Show("Favor preencher a quantidade a ser alterada.");

            }
        }

        private void btCadastrarSemen_Click(object sender, EventArgs e)
        {
            if (txtCaneca.Text == "" || txtNome.Text == "" || txtQuantidade.Text == "" || txtRaca.Text == "")
                MessageBox.Show("Favor preencher os campos obrigatórios");
            else
            {
                //commit
                limpar();
            }
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            limpar();
        }

        private void frmSemens_Shown(object sender, EventArgs e)
        {
            Text += " - " + frmHome.NomeFazendaSelecionada;
        }

        private void tcBancoSemem_Selected(object sender, TabControlEventArgs e)
        {
            if (mudouDeTab == false)
            {
                limpar();

                frmSemens.ActiveForm.MaximumSize = frmSemens.ActiveForm.MinimumSize = new Size(570,370);
                frmSemens.ActiveForm.Height = 370;
                frmSemens.ActiveForm.Width = 570;

                tcBancoSemem.Height = 299;
                tcBancoSemem.Width = 524;

                mudouDeTab = true;
            }
            else
            {
                limpar();

                frmSemens.ActiveForm.MaximumSize = frmSemens.ActiveForm.MinimumSize = new Size(570,495);
                frmSemens.ActiveForm.Height = 495;
                frmSemens.ActiveForm.Width = 570;

                tcBancoSemem.Height = 415;
                tcBancoSemem.Width = 516;

                dgvSemens.Height = 290;
                dgvSemens.Width = 500;

                btAlterar.Location = new Point(150, 309);
                lblAlterar.Location = new Point(148, 362);
                gbAlterar.Location = new Point(206, 303);
                gbAlterar.Visible = false;
                alterar = false;
                btAlterar.Location = new Point(225, 303);
                lblAlterar.Location = new Point(223, 356);
                mudouDeTab = false;
            }
        }
    }
}
