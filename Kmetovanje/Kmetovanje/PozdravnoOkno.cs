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

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Baje da dela?", "Opozorilo", MessageBoxButtons.OK);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hlev nov = new Hlev();
            nov.ShowDialog();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Polje nov = new Polje();
            nov.ShowDialog();
            this.Hide();
        }
    }
}
