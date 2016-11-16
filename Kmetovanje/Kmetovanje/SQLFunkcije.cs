using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Data;

namespace Kmetovanje
{
    // tukej bodo vse SQL funkcije ki jih bova delala! :)
    class SQLFunkcije
    {
        public string Baza_povezava;

        private void Metoda_branje()
        {
            try
            {
                TextReader tr = new StreamReader(Application.StartupPath + @"\Nastavitve.ini", Encoding.UTF8);
                string prebral = "";
                while ((prebral = tr.ReadLine()) != null)
                {
                    if (prebral.StartsWith("povezava="))
                    {
                        int i = prebral.Length;
                        Baza_povezava = prebral.Substring(9, (i - 9));
                        Baza_povezava = Baza_povezava.Replace("\\\\", "\\");
                    }
                }
                string prebrano = tr.ReadToEnd();
                tr.Close();
            }
            catch (Exception ex) { MessageBox.Show("Prišlo je do napake pri povezavi z bazo\n" + ex.Message, "NAPAKA", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private DataTable SQLSelect(string stavek)
        {
            DataTable tabela = new DataTable();

            if (Baza_povezava != null)
            {
                SqlConnection povezava = new SqlConnection(Baza_povezava);
                povezava.Open();
                SqlDataAdapter da = new SqlDataAdapter(stavek, povezava);
                da.Fill(tabela);
            }
            return tabela;
        }
    }
}
