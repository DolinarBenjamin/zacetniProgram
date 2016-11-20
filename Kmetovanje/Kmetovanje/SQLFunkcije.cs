using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        private void PodatkovniPrikaz()
        {
            DataTable OpombeZiv = new DataTable();
            SqlConnection povezava = new SqlConnection(Baza_povezava);
            povezava.Open();
            SqlDataAdapter OpomZiv = new SqlDataAdapter("SELECT [ImeZiv] AS [Ime živali], [Datum_Opombe] AS [Datum], ImeOpombe.Ime_Opombe AS [Opomba], [Opis_Opombe] AS [Opis] FROM Opombe, Zivali, ImeOpombe WHERE Zivali.IdZivS=Opombe.IdZivS AND  izloc='0' AND ImeOpombe.Id_ImeOpombe=Opombe.Ime_Opombe", povezava);
            OpomZiv.Fill(OpombeZiv);
            povezava.Close();
        }
    }
}
