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
    public partial class PozdravnoOkno : Form
    {
        public PozdravnoOkno()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Hlev nov = new Hlev();
            nov.ShowDialog();
           // this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Polje nov = new Polje();
            nov.ShowDialog();
        }
        SQLFunkcije uvoz = new SQLFunkcije();
        private void button3_Click(object sender, EventArgs e)
        {
            uvoz.Metoda_branje();
            ofdUvoziKontrole.ShowDialog();
            DataTable tabela = uvoz.PreberiExcel(ofdUvoziKontrole.FileName);
            if (tabela != null)
            {
                if (tabela.Columns.Count == 18)
                    uvoz.UvoziKontrole(tabela);
                else if (tabela.Columns.Count == 17)
                    uvoz.UvozKontrolMesecno(tabela);
                else if (tabela.Columns.Count == 26)
                    uvoz.UvoziZivali(tabela);
                else if (tabela.Columns.Count == 24)
                    uvoz.UvoziLaktacije(tabela);
                else
                    MessageBox.Show("IZBRALI STE NAPAČNO DATOTEKO", "NAPAKA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
