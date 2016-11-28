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
            tcZival.DrawItem += new DrawItemEventHandler(tabControl1_DrawItem); // IZVEDBA EVENTA  Lasnosti:Aligment Left DrawMode OwnerDrawFixed Size 45(širina taba)

        }

        private void tabControl1_DrawItem(Object sender, System.Windows.Forms.DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush _textBrush;

            // Get the item from the collection.
            TabPage _tabPage = tcZival.TabPages[e.Index];

            // Get the real bounds for the tab rectangle.
            Rectangle _tabBounds = tcZival.GetTabRect(e.Index);

            if (e.State == DrawItemState.Selected)
            {

                // Draw a different background color, and don't paint a focus rectangle.
                _textBrush = new SolidBrush(Color.Red);// BARVA IZBRANEGA TEKSTA
                g.FillRectangle(Brushes.White, e.Bounds);// BARVA IZBRANEGA GUMBA
            }
            else
            {
                _textBrush = new System.Drawing.SolidBrush(e.ForeColor);
                e.DrawBackground();
            }

            // Use our own font.
            Font _tabFont = new Font("Arial", (float)18.0, FontStyle.Bold, GraphicsUnit.Pixel);

            // Draw string. Center the text.
            StringFormat _stringFlags = new StringFormat();
            _stringFlags.Alignment = StringAlignment.Center;
            _stringFlags.LineAlignment = StringAlignment.Center;
            g.DrawString(_tabPage.Text, _tabFont, _textBrush, _tabBounds, new StringFormat(_stringFlags));
        }//EVENT ZA LEVO PORAVNAVO TABOV

        

        SQLFunkcije posamezno = new SQLFunkcije();
        private void ZivalPosamezno_Load(object sender, EventArgs e)
        {

            posamezno.Metoda_branje();
            //dgwPosOpombe.DataSource = posamezno.SQLSelect("SELECT dbo.Zivali.ImeZiv, dbo.Opombe.Opis_Opombe, dbo.Opombe.Datum_Opombe, dbo.Opombe.Stanje, dbo.ImeOpombe.Ime_Opombe AS [Ime opombe]" +
            //                    " FROM dbo.Zivali INNER JOIN dbo.Opombe ON dbo.Zivali.IdZiv_S = dbo.Opombe.IdZiv_S INNER JOIN dbo.ImeOpombe ON dbo.Opombe.Ime_Opombe = dbo.ImeOpombe.Id_ImeOpombe " +
            //                    " WHERE (dbo.Zivali.IdZivOrig = '"+ Hlev.origst +"')");
            //dgwPosOpombe.Columns[0].Visible = false;
            DataTable dt = posamezno.SQLSelect("SELECT a.IdZivOrig AS [Ušesna št], a.ImeZiv AS [Ime živali], a.DatRoj AS [Rojena], b.Ime AS [Oče],c.imeziv AS [Mati] FROM Zivali a LEFT JOIN Biki b ON a.IdOceS=b.IdZiv_S LEFT JOIN Zivali c ON a.IdMatS=c.IdZiv_S WHERE (a.IdZivOrig ='" + Hlev.origst + "')");
            if (dt.Rows.Count > 0)
            {
                tbPosImeZiv.Text = dt.Rows[0][1].ToString();
                tbPosUsesStevZiv.Text = dt.Rows[0][0].ToString();
                DateTime roj;
                DateTime.TryParse(dt.Rows[0][2].ToString(), out roj);
                dtpPosRojstvoZiv.Value = roj;
                tbPosMati.Text = dt.Rows[0][4].ToString();
                tbPosOce.Text = dt.Rows[0][3].ToString();
                radioButton1.Checked = true;
            }

        }

        private void tcZival_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tcZival.SelectedIndex == 2)
            {
                dgwPosTelitve.DataSource = posamezno.SQLSelect("SELECT IdZivOrig, ImeZiv, DatRoj, Spol FROM dbo.Zivali WHERE (IdMatS = '" + Hlev.sekvenca + "')");
            }
            else if (tcZival.SelectedIndex == 1)
            {
                dgwPosKontrole.DataSource = posamezno.SQLSelect("SELECT datkon, y161, y163, y164, y165, y166, y168, y167, idlak FROM dbo.Kontrola WHERE (idZiv_S ='" + Hlev.sekvenca + "')");
            }
            else if (tcZival.SelectedIndex == 3)
            {
                dgwPosLaktacije.DataSource = posamezno.SQLSelect("SELECT  idlak, mdn, last064, last066, last067, last264, last266, last267 FROM dbo.Laktacije WHERE (idzivorig = '" + Hlev.origst + "') ORDER BY idlak");
                DataTable lak = posamezno.SQLSelect("SELECT SUM(last264) AS [Življenjska prireja], SUM(last265) AS [Kg Maščobe], SUM(last268) AS [Kg Beljakovine], MAX(idlak) AS Laktacij, SUM(last266) / MAX(idlak) AS [Povprečno maščobo], SUM(last267) / MAX(idlak) AS [Povprečno Beljakovino] FROM dbo.Laktacije WHERE (idzivorig = '" + Hlev.origst + "')");
                tbPosLitrov.Text = lak.Rows[0][0].ToString();
                tbPosMascobe.Text = lak.Rows[0][4].ToString();
                tbPosBeljakovin.Text = lak.Rows[0][5].ToString();
            }
            else if(tcZival.SelectedIndex==0)
            {
                tableLayoutPanel1.Controls.Clear();
                DataTable tabela = posamezno.SQLSelect("SELECT * FROM Opombe WHERE IdZiv_S=" + Hlev.sekvenca);
                foreach(DataRow dr in tabela.Rows)
                {
                    tableLayoutPanel1.RowCount = tableLayoutPanel1.RowCount + 1;
                    OpombeUS opomba = new OpombeUS(dr[0].ToString());
                    tableLayoutPanel1.Controls.Add(opomba);
                }
            }
        }


        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton4.Checked==true)
            { 
            tableLayoutPanel1.Controls.Clear();
            DataTable tabela = posamezno.SQLSelect("SELECT * FROM Opombe WHERE Stanje='Končana' AND IdZiv_S=" + Hlev.sekvenca);

                foreach (DataRow dr in tabela.Rows)
                {
                    tableLayoutPanel1.RowCount = tableLayoutPanel1.RowCount + 1;
                    OpombeUS opomba = new OpombeUS(dr[0].ToString());
                    tableLayoutPanel1.Controls.Add(opomba);
                }
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                tableLayoutPanel1.Controls.Clear();
                DataTable tabela = posamezno.SQLSelect("SELECT * FROM Opombe WHERE Stanje='Odprta' AND IdZiv_S=" + Hlev.sekvenca);

                foreach (DataRow dr in tabela.Rows)
                {
                    tableLayoutPanel1.RowCount = tableLayoutPanel1.RowCount + 1;
                    OpombeUS opomba = new OpombeUS(dr[0].ToString());
                    tableLayoutPanel1.Controls.Add(opomba);
                }
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                tableLayoutPanel1.Controls.Clear();
                DataTable tabela = posamezno.SQLSelect("SELECT * FROM Opombe WHERE IdZiv_S=" + Hlev.sekvenca);
                foreach (DataRow dr in tabela.Rows)
                {
                    tableLayoutPanel1.RowCount = tableLayoutPanel1.RowCount + 1;
                    OpombeUS opomba = new OpombeUS(dr[0].ToString());
                    tableLayoutPanel1.Controls.Add(opomba);
                }
            }
        }

        private void btnNazaj_Click(object sender, EventArgs e)
        {
            Hlev.nazaj = true;
            this.Close();
        }

        private void btnNaprej_Click(object sender, EventArgs e)
        {
            Hlev.naprej = true;
            this.Close();
        }
    }
}
