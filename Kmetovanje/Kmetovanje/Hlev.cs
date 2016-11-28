using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Kmetovanje
{
    public partial class Hlev : Form
    {
        public Hlev()
        {
            InitializeComponent();
        }
        SQLFunkcije test = new SQLFunkcije();
        private void Hlev_Load(object sender, EventArgs e)
        {
            test.Metoda_branje();
            dgwAktivneZiv.DataSource = test.SQLSelect("SELECT  IdZiv_S, IdZivOrig AS[Številka], ImeZiv AS[Ime Živali], DatRoj AS[Rojstvo], Spol.Ime_Spol AS[Spol], IMEPASD AS[Pasma] FROM Zivali, Pasme, Spol WHERE izloc = '0' AND Zivali.IdPas = Pasme.IDPAS AND Zivali.Spol = Spol.Id_Spol");
            if (dgwAktivneZiv.Columns.Count > 0)
            {
                dgwAktivneZiv.Columns[0].Visible = false;
                dgwAktivneZiv.Columns[2].Width = 250;
                dgwAktivneZiv.Columns[3].Width = 120;
            }

            cbBik.DataSource = new BindingSource(test.NapolniComboBox(), null);
            cbBik.DisplayMember = "Value";
            cbBik.ValueMember = "Key";
            cbBik.SelectedIndex = -1;
            cbImeOpombe.DataSource = new BindingSource(test.NapolniComboImeOpombe(),null);
            cbImeOpombe.DisplayMember = "Value";
            cbImeOpombe.ValueMember = "Key";
            cbImeOpombe.SelectedIndex = -1;
            dgwAktivneZiv.ClearSelection();

        }

        private void tcHlev_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tcHlev.SelectedIndex == 3)
            {
                dgwKontrole.DataSource = test.SQLSelect("SELECT [ImeZiv] AS [Ime], [roj] AS [Rojstvo], [idlak] AS [Laktacija], [dattel] AS [Telila], [datkon] AS [Kontrola], [y164] AS [KG Mleka], [y161] AS [Laktoza], [y162a] AS [Somat Cel],[y163] AS [Urea]," +
                                                     " [y166] AS [Maščoba], [y167] AS [Beljakovina] FROM Kontrola WHERE [datkon] BETWEEN '" + dtpODKontrole.Value.ToString("yyyy-MM-dd") + "' AND '" + dtpDOKontrole.Value.ToString("yyyy-MM-dd") + "'");
            }
            else if (tcHlev.SelectedIndex == 1)
            {
                cbOsemPreg.SelectedIndex = -1;
                dgwOsemenitve.DataSource = test.SQLSelect("SELECT a.IdZivOrig AS [Ušesna št], a.ImeZiv AS [Ime živali], a.DatRoj AS [Rojena], p.ImePasD AS [Pasma], b.Ime AS [Oče],c.imeziv AS [Mati] FROM Zivali a LEFT JOIN Biki b ON a.IdOceS=b.IdZiv_S LEFT JOIN Zivali c ON a.IdMatS=c.IdZiv_S LEFT JOIN Pasme p ON a.IdPas=p.IdPas");
                
            }
            else if (tcHlev.SelectedIndex==5)
            {
                dgwVseZivali.DataSource = test.SQLSelect("SELECT  IdZivOrig AS[Številka], ImeZiv AS[Ime Živali], DatRoj AS[Rojstvo], Spol.Ime_Spol AS[Spol], IMEPASD AS[Pasma] FROM Zivali, Pasme, Spol WHERE Zivali.IdPas = Pasme.IDPAS AND Zivali.Spol = Spol.Id_Spol");
            }
        }

        private void btnPrikaziKontrole_Click(object sender, EventArgs e)
        {
            dgwKontrole.DataSource = test.SQLSelect("SELECT [ImeZiv] AS [Ime], [roj] AS [Rojstvo], [idlak] AS [Laktacija], [dattel] AS [Telila], [datkon] AS [Kontrola], [y164] AS [KG Mleka], [y161] AS [Laktoza], [y162a] AS [Somat Cel],[y163] AS [Urea]," +
                                                     " [y166] AS [Maščoba], [y167] AS [Beljakovina] FROM Kontrola WHERE [datkon] BETWEEN '" + dtpODKontrole.Value.ToString("yyyy-MM-dd") + "' AND '" + dtpDOKontrole.Value.ToString("yyyy-MM-dd") + "'");
        }

        private void dgwAktivneZiv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbIzbranaZival.Text = dgwAktivneZiv.CurrentRow.Cells[2].Value.ToString();
        }
        public static string origst { get; set; }
        public static string sekvenca { get; set; }
        public static int IdZivali { get; set; }
        public static bool naprej { get; set; }
        public static bool nazaj { get; set; }
        private void btnPodrobnostiAktZiv_Click(object sender, EventArgs e)
        {
            if (dgwAktivneZiv.CurrentCell != null)
            {
                naprej = false;
                nazaj = false;
                sekvenca = dgwAktivneZiv.CurrentRow.Cells[0].Value.ToString();
                origst = dgwAktivneZiv.CurrentRow.Cells[1].Value.ToString();
                ZivalPosamezno zival = new ZivalPosamezno();
                zival.ShowDialog();
                if (naprej == true)
                {
                    if (dgwAktivneZiv.CurrentCell.RowIndex + 1 < dgwAktivneZiv.Rows.Count)
                    {
                        dgwAktivneZiv.CurrentCell = dgwAktivneZiv.Rows[dgwAktivneZiv.CurrentCell.RowIndex + 1].Cells[1];
                        btnPodrobnostiAktZiv_Click(this, EventArgs.Empty);
                    }
                }
                else if (nazaj == true)
                {
                    if (dgwAktivneZiv.CurrentCell.RowIndex -1>=0)
                    {
                        dgwAktivneZiv.CurrentCell = dgwAktivneZiv.Rows[dgwAktivneZiv.CurrentCell.RowIndex - 1].Cells[1];
                        btnPodrobnostiAktZiv_Click(this, EventArgs.Empty);
                    }
                }
                
            }
        }
        #region Osemenitve
        private void dtpDatumOsemPreg_ValueChanged(object sender, EventArgs e)
        {
            if (cbOsemPreg.SelectedIndex == 0)
            {
                dtpPredvidenPregTel.Value = dtpDatumOsemPreg.Value.AddDays(42);
            }
        }

        private void cbOsemPreg_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbOsemPreg.SelectedItem.ToString() == "Osemenitev")
            {
                lblOsemPreg.Text = "Osemenitev";
                lblDatumOsemPreg.Text = "Datum osemenitve";
                lblPredvidenDatum.Text = "Predviden datum pregleda";
                chebOsemPregon.Visible = false;
                lblIzidPreg.Visible = false;
                btnDodajOsemPreg.Text = "Dodaj osemenitev";
            }
            else
            {
                lblOsemPreg.Text = "Pregled";
                lblDatumOsemPreg.Text = "Datum pregleda";
                lblPredvidenDatum.Text = "Predviden datum telitve";
                cbBik.Enabled = false;
                chebOsemPregon.Visible = true;
                lblIzidPreg.Visible = true;
                btnDodajOsemPreg.Text = "Dodaj pregled";
            }
        }
        
        private void dgwOsemenitve_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (cbOsemPreg.SelectedItem != null)
            {
                if (cbOsemPreg.SelectedItem.ToString() == "Osemenitev")
                {
                    tbIzbranaZivOsemPreg.Text = dgwOsemenitve.CurrentRow.Cells[2].Value.ToString();
                }
                else if (cbOsemPreg.SelectedItem.ToString() == "Pregled")
                {
                    tbIzbranaZivOsemPreg.Text = dgwOsemenitve.CurrentRow.Cells[2].Value.ToString();
                }
            }
        }
       
        private void btnDodajOsemPreg_Click(object sender, EventArgs e)
        {
            SqlConnection povezava = new SqlConnection(test.Baza_povezava);
            if (cbOsemPreg.SelectedItem.ToString() == "Osemenitev")
            {
                povezava.Open();
                SqlCommand cm= new SqlCommand("INSERT INTO Osemenitve ([IdZivOrig], [St_Osemenitve], [Datum_Osemenitve], [Datum_Pregleda], [Uspeh_Pregleda], [Datum_Telitve], [Id_Bika]) " +
                                                               "VALUES ( @IdZivOrig, @StOsemenitve, @DatOsem, @DatPreg, @Uspeh, @DatTel, @Bik)", povezava);
                int i = 1;
                cm.Parameters.AddWithValue("@IdZivOrig", dgwOsemenitve.CurrentRow.Cells[0].Value.ToString());
                cm.Parameters.AddWithValue("@StOsemenitve", i.ToString());
                string usp = "Osemenjena";
                cm.Parameters.AddWithValue("@DatOsem",dtpDatumOsemPreg.Value.ToString("yyyy-MM-dd"));
                cm.Parameters.AddWithValue("@DatPreg", dtpPredvidenPregTel.Value.ToString("yyyy-MM-dd"));
                cm.Parameters.AddWithValue("@Uspeh", usp);
                cm.Parameters.AddWithValue("@DatTel", DBNull.Value);
                cm.Parameters.AddWithValue("@Bik", cbBik.SelectedIndex.ToString());
                cm.ExecuteNonQuery();
                povezava.Close();
            }
            else if(cbOsemPreg.SelectedItem.ToString()=="Pregled")
            {
                povezava.Open();
                SqlCommand cm = new SqlCommand("UPDATE Osemenitve SET [Datum_Pregleda]= @DatPreg, [Uspeh_Pregleda]= @Uspeh, [Datum_Telitve]=@DatTel WHERE Osemenitve.Id_Osemenitve=" + dgwOsemenitve.CurrentRow.Cells[0].Value.ToString(), povezava);
                cm.Parameters.AddWithValue("@DatPreg", dtpDatumOsemPreg.Value.ToString("yyyyy-MM-dd"));
                if (chebOsemPregon.Checked == true)
                {
                    string usp = "Breja";
                    cm.Parameters.AddWithValue("@DatTel", dtpPredvidenPregTel.Value.ToString("yyyy-MM-dd"));
                    cm.Parameters.AddWithValue("@Uspeh", usp);
                }
                else
                {
                    string usp = "Pregon";
                    cm.Parameters.AddWithValue("@DatTel", DBNull.Value);
                    cm.Parameters.AddWithValue("@Useph", usp);
                }
                cm.ExecuteNonQuery();
                povezava.Close();

            }
        }
        #endregion

        private void btnDodajOpombo_Click(object sender, EventArgs e)
        {
            SqlConnection povezava = new SqlConnection(test.Baza_povezava);
            povezava.Open();
            SqlCommand cm = new SqlCommand("INSERT INTO Opombe ([IdZiv_S], [Ime_Opombe], [Opis_Opombe], [Datum_Opombe], [Stanje]) " +
                                                          "VALUES ( @Idzivs, @imeOpombe, @opis, @Datum, @Stanje)", povezava);
            cm.Parameters.AddWithValue("@Idzivs", dgwAktivneZiv.CurrentRow.Cells[0].Value.ToString());
            cm.Parameters.AddWithValue("@imeOpombe", cbImeOpombe.SelectedValue.ToString());
            cm.Parameters.AddWithValue("@opis", tbOpisOpombe.Text.ToString());
            cm.Parameters.AddWithValue("@Datum", dtpDatumOpombe.Value.ToString("yyyy-MM-dd"));
            if (chebOsemPregon.Checked == true)
            {
                string stanje = "Končana";
                cm.Parameters.AddWithValue("@Stanje", stanje);
            }
            else
            {
                string stanje = "Odprta";
                cm.Parameters.AddWithValue("@Stanje", stanje);
            }
            cm.ExecuteNonQuery();
            povezava.Close();
            cbImeOpombe.SelectedIndex = -1;
            dtpDatumOpombe.Value = DateTime.Now.Date;
            tbOpisOpombe.Clear();
            tbIzbranaZival.Clear();
            tbIzbranaZival.Focus();

        }
    }
}
