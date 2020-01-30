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

namespace TravelEurope.WinUI.Vozilo
{
    public partial class frmVozila : Form
    {
        private readonly APIService _serviceVozila = new APIService("Vozilo");

        public frmVozila()
        {
            InitializeComponent();
        }

        private async void btnPretraga_Click(object sender, EventArgs e)
        {
            await UcitajFormu();
        }

        private async Task UcitajFormu()
        {
            var request = new Model.Requests.VoziloSearchRequest
            {
                Naziv = txtNaziv.Text
            };

            List<Model.Vozilo> lista = await _serviceVozila.Get<List<Model.Vozilo>>(request);

            dgvVozila.AutoGenerateColumns = false;
            dgvVozila.DataSource = lista;
        }

        private async void frmVozila_Load(object sender, EventArgs e)
        {
            await UcitajFormu();
        } 


        private async void btnDodajVozilo(object sender, EventArgs e)
        {
            var frm = new Vozilo.frmVozilaDetalji();
            if (frm.ShowDialog() == DialogResult.OK)
                await UcitajFormu();
        }

        private async void dgvKorisnici_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = int.Parse(dgvVozila.SelectedRows[0].Cells[0].Value.ToString());

            var frm = new frmVozilaDetalji(id);
            if (frm.ShowDialog() == DialogResult.OK)
                await UcitajFormu();
        }

    }
}
