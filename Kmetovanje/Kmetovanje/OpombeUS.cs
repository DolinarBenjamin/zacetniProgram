using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;


namespace Kmetovanje
{
    public partial class OpombeUS : UserControl
    {
        public OpombeUS(string Id_opombe)
        {
            InitializeComponent();
            Opomba = Id_opombe;
        }
        public string Opomba { get; set; }
        SQLFunkcije Baza = new SQLFunkcije();
        
        private void OpombeUS_Load(object sender, EventArgs e)
        {
            Baza.Metoda_branje();
            DataTable tabela=Baza.SQLSelect("SELECT * FROM Opombe WHERE Id_Opombe="+Opomba);
            lbopomba.Text = tabela.Rows[0]["Ime_Opombe"].ToString();
            lbdatum.Text = DateTime.Parse(tabela.Rows[0]["Datum_Opombe"].ToString()).ToString("dd.MM.yyyy");
            lbstatus.Text = tabela.Rows[0]["Stanje"].ToString();
            if (lbstatus.Text == "Končana")
                lbstatus.ForeColor = Color.Green;
            tbopomba.Text = tabela.Rows[0]["Opis_Opombe"].ToString();
            bturejanje.Enabled = false;
        }

        private void lbstatus_DoubleClick(object sender, EventArgs e)
        {
            if (lbstatus.Text == "Odprto")
            {
                lbstatus.Text = "Končana";
                lbstatus.ForeColor = Color.Green;
            }
            else
            {
                lbstatus.Text = "Odprto";
                lbstatus.ForeColor = Color.Red;
            }
            bturejanje.Enabled = true;
        }

        private void tbopomba_DoubleClick(object sender, EventArgs e)
        {
            tbopomba.ReadOnly = false;
            bturejanje.Enabled = true;
        }

        private void bturejanje_Click(object sender, EventArgs e)
        {
            SqlConnection povezava = new SqlConnection(Baza.Baza_povezava);
            povezava.Open();
            SqlCommand cm = new SqlCommand("UPDATE Opombe SET Stanje=@Stanje,Opis_opombe=@Opis_opombe WHERE Id_Opombe="+Opomba,povezava);
            cm.Parameters.AddWithValue("@Stanje", lbstatus.Text);
            cm.Parameters.AddWithValue("@Opis_opombe", tbopomba.Text);
            cm.ExecuteNonQuery();
            povezava.Close();
            bturejanje.Enabled = false;
        }

        private void btizbriši_Click(object sender, EventArgs e)
        {
            DialogResult izbrisi = MessageBox.Show("Ali želite izbrisati opombo?", "IZBRIŠI", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(izbrisi==DialogResult.Yes)
            {
                SqlConnection povezava = new SqlConnection(Baza.Baza_povezava);
                povezava.Open();
                SqlCommand cm = new SqlCommand("DELETE FROM Opombe WHERE Id_Opombe=" + Opomba, povezava);
                cm.ExecuteNonQuery();
                povezava.Close();
                this.Hide();
            }
        }
    }
}
