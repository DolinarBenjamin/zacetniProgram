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
    public partial class Polje : Form
    {
        public Polje()
        {
            InitializeComponent();
        }
        SQLFunkcije pole = new SQLFunkcije();
        private void Polje_Load(object sender, EventArgs e)
        {
            pole.Metoda_branje();
            dgwPovrsine.DataSource= pole.SQLSelect("SELECT [GERK-PID] AS Gerk, [Domače ime] AS Ime, [Površina] AS Povrsina, [Povprečni naklon] AS Naklon, Raba FROM Zemljisca");
            
        }

        private void btnOpravila_Click(object sender, EventArgs e)
        {
            Opravila novo = new Opravila();
            novo.ShowDialog();
        }

        private void tbIzracunVProc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
            // only allow one decimal point
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void tcPolje_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tcPolje.SelectedIndex == 2)
            {
                dgwIzracunCene.DataSource = pole.SQLSelect("SELECT dbo.Kultura.Ime_Kulture AS[Ime], dbo.Zemljisca.[Domače ime], dbo.Kultura.Datum_Opravila AS[Datum], dbo.Opravila.Ime_Opravila AS[Opravilo], dbo.Kultura.Cena_Opravila AS[Cena], dbo.Kultura.Pridelek, dbo.Kultura.Datum_Zakljucka AS[Dat Zakljucka] " +
                                                "FROM dbo.Opravila INNER JOIN " +
                                                "dbo.Kultura ON dbo.Opravila.Id_Opravila = dbo.Kultura.Id_Opravila INNER JOIN " +
                                                "dbo.Zemljisca ON dbo.Kultura.[GERK-PID] = dbo.Zemljisca.[GERK-PID]");
                dgwIzracunCene.Columns[0].Width = 130;
                dgwIzracunCene.Columns[1].Width = 150;
                dgwIzracunCene.Columns[2].Width = 120;
                dgwIzracunCene.Columns[3].Width = 200;
                dgwIzracunCene.Columns[4].Width = 80;
            }
            else if (tcPolje.SelectedIndex == 3)
            {
                dgwPopravki.DataSource = pole.SQLSelect("SELECT dbo.Kultura.Id_Kultura, dbo.Kultura.Ime_Kulture AS [Ime], dbo.Zemljisca.[Domače ime], dbo.Kultura.Datum_Opravila AS [Datum], dbo.Opravila.Ime_Opravila AS [Opravilo], dbo.Kultura.Cena_Opravila AS [Cena], dbo.Kultura.Pridelek, dbo.Kultura.Datum_Zakljucka AS [Dat Zakljucka], dbo.Kultura.Id_Gnojilo, dbo.Kultura.Id_ffs, dbo.Kultura.Porabljena_Kolicina, dbo.Kultura.Porabljena_Kol_Cena, dbo.Zemljisca.[GERK-PID], dbo.Opravila.Id_Opravila " +
                                                        "FROM dbo.Opravila INNER JOIN " +
                                                        "dbo.Kultura ON dbo.Opravila.Id_Opravila = dbo.Kultura.Id_Opravila INNER JOIN " +
                                                        "dbo.Zemljisca ON dbo.Kultura.[GERK-PID] = dbo.Zemljisca.[GERK-PID]");
                dgwPopravki.Columns[1].Width = 130;
                dgwPopravki.Columns[2].Width = 150;
                dgwPopravki.Columns[3].Width = 120;
                dgwPopravki.Columns[4].Width = 200;
                dgwPopravki.Columns[5].Width = 80;
                dgwPopravki.Columns[0].Visible = false;
                dgwPopravki.Columns[8].Visible = false;
                dgwPopravki.Columns[9].Visible = false;
                dgwPopravki.Columns[10].Visible = false;
                dgwPopravki.Columns[11].Visible = false;
                dgwPopravki.Columns[12].Visible = false;
                dgwPopravki.Columns[13].Visible = false;
            }
        }

        private void dgwPovrsine_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgwPovrsine.CurrentCell != null)
            {
                tbPolDomaceIme .Text = dgwPovrsine.CurrentRow.Cells[1].Value.ToString();
                tbPolVelikostP.Text = dgwPovrsine.CurrentRow.Cells[2].Value.ToString();
                tbPolNaklon.Text = dgwPovrsine.CurrentRow.Cells[3].Value.ToString();
                cbPolRaba.SelectedItem = dgwPovrsine.CurrentRow.Cells[4].Value.ToString();
            }
        }

        private void btnUredi_Click(object sender, EventArgs e)
        {
            gbPoljeVnos.Visible = true;
            btnShrani.Visible = true;
        }
        public void PocistiPolja()
        {
            tbPolDomaceIme.Clear();
            tbPolNaklon.Clear();
            cbPolRaba.SelectedIndex = -1;
            tbPolVelikostP.Clear();
            tbPolGERKPID.Clear();
            tbIzracunVProc.Clear();
            gbPoljeVnos.Visible = false;
        }
    }
}
