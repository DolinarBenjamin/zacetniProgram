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
    public partial class Opravila : Form
    {
        public Opravila()
        {
            InitializeComponent();
        }
        SQLFunkcije oprav = new SQLFunkcije();
        private void btnUredi_Click(object sender, EventArgs e)
        {
            oprav.Metoda_branje();
            dgwOpravila.DataSource = oprav.SQLSelect("SELECT * FROM Opravila");
            dgwOpravila.Columns[0].Visible = false;
        }
    }
}
