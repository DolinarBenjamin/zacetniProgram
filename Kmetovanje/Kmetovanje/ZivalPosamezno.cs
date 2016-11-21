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
    public partial class ZivalPosamezno : Form
    {
        public ZivalPosamezno()
        {
            InitializeComponent();
        }
        SQLFunkcije posamezno = new SQLFunkcije();
        private void ZivalPosamezno_Load(object sender, EventArgs e)
        {
            posamezno.Metoda_branje();
            dgwPosOpombe.DataSource = posamezno.SQLSelect("SELECT dbo.Zivali.ImeZiv, dbo.Opombe.Opis_Opombe, dbo.Opombe.Datum_Opombe, dbo.Opombe.Stanje, dbo.ImeOpombe.Ime_Opombe AS [Ime opombe]"+
                                " FROM dbo.Zivali INNER JOIN dbo.Opombe ON dbo.Zivali.IdZivS = dbo.Opombe.IdZivS INNER JOIN dbo.ImeOpombe ON dbo.Opombe.Ime_Opombe = dbo.ImeOpombe.Id_ImeOpombe "+
                                " WHERE (dbo.Zivali.IdZivOrig = '33881665')");
        }

        private void tcZival_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tcZival.SelectedIndex == 2)
            {
                dgwPosTelitve.DataSource= posamezno.SQLSelect("SELECT IdZivOrig, ImeZiv, DatRoj, Spol FROM dbo.Zivali WHERE (IdMat = 'SVN    33881665')");
            }
            else if (tcZival.SelectedIndex==1)
            {
                dgwPosKontrole.DataSource= posamezno.SQLSelect("SELECT dbo.Kontrola.dattel, dbo.Kontrola.datkon, dbo.Kontrola.y161, dbo.Kontrola.y162a, dbo.Kontrola.y163, dbo.Kontrola.y164, dbo.Kontrola.y166, dbo.Kontrola.y167 "+
                                    " FROM dbo.Kontrola INNER JOIN dbo.Zivali ON dbo.Kontrola.idZiv_S = dbo.Zivali.IdZivS WHERE (dbo.Zivali.IdZivOrig = '33881665' AND idlak='1')");
            }
        }
    }
}
