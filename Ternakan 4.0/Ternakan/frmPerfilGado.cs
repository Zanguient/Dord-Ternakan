using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;
using System.IO;
using System.Diagnostics;

namespace Ternakan
{
    public partial class frmPerfilGado : Form
    {
        int ID;
        byte[] imagem1;
        byte[] imagem2;
        public frmPerfilGado()
        {
            InitializeComponent();
        }


        private bool removerGado()
        {
            bool retorno = true;
            ID = Convert.ToInt32(lblID.Text);
            string squery = string.Format("DELETE FROM GADO WHERE ID = {0}",
                    ID);
            FbConnection fbConn = new FbConnection(frmHome.strConn);

            FbCommand fbCmd = new FbCommand(squery, fbConn);

            try
            {
                fbConn.Open();
                fbCmd.ExecuteNonQuery();
            }
            catch (FbException fbex)
            {
                MessageBox.Show("Erro ao acessar o Banco de Dados " + fbex.Message, "Erro");
                retorno = false;
            }
            finally
            {
                fbConn.Close();
            }
            return retorno;
        }

        private Image bytetoImage(byte[] bytes)
        {
            MemoryStream ms = new MemoryStream(bytes, 0, bytes.Length);

            ms.Write(bytes, 0, bytes.Length);

            return Image.FromStream(ms, true);


        }

        public void carregarDg(int id)
        {
            imagem1 = null;
            imagem2 = null;
            FbConnection fbConn = new FbConnection(frmHome.strConn);
            string query = string.Format("SELECT GADO.ID,GADO.NUMERO,GADO.NOME,GADO.DATA_NASCIMENTO_GADO,GADO.SEXO,GADO.PAI,GADO.MAE,GADO.RACA, GADO.LACTACAO, GADO.NUMERO_FILHO, GADO.NUMERO_DONOS, GADO.NUMERO_REGISTRO, GADO.FOTO1, GADO.FOTO2, GADO.LACTACAO_MEDIA, GADO.PELAGEM, GADO.TIPO_CADASTRO, GADO.PRECO, GADO.DATA_ENTRADA, GADO.CIO, PIQUET.NOME, PIQUET.NUMERO, GADO.OBS FROM GADO, PIQUET WHERE ((GADO.ID = {0}) AND (PIQUET.ID = GADO.ID_PIQUET))", id);
            FbCommand fbCmd = new FbCommand(query, fbConn);
            try
            {
                fbConn.Open();

                FbDataReader r = fbCmd.ExecuteReader();
                if (r.Read())
                {
                    lbNomeGado.Text = r[2].ToString();
                    if (r[3].ToString() != "")
                    lbDataNascimentoGado.Text = Convert.ToDateTime(r[3]).ToString("dd/MM/yyyy");

                    lbSexoGado.Text = r[4].ToString();

                    lbNomePaiGado.Text = r[5].ToString();
                    lbNomeMaeGado.Text = r[6].ToString();
                    lbRacaGado.Text = r[7].ToString();
                    lbNumeroFilhosGado.Text = r[9].ToString();
                    lbQuantidadeDonos.Text = r[10].ToString();
                    lbLactacaoGado.Text = r[14].ToString();
                    lbPelagemGado.Text = r[15].ToString();
                    groupboxdados.Text = r[11].ToString();
                    lbNumeroGado.Text = r[1].ToString();
                    if (!((r[12]) is DBNull))
                    {
                        pctGado1.Image = bytetoImage((byte[])(r[12]));
                        imagem1 = (byte[])r[12];
                    }
                    if (!((r[13]) is DBNull))
                    {
                        pctGado2.Image = bytetoImage((byte[])r[13]);
                        imagem2 = (byte[])r[13];
                    }
                    
                    lblID.Text = r[0].ToString();
                    lblNomePiquet.Text = r[20].ToString();
                    lblNumeroPiquet.Text = r[21].ToString();
                    lbObs.Text = r[22].ToString();
                }

            }
            catch (FbException fbex)
            {
                MessageBox.Show("Erro ao acessar o Banco de Dados:\n" + fbex.Message, "Erro");

            }
            finally
            {
                fbConn.Close();
            }       
            
            
        }

