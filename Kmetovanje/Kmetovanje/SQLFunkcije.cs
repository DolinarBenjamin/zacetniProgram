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
using Excel;
namespace Kmetovanje
{
    // tukej bodo vse SQL funkcije ki jih bova delala! :)
    class SQLFunkcije
    {
        public string Baza_povezava;
        
        public void Metoda_branje()
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
        public string Podatek(string newName)
        {
            string newProdID = "0";
            string sql ="SELECT ImeZiv FROM Zivali WHERE (IdZivOrig ='" + Hlev.origst + "')";
            using (SqlConnection conn = new SqlConnection(Baza_povezava))
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add("@Name", SqlDbType.VarChar);
                cmd.Parameters["@name"].Value = newName;
                try
                {
                    conn.Open();
                    newProdID = cmd.ExecuteScalar().ToString();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return newProdID;
        }
        public DataTable SQLSelect(string stavek)
        {
            DataTable tabela = new DataTable();

            if (Baza_povezava != null)
            {
                SqlConnection povezava = new SqlConnection(Baza_povezava);
                povezava.Open();
                SqlDataAdapter da = new SqlDataAdapter(stavek, povezava);
                da.Fill(tabela);
                povezava.Close();
            }
            return tabela;
        }
        public Dictionary<string,string> NapolniComboBox()
        {
            try
            {
                DataTable biki = new DataTable();
                SqlConnection povezava = new SqlConnection(Baza_povezava);
                povezava.Open();
                SqlDataAdapter dabiki = new SqlDataAdapter("SELECT Id_Bik, Ime FROM Biki", povezava);
                dabiki.Fill(biki);
                Dictionary<string, string> ImeBika = new Dictionary<string, string>();
                foreach (DataRow dr in biki.Rows)
                {
                    ImeBika.Add(dr["Id_Bik"].ToString(), dr["Ime"].ToString());
                }
                povezava.Close();
                return ImeBika;                
            }
            catch { throw; }
        }
        #region UvozPodatkov
        public void UvoziKontrole(string datkont)
        {
            
            MessageBox.Show(datkont);
            FileStream stream = File.Open(datkont, FileMode.Open, FileAccess.Read);
            //BinaryReader br =new BinaryReader( File.Open(datoteka, FileMode.Open, FileAccess.Read));
            //1. Reading from a binary Excel file ('97-2003 format; *.xls)
            //IExcelDataReader excelReader = ExcelReaderFactory.CreateBinaryReader(stream);
            //...
            //2. Reading from a OpenXml Excel file (2007 format; *.xlsx)
            IExcelDataReader excelReader = ExcelReaderFactory.CreateOpenXmlReader(stream);
            //...
            //3. DataSet - The result of each spreadsheet will be created in the result.Tables
            // DataSet result = excelReader.AsDataSet();
            //...
            //4. DataSet - Create column names from first row
            excelReader.IsFirstRowAsColumnNames = true;
            DataSet result = excelReader.AsDataSet();
            DataTable tabela = new DataTable();
            tabela = result.Tables[0];
            SqlConnection povezava = new SqlConnection(Baza_povezava);
            povezava.Open();
            foreach (DataRow dr in tabela.Rows)
            {
                if (dr["datkon"].ToString() != null)
                {
                    DateTime datumkont;
                    DateTime.TryParse(dr["datkon"].ToString(),out datumkont);
                    
                    int id;
                    int.TryParse(dr["Id_Kont"].ToString(), out id);
                    int sekvenca;
                    int.TryParse(dr["IdZiv_S"].ToString(), out sekvenca);
                    SqlCommand cm = new SqlCommand("IF EXISTS(SELECT NULL FROM Kontrola WHERE Id_Kont = " + id + " AND datkon='" + datumkont.ToString("yyyy-MM-dd") + "' AND IdZiv_S=" + sekvenca + ")"
                    + "UPDATE Kontrola SET IdZiv_S=@idZiv_S,ImeZiv=@ImeZiv,roj=@roj,idlak=@idlak,dattel=@dattel,datkon=@datkon,y161=@y161,y162a=@y162a, y163=@y163,y164=@y164,y165=@y165,y166=@y166,y167=@y167,y168=@y168 WHERE Id_Kont = " + id 
                    + " ELSE "
                    + "INSERT INTO Kontrola(idZiv_S,ImeZiv,roj,idlak,dattel,datkon,y161,y162a,y163,y164,y165,y166,y167,y168) VALUES(@idZiv_S,@ImeZiv,@roj,@idlak,@dattel,@datkon,@y161,@y162a,@y163,@y164,@y165,@y166,@y167,@y168)", povezava);

                    int kravaSek;
                    if (int.TryParse(dr["idZiv_S"].ToString(), out kravaSek))
                        cm.Parameters.AddWithValue("@idZiv_S", kravaSek);
                    else
                        cm.Parameters.AddWithValue("@idZiv_S", DBNull.Value);
                    cm.Parameters.AddWithValue("@ImeZiv", dr["ImeZiv"].ToString());
                    try
                    {
                        cm.Parameters.AddWithValue("@roj", DateTime.Parse(dr["roj"].ToString()).ToString("yyyy-MM-dd"));
                    }
                    catch { cm.Parameters.AddWithValue("@roj", DBNull.Value); }
                    int laktacija;
                    if (int.TryParse(dr["idlak"].ToString(), out laktacija))
                        cm.Parameters.AddWithValue("@idlak", laktacija);
                    else
                        cm.Parameters.AddWithValue("@idlak", DBNull.Value);
                    try
                    {
                        cm.Parameters.AddWithValue("@dattel", DateTime.Parse(dr["dattel"].ToString()).ToString("yyyy-MM-dd"));
                    }
                    catch { cm.Parameters.AddWithValue("@dattel", DBNull.Value); }
                    try
                    {
                        cm.Parameters.AddWithValue("@datkon", DateTime.Parse(dr["datkon"].ToString()).ToString("yyyy-MM-dd"));
                    }
                    catch { cm.Parameters.AddWithValue("@datkon", DBNull.Value); }
                    decimal y161;
                    if (decimal.TryParse(dr["y161"].ToString(), out y161))
                        cm.Parameters.AddWithValue("@y161", y161);
                    else
                        cm.Parameters.AddWithValue("@y161", DBNull.Value);
                    decimal y162a;
                    if (decimal.TryParse(dr["y162a"].ToString(), out y162a))
                        cm.Parameters.AddWithValue("@y162a", y162a);
                    else
                        cm.Parameters.AddWithValue("@y162a", DBNull.Value);
                    decimal y163;
                    if (decimal.TryParse(dr["y163"].ToString(), out y163))
                        cm.Parameters.AddWithValue("@y163", y163);
                    else
                        cm.Parameters.AddWithValue("@y163", DBNull.Value);
                    decimal y164;
                    if (decimal.TryParse(dr["y164"].ToString(), out y164))
                        cm.Parameters.AddWithValue("@y164", y164);
                    else
                        cm.Parameters.AddWithValue("@y164", DBNull.Value);
                    decimal y165;
                    if (decimal.TryParse(dr["y165"].ToString(), out y165))
                        cm.Parameters.AddWithValue("@y165", y165);
                    else
                        cm.Parameters.AddWithValue("@y165", DBNull.Value);
                    decimal y166;
                    if (decimal.TryParse(dr["y166"].ToString(), out y166))
                        cm.Parameters.AddWithValue("@y166", y166);
                    else
                        cm.Parameters.AddWithValue("@y166", DBNull.Value);
                    decimal y167;
                    if (decimal.TryParse(dr["y167"].ToString(), out y167))
                        cm.Parameters.AddWithValue("@y167", y167);
                    else
                        cm.Parameters.AddWithValue("@y167", DBNull.Value);
                    decimal y168;
                    if (decimal.TryParse(dr["y168"].ToString(), out y168))
                        cm.Parameters.AddWithValue("@y168", y168);
                    else
                        cm.Parameters.AddWithValue("@y168", DBNull.Value);
                    cm.ExecuteNonQuery();
                }
            }    
            povezava.Close();
            excelReader.Close();
        }
        public void excelvSQL(string datkont)
        {
            FileStream stream = File.Open(datkont, FileMode.Open, FileAccess.Read);
            //BinaryReader br =new BinaryReader( File.Open(datoteka, FileMode.Open, FileAccess.Read));
            //1. Reading from a binary Excel file ('97-2003 format; *.xls)
            //IExcelDataReader excelReader = ExcelReaderFactory.CreateBinaryReader(stream);
            //...
            //2. Reading from a OpenXml Excel file (2007 format; *.xlsx)
            IExcelDataReader excelReader = ExcelReaderFactory.CreateOpenXmlReader(stream);
            //...
            //3. DataSet - The result of each spreadsheet will be created in the result.Tables
            // DataSet result = excelReader.AsDataSet();
            //...
            //4. DataSet - Create column names from first row
            excelReader.IsFirstRowAsColumnNames = true;
            DataSet result = excelReader.AsDataSet();
            DataTable tabela = new DataTable();
            tabela = result.Tables[0];
            SqlConnection povezava = new SqlConnection(Baza_povezava);
            povezava.Open();
            foreach (DataRow dr in tabela.Rows)
            {
                int id;
                int.TryParse(dr["idZiv_S"].ToString(), out id);
                SqlCommand cm = new SqlCommand("IF EXISTS(SELECT NULL FROM Kontrola WHERE idZiv_S = " + id + ")"
                    + "UPDATE Kontrola SET ImeZiv=@ImeZiv,roj=@roj,idlak=@idlak,dattel=@dattel,datkon=@datkon,y161=@y161,y162a=@y162a,y163=@y163,y164=@y164,y165=@y165,y166=@y166,y167=@y167,y168=@y168 WHERE idZiv_S = " + id
                    + " ELSE "
                    + "INSERT INTO Kontrola(idZiv_S,ImeZiv,roj,idlak,dattel,datkon,y161,y162a,y163,y164,y165,y166,y167,y168) VALUES(@idZiv_S,@ImeZiv,@roj,@idlak,@dattel,@datkon,@y161,@y162a,@y163,@y164,@y165,@y166,@y167,@y168)", povezava);
                int kravaSek;
                if (int.TryParse(dr["idZiv_S"].ToString(), out kravaSek))
                    cm.Parameters.AddWithValue("@idZiv_S", kravaSek);
                else
                    cm.Parameters.AddWithValue("@idZiv_S", DBNull.Value);
                cm.Parameters.AddWithValue("@ImeZiv", dr["ImeZiv"].ToString());
                try
                {
                    cm.Parameters.AddWithValue("@roj", DateTime.Parse(dr["roj"].ToString()));
                }
                catch { cm.Parameters.AddWithValue("@roj", DBNull.Value); }
                int laktacija;
                if (int.TryParse(dr["idlak"].ToString(), out laktacija))
                    cm.Parameters.AddWithValue("@idlak", laktacija);
                else
                    cm.Parameters.AddWithValue("@idlak", DBNull.Value);
                try
                {
                    cm.Parameters.AddWithValue("@dattel", DateTime.Parse(dr["dattel"].ToString()));
                }
                catch { cm.Parameters.AddWithValue("@dattel", DBNull.Value); }
                try
                {
                    cm.Parameters.AddWithValue("@datkon", DateTime.Parse(dr["datkon"].ToString()));
                }
                catch { cm.Parameters.AddWithValue("@datkon", DBNull.Value); }
                decimal y161;
                if (decimal.TryParse(dr["y161"].ToString(), out y161))
                    cm.Parameters.AddWithValue("@y161", y161);
                else
                    cm.Parameters.AddWithValue("@y161", DBNull.Value);
                decimal y162a;
                if (decimal.TryParse(dr["y162a"].ToString(), out y162a))
                    cm.Parameters.AddWithValue("@y162a", y162a);
                else
                    cm.Parameters.AddWithValue("@y162a", DBNull.Value);
                decimal y163;
                if (decimal.TryParse(dr["y163"].ToString(), out y163))
                    cm.Parameters.AddWithValue("@y163", y163);
                else
                    cm.Parameters.AddWithValue("@y163", DBNull.Value);
                decimal y164;
                if (decimal.TryParse(dr["y164"].ToString(), out y164))
                    cm.Parameters.AddWithValue("@y164", y164);
                else
                    cm.Parameters.AddWithValue("@y164", DBNull.Value);
                decimal y165;
                if (decimal.TryParse(dr["y165"].ToString(), out y165))
                    cm.Parameters.AddWithValue("@y165", y165);
                else
                    cm.Parameters.AddWithValue("@y165", DBNull.Value);
                decimal y166;
                if (decimal.TryParse(dr["y166"].ToString(), out y166))
                    cm.Parameters.AddWithValue("@y166", y166);
                else
                    cm.Parameters.AddWithValue("@y166", DBNull.Value);
                decimal y167;
                if (decimal.TryParse(dr["y167"].ToString(), out y167))
                    cm.Parameters.AddWithValue("@y167", y167);
                else
                    cm.Parameters.AddWithValue("@y167", DBNull.Value);
                decimal y168;
                if (decimal.TryParse(dr["y168"].ToString(), out y168))
                    cm.Parameters.AddWithValue("@y168", y168);
                else
                    cm.Parameters.AddWithValue("@y168", DBNull.Value);
                cm.ExecuteNonQuery();
            }
            povezava.Close();
            //5. Data Reader methods
            //while (excelReader.Read())
            //{
            //    excelReader.GetInt32(0);
            //}

            //6. Free resources (IExcelDataReader is IDisposable)
            excelReader.Close();
        }

        public void UvoziZivali(string datotekaKrave)
        {

            FileStream stream = File.Open(datotekaKrave, FileMode.Open, FileAccess.Read);
            //BinaryReader br =new BinaryReader( File.Open(datoteka, FileMode.Open, FileAccess.Read));
            //1. Reading from a binary Excel file ('97-2003 format; *.xls)
            //IExcelDataReader excelReader = ExcelReaderFactory.CreateBinaryReader(stream);
            //...
            //2. Reading from a OpenXml Excel file (2007 format; *.xlsx)
            IExcelDataReader excelReader = ExcelReaderFactory.CreateOpenXmlReader(stream);
            //...
            //3. DataSet - The result of each spreadsheet will be created in the result.Tables
            // DataSet result = excelReader.AsDataSet();
            //...
            //4. DataSet - Create column names from first row
            excelReader.IsFirstRowAsColumnNames = true;
            DataSet result = excelReader.AsDataSet();
            DataTable tabela = new DataTable();
            tabela = result.Tables[0];
            SqlConnection povezava = new SqlConnection(Baza_povezava);
            povezava.Open();
            foreach (DataRow dr in tabela.Rows)
            {
                int id;
                int.TryParse(dr["IdZivS"].ToString(), out id);
                SqlCommand cm = new SqlCommand("IF EXISTS(SELECT NULL FROM Zivali WHERE IdZivS = " + id + ")"
                    + "UPDATE Zivali SET IdZivOrig=@IdZivOrig,ImeZiv=@ImeZiv,DatRoj=@DatRoj,Spol=@Spol,IdMatS=@IdMatS,IdOceS=@IdOceS,datizl=@datizl,izloc=@izloc,IdOce=@IdOce,IdMat=@IdMat,"
                    + "IdPas=@IdPas,VzrokIzl=@VzrokIzl WHERE IdZivS = " + id
                    + " ELSE "
                    + "INSERT INTO Zivali(IdZivS,IdZivOrig,ImeZiv,DatRoj,Spol,IdMatS,IdOceS,datizl,izloc,IdOce,IdMat,IdPas,VzrokIzl )"
                    + " VALUES( @IdZivS,@IdZivOrig,@ImeZiv,@DatRoj,@Spol,@IdMatS,@IdOceS,@datizl,@izloc,@IdOce,@IdMat,@IdPas,@VzrokIzl)", povezava);
                int zivsek;
                if (int.TryParse(dr["IdZivS"].ToString(), out zivsek))
                    cm.Parameters.AddWithValue("@IdZivS", zivsek);
                else
                    cm.Parameters.AddWithValue("IdZivS", DBNull.Value);
                int usesna;
                if (int.TryParse(dr["IdZivOrig"].ToString(), out usesna))
                    cm.Parameters.AddWithValue("@IdZivOrig", usesna);
                else
                    cm.Parameters.AddWithValue("@IdZivOrig", DBNull.Value);
                cm.Parameters.AddWithValue("@ImeZiv", dr["ImeZiv"].ToString());
                cm.Parameters.AddWithValue("@DatRoj", DateTime.Parse(dr["DatRoj"].ToString()));
                int spol;
                if (int.TryParse(dr["Spol"].ToString(), out spol))
                    cm.Parameters.AddWithValue("@Spol", spol);
                else
                    cm.Parameters.AddWithValue("@Spol", DBNull.Value);
                int matSek;
                if (int.TryParse(dr["IdMatS"].ToString(), out matSek))
                    cm.Parameters.AddWithValue("@IdMatS", matSek);
                else
                    cm.Parameters.AddWithValue("@IdMatS", DBNull.Value);
                int oceSek;
                if (int.TryParse(dr["IdOceS"].ToString(), out oceSek))
                    cm.Parameters.AddWithValue("@IdOceS", oceSek);
                else
                    cm.Parameters.AddWithValue("@IdOceS", DBNull.Value);
                try
                {
                    cm.Parameters.AddWithValue("@datizl", DateTime.Parse(dr["datizl"].ToString()));
                }
                catch { cm.Parameters.AddWithValue("@datizl", DBNull.Value); }
                int izlo;
                if (int.TryParse(dr["izloc"].ToString(), out izlo))
                    cm.Parameters.AddWithValue("@izloc", izlo);
                else
                    cm.Parameters.AddWithValue("@izloc", DBNull.Value);
                cm.Parameters.AddWithValue("@IdOce", dr["IdOce"].ToString());
                cm.Parameters.AddWithValue("@IdMat", dr["IdMat"].ToString());
                int pasma;
                if (int.TryParse(dr["IdPas"].ToString(), out pasma))
                    cm.Parameters.AddWithValue("@IdPas", pasma);
                else
                    cm.Parameters.AddWithValue("@IdPas", DBNull.Value);
                int vzrizl;
                if (int.TryParse(dr["VzrokIzl"].ToString(), out vzrizl))
                    cm.Parameters.AddWithValue("@VzrokIzl", vzrizl);
                else
                    cm.Parameters.AddWithValue("@VzrokIzl", DBNull.Value);
                cm.ExecuteNonQuery();

            }
            povezava.Close();
            //5. Data Reader methods
            //while (excelReader.Read())
            //{
            //    excelReader.GetInt32(0);
            //}

            //6. Free resources (IExcelDataReader is IDisposable)
            excelReader.Close();
        }
        #endregion
    }
}
