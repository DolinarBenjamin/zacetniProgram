using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        }

        private void tcHlev_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tcHlev.SelectedIndex == 2)
            {
                dgwKontrole.DataSource = test.SQLSelect("SELECT [ImeZiv] AS [Ime], [roj] AS [Rojstvo], [idlak] AS [Laktacija], [dattel] AS [Telila], [datkon] AS [Kontrola], [y164] AS [KG Mleka], [y161] AS [Laktoza], [y162a] AS [Somat Cel],[y163] AS [Urea]," +
                                                     " [y166] AS [Maščoba], [y167] AS [Beljakovina] FROM Kontrola WHERE [datkon] BETWEEN '" + dtpODKontrole.Value.ToString("yyyy-MM-dd") + "' AND '" + dtpDOKontrole.Value.ToString("yyyy-MM-dd") + "'");
            }
            else if (tcHlev.SelectedIndex == 1)
            {
                cbOsemPreg.SelectedIndex = -1;
                dgwOsemenitve.DataSource = test.SQLSelect("SELECT  IdZiv_S, IdZivOrig AS[Številka], ImeZiv AS[Ime Živali], DatRoj AS[Rojstvo], Spol.Ime_Spol AS[Spol], IMEPASD AS[Pasma] FROM Zivali, Pasme, Spol WHERE izloc = '0' AND Zivali.IdPas = Pasme.IDPAS AND Zivali.Spol = Spol.Id_Spol");
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

        private void btnPodrobnostiAktZiv_Click(object sender, EventArgs e)
        {
            ZivalPosamezno zival = new ZivalPosamezno();
            zival.ShowDialog();
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
        #endregion
    }
}
