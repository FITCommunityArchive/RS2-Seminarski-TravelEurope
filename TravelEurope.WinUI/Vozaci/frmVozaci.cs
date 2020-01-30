using Flurl.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelEurope.WinUI.Vozaci
{
    public partial class frmVozaci : Form
    {
        private readonly APIService _serviceVozaci = new APIService("Vozac");

        public frmVozaci()
        {
            InitializeComponent();
        }

        private async void btnPretraga_Click(object sender, EventArgs e)
        {
            await UcitajFormu();
        }

        private async Task UcitajFormu()
        {
            var request = new Model.Requests.VozacSearchRequest
            {
                Naziv = txtNaziv.Text
            };

            List<Model.Vozac> lista = await _serviceVozaci.Get<List<Model.Vozac>>(request);

            dgvVozila.AutoGenerateColumns = false;
            dgvVozila.DataSource = lista;
        }

        private async void frmVozaci_Load(object sender, EventArgs e)
        {
            await UcitajFormu();
        }

        private async void btnDodajVozac(object sender, EventArgs e)
        {
            var frm = new Vozaci.frmVozacDetalji();
            if (frm.ShowDialog() == DialogResult.OK)
                await UcitajFormu();
        }

        private async void dgvKorisnici_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = int.Parse(dgvVozila.SelectedRows[0].Cells[0].Value.ToString());

            var frm = new frmVozacDetalji(id);
            if (frm.ShowDialog() == DialogResult.OK)
                await UcitajFormu();
        }

        private async void btnDodajVozaca_Click(object sender, EventArgs e)
        {
            var frm = new frmVozacDetalji();
            if (frm.ShowDialog() == DialogResult.OK)
                await UcitajFormu();
        }
    }
}
