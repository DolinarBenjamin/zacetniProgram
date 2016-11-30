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
    public partial class Opravila : Form
    {
        public Opravila()
        {
            InitializeComponent();
        }
        SQLFunkcije oprav = new SQLFunkcije();
        private void Opravila_Load(object sender, EventArgs e)
        {
            oprav.Metoda_branje();
            dgwOpravila.DataSource = oprav.SQLSelect("SELECT * FROM Opravila");
            dgwOpravila.Columns[0].Visible = false;
        }
        private void btnUredi_Click(object sender, EventArgs e)
        {
            btnShrani.Visible = true;
            gbOpravila.Visible = true;
        }
        public void PocistiPolja()
        {
            tbImeOpravila.Clear();
            tbCenaOpravila.Clear();
            cbEnotaOpravila.SelectedIndex = -1;
        }
        private void dgwOpravila_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgwOpravila.CurrentCell != null)
            {
                tbImeOpravila.Text = dgwOpravila.CurrentRow.Cells[1].Value.ToString();
                tbCenaOpravila.Text = dgwOpravila.CurrentRow.Cells[2].Value.ToString();
                cbEnotaOpravila.SelectedItem = dgwOpravila.CurrentRow.Cells[3].Value.ToString();
            }
        }
        private void tbCenaOpravila_KeyPress(object sender, KeyPressEventArgs e)
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
        private void btnShrani_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection povezava = new SqlConnection(oprav.Baza_povezava);
                povezava.Open();
                SqlCommand cm = new SqlCommand("IF EXISTS (SELECT NULL FROM Opravila WHERE [Id_Opravila]=" + dgwOpravila.CurrentRow.Cells[0].Value.ToString() + ") UPDATE Opravila SET [Ime_opravila]=@ime,[Cena]=@Cena,[Enota]=@Enota WHERE [Id_Opravila]=" + dgwOpravila.CurrentRow.Cells[0].Value.ToString(), povezava);
                cm.Parameters.AddWithValue("@ime", tbImeOpravila.Text.ToString());
                cm.Parameters.AddWithValue("@Cena", tbCenaOpravila.Text.ToString());
                cm.Parameters.AddWithValue("@Enota", cbEnotaOpravila.SelectedItem.ToString());
                cm.ExecuteNonQuery();
                povezava.Close();
                dgwOpravila.ClearSelection();
                dgwOpravila.Rows.Clear();
                dgwOpravila.DataSource = oprav.SQLSelect("SELECT * FROM Opravila");
                dgwOpravila.Columns[0].Visible = false;
                PocistiPolja();
            }
            catch (Exception ex) { MessageBox.Show("Prišlo je do napake pri vnosu podatkov\n" + ex.Message, "NAPAKA", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnDodajOp_Click(object sender, EventArgs e)
        {
            PocistiPolja();
            tbImeOpravila.Focus();
        }
    }
}
