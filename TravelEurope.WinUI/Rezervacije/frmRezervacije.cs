using TravelEurope.Model.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelEurope.WinUI.Rezervacije
{
    public partial class frmRezervacije : Form
    {
        private readonly APIService _serviceRezervacije = new APIService("Rezervacije");
        private readonly APIService _serviceKategorije = new APIService("Kategorije");

        public frmRezervacije()
        {
            InitializeComponent();
        }

        private async void btnPretraga_Click(object sender, EventArgs e)
        {
            await UcitajFormu();
        }

        private async Task UcitajFormu()
        {
            var request = new Model.Requests.RezervacijeSearchRequest();
            if (chBDK.Checked)
            {
                request.DatumRezervacije = dtpDatumKreiranja.Value;
            }
            List<Model.Rezervacije> lista = await _serviceRezervacije.Get<List<Model.Rezervacije>>(request);

            dgvRezervacija.AutoGenerateColumns = false;
            dgvRezervacija.DataSource = lista;
        }

        private void frmRezervacija_Load(object sender, EventArgs e)
        {
            dtpDatumKreiranja.MaxDate = DateTime.Now.Date;
            dtpDatumKreiranja.Value = DateTime.Now.Date;
        }

        private void chBDK_CheckedChanged(object sender, EventArgs e)
        {
            if (chBDK.Checked)
                dtpDatumKreiranja.Enabled = true;
            else
                dtpDatumKreiranja.Enabled = false;
        }

        //private async void dgvRezervacija_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    var id = int.Parse(dgvRezervacija.SelectedRows[0].Cells[0].Value.ToString());

        //    var frm = new frmRezervacijaDetalji(id);
        //    frm.ShowDialog();
        //    await UcitajFormu();
        //}
    }
}