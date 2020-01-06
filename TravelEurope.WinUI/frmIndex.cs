using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelEurope.Model;

namespace TravelEurope.WinUI
{
    public partial class frmIndex : Form
    {
        public frmIndex()
        {
            InitializeComponent();
        }

        private void PregledToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new Korisnici.frmKorisnici();
            frm.Show();
        }
    }
}
