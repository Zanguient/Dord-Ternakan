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
    public partial class frmBusca : Form
    {
        public frmBusca()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmBusca_Load(object sender, EventArgs e)
        {

        }

        private void btVoltarBusca_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            string squery = "SELECT * FROM GADO";
            if (rbDtNascimento.Checked)
            {
                if (txtBusca.Text != "")
                {
                    try
                    {
                        DateTime dtI, dtF;
                        dtI = Convert.ToDateTime(txtInicio.Text);
                        dtF = Convert.ToDateTime(txtFim.Text);
                        squery = string.Format("SELECT ID, NUMERO, NOME, PELAGEM, RACA, DATA_NASCIMENTO_GADO, TIPO_CADASTRO FROM GADO WHERE ((DATA_NASCIMENTO_GADO >= '{0}') AND (DATA_NASCIMENTO_GADO <= '{1}')  AND (ID_FAZENDA = {2}) AND ((TIPO_CADASTRO != 'VENDIDO') AND (TIPO_CADASTRO != 'TROCADO')))",
                            dtI.ToString("MM/dd/yyyy"), dtF.ToString("MM/dd/yyyy"), frmHome.IDFazendaSelecionada);

                        frmResultadoBusca frm = new frmResultadoBusca();
                        frm.busca(squery);
                        frm.ShowDialog();
                    }
                    catch (FormatException)
                    {

                        MessageBox.Show("Data digita é inválida");
                    }
                }
                else
                    MessageBox.Show("Valor de pesquisa");
         
            }
            else if (rbBuscaTodos.Checked)
            {
                squery = string.Format("SELECT ID, NUMERO, NOME, PELAGEM, RACA, TIPO_CADASTRO, DATA_NASCIMENTO_GADO FROM GADO WHERE ((TIPO_CADASTRO != 'VENDIDO') AND (TIPO_CADASTRO != 'TROCADO') AND (ID_FAZENDA = {0}))", frmHome.IDFazendaSelecionada);
                    
                    frmResultadoBusca frm = new frmResultadoBusca();
                    frm.busca(squery);
                    frm.ShowDialog();

            }
            else
            {
                if (txtBusca.Text == "" && rbBuscaMacho.Checked == false && rbBuscaFemea.Checked == false && rbBuscaTodos.Checked == false)
                {
                    MessageBox.Show("Favor inserir um valor a ser procurado");
                }
                else //digitar códigos de busca
                {
                    if (rbBuscaMacho.Checked == true)
                    {
                        squery = string.Format("SELECT ID, NUMERO, NOME, PELAGEM, RACA, TIPO_CADASTRO FROM GADO WHERE ((SEXO = 'M') AND (ID_FAZENDA = {0}) AND ((TIPO_CADASTRO != 'VENDIDO') AND (TIPO_CADASTRO != 'TROCADO')))", frmHome.IDFazendaSelecionada);

                    }
                    else if (rbBuscaFemea.Checked == true)
                    {
                        squery = string.Format("SELECT ID, NUMERO, NOME, PELAGEM, RACA, TIPO_CADASTRO FROM GADO WHERE ((SEXO = 'F') AND (ID_FAZENDA = {0}) AND ((TIPO_CADASTRO != 'VENDIDO') AND (TIPO_CADASTRO != 'TROCADO')))", frmHome.IDFazendaSelecionada);


                    }
                    else if (rbFiltroNome.Checked)
                    {
                        squery = string.Format("SELECT ID, NUMERO, NOME, PELAGEM, RACA, TIPO_CADASTRO FROM GADO WHERE ((UPPER(NOME) LIKE '{0}%') AND (ID_FAZENDA = {1}) AND ((TIPO_CADASTRO != 'VENDIDO') AND (TIPO_CADASTRO != 'TROCADO')))", txtBusca.Text.ToUpper(), frmHome.IDFazendaSelecionada);


                    }
                    else if (rbFiltroNumero.Checked)
                    {
                        squery = string.Format("SELECT ID, NUMERO, NOME, PELAGEM, RACA, TIPO_CADASTRO FROM GADO WHERE ((UPPER(NUMERO) = '{0}') AND (ID_FAZENDA = {1}) AND ((TIPO_CADASTRO != 'VENDIDO') AND (TIPO_CADASTRO != 'TROCADO')))", txtBusca.Text.ToUpper(), frmHome.IDFazendaSelecionada);

                    }
                    else if (rbFiltroRaca.Checked)
                    {
                        squery = string.Format("SELECT ID, NUMERO, NOME, PELAGEM, RACA, TIPO_CADASTRO FROM GADO WHERE ((UPPER(RACA) LIKE '{0}%') AND (ID_FAZENDA = {1}) AND ((TIPO_CADASTRO != 'VENDIDO') AND (TIPO_CADASTRO != 'TROCADO')))", txtBusca.Text.ToUpper(), frmHome.IDFazendaSelecionada);

                    }
                    else if (rbNomePiquet.Checked)//depois eu vejo
                    {
                        squery = string.Format("SELECT GADO.ID, GADO.NUMERO, GADO.NOME, GADO.PELAGEM, GADO.RACA, GADO.TIPO_CADASTRO, PIQUET.NUMERO AS \"NUMERO DO PIQUET\", PIQUET.NOME AS \"NOME DO PIQUET\" FROM GADO, PIQUET WHERE ((gado.id_piquet = piquet.id) AND (UPPER(piquet.nome) like '{0}%') AND (gado.ID_FAZENDA = {1}))", txtBusca.Text.ToUpper(), frmHome.IDFazendaSelecionada);

                    }
                    else if (rbNumeroPiquet.Checked)//depois eu vejo
                    {
                        squery = string.Format("SELECT GADO.ID, GADO.NUMERO, GADO.NOME, GADO.PELAGEM, GADO.RACA, GADO.TIPO_CADASTRO, PIQUET.NUMERO AS \"NUMERO DO PIQUET\", PIQUET.NOME AS \"NOME DO PIQUET\" FROM GADO, PIQUET WHERE ((gado.id_piquet = piquet.id) AND (UPPER(piquet.numero) = '{0}') AND (gado.ID_FAZENDA = {1}))", txtBusca.Text.ToUpper(), frmHome.IDFazendaSelecionada);

                    }
                   
                    frmResultadoBusca frm = new frmResultadoBusca();
                    frm.busca(squery);
                    frm.ShowDialog();

                }

            }
           
        }

        private void frmBusca_SizeChanged(object sender, EventArgs e)
        {

        }

        private void frmBusca_Shown(object sender, EventArgs e)
        {

            Text += " - " + frmHome.NomeFazendaSelecionada;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frmBusca_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void rbDtNascimento_CheckedChanged(object sender, EventArgs e)
        {
            gbIntervalo.Visible = rbDtNascimento.Checked;
        }

        private void txtBusca_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
                btBuscar_Click(sender, e);
        }
    }
}
