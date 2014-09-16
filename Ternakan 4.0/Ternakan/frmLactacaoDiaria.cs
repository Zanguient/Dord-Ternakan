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
    public partial class frmLactacaoDiaria : Form
    {
        bool mudouDeTab = true;
        bool alterar = false;
        public frmLactacaoDiaria()
        {
            InitializeComponent();
        }
        private void limpar()
        {
            txtData.Clear();
            txtData2.Clear();
            txtProducao.Clear();
            txtProducao2.Clear();

            cbTirada.Text = "";
            cbTirada2.Text = "";
            cbVaca.Text = "";
            cbVaca2.Text = "";
        }

        private void frmLactacaoDiaria_Shown(object sender, EventArgs e)
        {
            Text += " - " + frmHome.NomeFazendaSelecionada;
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            if (mudouDeTab == false)
            {
                frmLactacaoDiaria.ActiveForm.MinimumSize = frmLactacaoDiaria.ActiveForm.MaximumSize = frmLactacaoDiaria.ActiveForm.Size = new Size(488, 287);
                tbLactacao.Size = new Size(451, 226);
                gbIncluirLactacao.Size = new Size(426, 176);
                mudouDeTab = true;
            }
            else
            {
                frmLactacaoDiaria.ActiveForm.Size = new Size(787, 557);
                frmLactacaoDiaria.ActiveForm.MinimumSize = frmLactacaoDiaria.ActiveForm.MaximumSize = new Size(787,557);

                tbLactacao.Size = new Size(751, 494);
                dgLactacao.Size = new Size(730, 376);

                txtData2.Visible = false;
                txtProducao2.Visible = false;

                lblData2.Visible = false;
                lblProducao2.Visible = false;
                lblTirada2.Visible = false;
                lblVaca2.Visible = false;

                cbTirada2.Visible = false;
                cbVaca2.Visible = false;

                limpar();

                this.mudouDeTab = false;
                this.alterar = false;

                btCancelar.Location = new Point(384, 388);
                lblDeletar.Text = "Deletar";
                lblDeletar.Location = new Point(380,441);
                
                btAlterar.Location = new Point(301,388);
                lblAlterar.Location = new Point(299,441);

            }
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            if (alterar == false)
            {
                alterar = true;

                txtData2.Visible = true;
                txtProducao2.Visible = true;

                lblData2.Visible = true;
                lblProducao2.Visible = true;
                lblTirada2.Visible = true;
                lblVaca2.Visible = true;

                cbTirada2.Visible = true;
                cbVaca2.Visible = true;

                this.alterar = true;

                btCancelar.Location = new Point(518, 388);
                lblDeletar.Text = "Cancelar";
                lblDeletar.Location = new Point(508, 441);

                btAlterar.Location = new Point(429, 388);
                lblAlterar.Location = new Point(427, 441);

            }
            else
            {
                if (txtData2.Text == "" || txtProducao2.Text == "" || cbTirada2.Text == "" || cbVaca2.Text == "")
                {
                    MessageBox.Show("Favor preencher todos os campos");
                }
                else
                {
                    //commit

                    alterar = false;

                    txtData2.Visible = false;
                    txtProducao2.Visible = false;

                    lblData2.Visible = false;
                    lblProducao2.Visible = false;
                    lblTirada2.Visible = false;
                    lblVaca2.Visible = false;

                    cbTirada2.Visible = false;
                    cbVaca2.Visible = false;

                    limpar();

                    this.alterar = false;

                    btCancelar.Location = new Point(384, 388);
                    lblDeletar.Text = "Deletar";
                    lblDeletar.Location = new Point(380, 441);

                    btAlterar.Location = new Point(301, 388);
                    lblAlterar.Location = new Point(299, 441);
                }
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            if (alterar == true)
            {
                txtData2.Visible = false;
                txtProducao2.Visible = false;

                lblData2.Visible = false;
                lblProducao2.Visible = false;
                lblTirada2.Visible = false;
                lblVaca2.Visible = false;

                cbTirada2.Visible = false;
                cbVaca2.Visible = false;

                limpar();

                this.alterar = false;

                btCancelar.Location = new Point(384, 388);
                lblDeletar.Text = "Deletar";
                lblDeletar.Location = new Point(380, 441);

                btAlterar.Location = new Point(301, 388);
                lblAlterar.Location = new Point(299, 441);

            }
            else
            {
                //deleta a linha selecionada
            }
        }

        private void btGravar_Click(object sender, EventArgs e)
        {
            if (txtData.Text != "" || txtProducao.Text != "" || cbTirada.Text != "" || cbVaca.Text != "")
            {
                //commit
                limpar();
            }
            else
            {
                MessageBox.Show("Favor preencher todos os campos");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            limpar();
        }


    }
}
