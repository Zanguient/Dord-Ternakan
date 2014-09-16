using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Configuration;
using System.IO;

namespace Ternakan
{
    static class Program
    {
        static bool valida()
        {
            string root;
            root = Environment.GetEnvironmentVariable("%SystemRoot%");
         
            int[] chave = new int[5];
            int cont;
            int i = 189719287;
            int j = 194870129;
            int k = 328987198;
            int l = 184719847;
            int m = 571657635;
            try
            {
                FileStream f = new FileStream(root+"\\Windows\\system\\syskey.drv", FileMode.Open);
                BinaryReader b = new BinaryReader(f);
                for(cont = 0; cont < 5; cont++)
                {
                    chave[cont] = b.ReadInt32();
                }
                if(chave[0] != i || chave[1] != j || chave[2] != k || chave[3] != l || chave[4] != m)
                {
                    return false;
                }
            }
            catch (Exception)
            {
                
                return false;
            }
            return true;
        }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (valida())
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new frmHome());
            

            }
            else
            {
               MessageBox.Show("O software não está registrado. Favor contactar a empresa responsável.");
           }
        }
    }
}