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
            dgwAktivneZiv.DataSource = test.SQLSelect("SELECT  IdZivS, IdZivOrig AS[Številka], ImeZiv AS[Ime Živali], DatRoj AS[Rojstvo], Spol.Ime_Spol AS[Spol], IMEPASD AS[Pasma] FROM Zivali, Pasme, Spol WHERE izloc = '0' AND Zivali.IdPas = Pasme.IDPAS AND Zivali.Spol = Spol.Id_Spol");
            if (dgwAktivneZiv.Columns.Count > 0)
            {
                dgwAktivneZiv.Columns[0].Visible = false;
                dgwAktivneZiv.Columns[2].Width = 250;
                dgwAktivneZiv.Columns[3].Width = 120;
            }
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
                dgwOsemenitve.DataSource = test.SQLSelect("SELECT dbo.Osemenitve.Id_Osemenitve, dbo.Osemenitve.Ime_PregOsem, dbo.Zivali.IdZivOrig, dbo.Zivali.ImeZiv, dbo.Zivali.DatRoj, dbo.Spol.Ime_Spol, dbo.Pasme.IMEPASD, dbo.Osemenitve.Datum_Osemenitve, dbo.Osemenitve.Datum_Pregleda, dbo.Osemenitve.Uspeh_Pregleda, dbo.Osemenitve.Datum_Telitve "+
                                                          "FROM dbo.Osemenitve INNER JOIN dbo.Zivali ON dbo.Osemenitve.IdZivS = dbo.Zivali.IdZivS INNER JOIN dbo.Pasme ON dbo.Zivali.IdPas = dbo.Pasme.IDPAS INNER JOIN dbo.Spol ON dbo.Zivali.Spol = dbo.Spol.Id_Spol WHERE (dbo.Osemenitve.Uspeh_Pregleda='Breja')");
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
    }
}
