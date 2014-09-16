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
    public partial class frmVisualizarHistorico : Form
    {
        private int id;
        byte[] imagem;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public frmVisualizarHistorico()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        private Image bytetoImage(byte[] bytes)
        {
            MemoryStream ms = new MemoryStream(bytes, 0, bytes.Length);


            ms.Write(bytes, 0, bytes.Length);

            return Image.FromStream(ms, true);



        }
        private void frmVisualizarHistorico_Shown(object sender, EventArgs e)
        {
            Text += " - " + frmHome.NomeFazendaSelecionada;
            imagem = null;
            string query = string.Format("SELECT * FROM HISTORICO WHERE (ID = {0})", id);
            FbConnection fbconn = new FbConnection(frmHome.strConn);
            FbCommand fbcmd = new FbCommand(query, fbconn);
            try
            {
                fbconn.Open();
                FbDataReader r;
                r = fbcmd.ExecuteReader();
                if (r.Read())
                {
                    try
                    {
                        lbData.Text = r["DATA"].ToString();
                    }
                    catch (InvalidOperationException exp)
                    {
                        MessageBox.Show("Erro: " + exp.Message);
                        lbData.Text = "";
                    }
                    try
                    {
                        lbObs.Text = r["OBS"].ToString();
                    }
                    catch (Exception)
                    {
                        lbObs.Text = "";
                    }
                    if (!((r["FOTO"]) is DBNull))
                    {
                        pctHist.Image = bytetoImage((byte[])(r["FOTO"]));
                        imagem = (byte[])r["FOTO"];
                    }
                }
            }
            catch (FbException fbex)
            {
                MessageBox.Show("Erro no banco de dados: " + fbex.Message);
            }
            finally
            {
                fbconn.Close();
            }
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
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return response;
        }
        private void pctHist_Click(object sender, EventArgs e)
        {
            bool resp;
            resp = writeByteArrayToFile(imagem, "arq.bmp");
            string dir = Environment.GetEnvironmentVariable("windir");
            if (resp)
            {
                Process.Start(dir + "\\system32\\mspaint.exe", "arq.bmp");
            }
        }
    }
}