        private void frmPerfilGado_Shown(object sender, EventArgs e)
        {
            Text += " - " + frmHome.NomeFazendaSelecionada;
            btRemover.Visible = frmHome.admin;
        }

        private void btRemover_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você tem certeza que deseja remover este gado?", "Confirmação", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    if (removerGado())
                    {
                        MessageBox.Show("Gado removido com sucesso");
                        Close();
                    }
                }
                catch (Exception)
                {
                    
                    throw;
                }
            }
        }

        private void btTabelaVacinacao_Click(object sender, EventArgs e)
        {
            ID = Convert.ToInt32(lblID.Text);
            frmTabelaVacina frm = new frmTabelaVacina();
           /* dsTernakan.GADORow gado = (from g in dsTernakan.GADO
                                              where g.ID == Convert.ToInt32(lblID.Text)
                                              select g).First();
            frm.carregarDataGrid(dsTernakan,gado);*/
            FbConnection fbconn = new FbConnection(frmHome.strConn);
            string query = string.Format("SELECT * FROM VACINACA WHERE (ID_GADO = {0})", ID);
            fbconn.Open();
            FbCommand fbcmd = new FbCommand(query, fbconn);
            FbDataReader r = fbcmd.ExecuteReader();
            if (r.Read())
            {
                frm.carregar(ID);
            }
            else
            {
                MessageBox.Show("Não existem vacinas cadastradas para esse gado");
            }
        }

        private void btImprimirPerfilGado_Click(object sender, EventArgs e)
        {
            VerRelatorio frm = new VerRelatorio();
            frm.carregarRelatorioPerfilGado(Convert.ToInt32(lblID.Text));
            frm.ShowDialog();
        }

        private void btAlterarPerfil_Click(object sender, EventArgs e)
        {
            frmGadoCadastro frm = new frmGadoCadastro();
            frm.ehUpdate(Convert.ToInt32(lblID.Text));
            frm.ShowDialog();
            Close();
        }

        public bool writeByteArrayToFile(byte[] buff, string fileName)
        {
            bool response = false;

            try
            {
                FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.ReadWrite);
                BinaryWriter bw = new BinaryWriter(fs);
                bw.Write(buff);
                bw.Close(); //Thanks Karlo for pointing out!
                response = true;
            }
            catch
            {
                response = false;
            }

            return response;
        }

        private void pctGado1_Click(object sender, EventArgs e)
        {
            bool resp;
            resp = writeByteArrayToFile(imagem1, "arq.jpeg");
            string dir = Environment.GetEnvironmentVariable("windir");
            if (resp)
            {
                Process.Start(dir + "\\system32\\mspaint.exe","arq.jpeg");
            }
        }

        private void txtAddHist_Click(object sender, EventArgs e)
        {
            frmAdicionarHistorico hist = new frmAdicionarHistorico();
            hist.Id = Convert.ToInt32(lblID.Text);
            hist.ShowDialog();
        }

        private void lbNumeroRegistroGado_Enter(object sender, EventArgs e)
        {

        }

        private void btVerHistorico_Click(object sender, EventArgs e)
        {
            frmVerHistorico frm = new frmVerHistorico();
            frm.Id = Convert.ToInt32(lblID.Text);
            frm.ShowDialog();
        }

        private void pctGado2_Click(object sender, EventArgs e)
        {
            bool resp;
            resp = writeByteArrayToFile(imagem2, "arq.jpg");
            string dir = Environment.GetEnvironmentVariable("windir");
            if (resp)
            {
                Process.Start(dir + "\\system32\\mspaint.exe", "arq.jpg");
            }
        }
    }
}
