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

namespace TravelEurope.WinUI.Rezervacija
{
    public partial class frmRezervacija : Form
    {
        private readonly APIService _serviceRezervacija = new APIService("Rezervacija");

        public frmRezervacija()
        {
            InitializeComponent();
        }

        private async void btnPretraga_Click(object sender, EventArgs e)
        {
            await UcitajFormu();
        }

        private async Task UcitajFormu()
        {
            var request = new Model.Requests.RezervacijeSearchRequest
            {
                Naziv = txtNazivRezervacije.Text
            };

            List<Model.Rezervacije> lista = await _serviceRezervacija.Get<List<Model.Rezervacije>>(request);

            dgvRezervacija.AutoGenerateColumns = false;
            dgvRezervacija.DataSource = lista;
        }

        private async void frmRezervacija_Load(object sender, EventArgs e)
        {
            await UcitajFormu();
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