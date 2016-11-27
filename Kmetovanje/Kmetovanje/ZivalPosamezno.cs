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
            dgwPosOpombe.DataSource = posamezno.SQLSelect("SELECT dbo.Zivali.ImeZiv, dbo.Opombe.Opis_Opombe, dbo.Opombe.Datum_Opombe, dbo.Opombe.Stanje, dbo.ImeOpombe.Ime_Opombe AS [Ime opombe]" +
                                " FROM dbo.Zivali INNER JOIN dbo.Opombe ON dbo.Zivali.IdZiv_S = dbo.Opombe.IdZiv_S INNER JOIN dbo.ImeOpombe ON dbo.Opombe.Ime_Opombe = dbo.ImeOpombe.Id_ImeOpombe " +
                                " WHERE (dbo.Zivali.IdZivOrig = '"+ Hlev.origst +"')");
            dgwPosOpombe.Columns[0].Visible = false;
            dgwtest.DataSource = posamezno.SQLSelect("SELECT a.IdZivOrig AS [Ušesna št], a.ImeZiv AS [Ime živali], a.DatRoj AS [Rojena], b.Ime AS [Oče],c.imeziv AS [Mati] FROM Zivali a LEFT JOIN Biki b ON a.IdOceS=b.IdZiv_S LEFT JOIN Zivali c ON a.IdMatS=c.IdZiv_S WHERE (a.IdZivOrig ='" + Hlev.origst + "')");
            tbPosImeZiv.Text = dgwtest.Rows[0].Cells[1].Value.ToString();
            tbPosUsesStevZiv.Text= dgwtest.Rows[0].Cells[0].Value.ToString();
            DateTime roj;
            DateTime.TryParse(dgwtest.Rows[0].Cells[2].Value.ToString(), out roj);
            dtpPosRojstvoZiv.Value = roj;
            tbPosMati.Text = dgwtest.Rows[0].Cells[4].Value.ToString();
            tbPosOce.Text = dgwtest.Rows[0].Cells[3].Value.ToString();
            //a bi ti to znou kej drugač rešit???

        }

        private void tcZival_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tcZival.SelectedIndex == 2)
            {
                dgwPosTelitve.DataSource = posamezno.SQLSelect("SELECT IdZivOrig, ImeZiv, DatRoj, Spol FROM dbo.Zivali WHERE (IdMat = 'SVN    " + Hlev.origst + "')");
            }
            else if (tcZival.SelectedIndex == 1)
            {
                dgwPosKontrole.DataSource = posamezno.SQLSelect("SELECT datkon, y161, y163, y164, y165, y166, y168, y167, idlak FROM dbo.Kontrola WHERE (idZiv_S ='"+Hlev.sekvenca+"')");
            }
            else if (tcZival.SelectedIndex == 3)
            {
                dgwPosLaktacije.DataSource= posamezno.SQLSelect("SELECT TOP (100) PERCENT ImeZiv, roj, idlak, mdn, last064, last066, last067, last264, last266, last267 FROM dbo.Laktacije WHERE (idzivorig = '" + Hlev.origst + "') ORDER BY idlak");
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

    }
}
