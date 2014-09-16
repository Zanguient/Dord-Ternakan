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

namespace Ternakan
{
    public partial class frmAdicionarHistorico : Form
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public frmAdicionarHistorico()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            dlgImagem.Filter = "Imagens (*.png; *.jpg; *.gif; *.jpeg; *.bmp)|*.png; *.jpg; *.gif; *.jpeg; *.bmp";//|gif(*.gif)|*.gif|jpeg(*.jpeg)|*.jpeg |Bitmap (*.bmp)|*.bmp";
            if (dlgImagem.ShowDialog(this) == DialogResult.OK)
            {
                pctHist.ImageLocation = dlgImagem.FileName;
            }
        }
        public byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }
        public byte[] imageToByteArray(string fileName)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);

            BinaryReader br = new BinaryReader(fs);

            return (br.ReadBytes(Convert.ToInt32(br.BaseStream.Length)));
        }
        private void btAdicionar_Click(object sender, EventArgs e)
        {
            if (txtData.Text == "  /  /" || txtObs.Text == "")
            {
                MessageBox.Show("Favor preencher todos os campos corretamente.");
            }
            else
            {
                string query = "INSERT INTO HISTORICO (FOTO,DATA,OBS,ID_GADO) VALUES (@FOTO,@DATA,@OBS,@ID_GADO)";
                FbConnection fbconn = new FbConnection(frmHome.strConn);
                try
                {
                    FbCommand fbcmd = new FbCommand();
                    fbconn.Open();
                    FbParameter[] fbprm = new FbParameter[4];
                    byte[] foto;
                    if (pctHist.Image == null)
                    {
                        foto = null;
                    }
                    else
                    {
                        foto = imageToByteArray(pctHist.ImageLocation);
                    }
                    fbprm[0] = new FbParameter("@FOTO", foto);
                    fbprm[1] = new FbParameter("@DATA", Convert.ToDateTime(txtData.Text));
                    fbprm[2] = new FbParameter("@OBS", txtObs.Text);
                    fbprm[3] = new FbParameter("ID_GADO", id);
                    foreach (FbParameter p in fbprm)
                    {
                        fbcmd.Parameters.Add(p);
                    }
                    fbcmd.CommandText = query;
                    fbcmd.CommandType = CommandType.Text;
                    fbcmd.Connection = fbconn;
                    fbcmd.ExecuteNonQuery();
                    MessageBox.Show("Evento adicionado com sucesso!");
                    fbconn.Close();
                    Close();
                }
                catch (FbException fbex)
                {
                    MessageBox.Show("Erro no banco de dados: "+fbex.Message);
                }
            }
        }

        private void frmAdicionarHistorico_Shown(object sender, EventArgs e)
        {
            Text += " - " + frmHome.NomeFazendaSelecionada;
        }
    }
}
