using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelEurope.WinUI.Lokacije
{
    public partial class frmUrediDrzavu : Form
    {
        private readonly APIService _serviceDrzave = new APIService("Drzava");
        private readonly APIService _serviceGradovi = new APIService("Grad");
        private int _id;

        public frmUrediDrzavu(int id)
        {
            InitializeComponent();
            _id = id;
        }

        private async void btnUredi_Click(object sender, EventArgs e)
        {
            var request = new Model.Requests.DrzavaInsertRequest
            {
                Naziv = txtNaziv.Text,

            };

            var entity = await _serviceDrzave.Update<Model.Drzava>(_id, request);
            if (entity != null)
            {
                MessageBox.Show("Država uspješno uređena.");
            }
        }

        private async void frmUrediDrzavu_Load(object sender, EventArgs e)
        {
            await UcitajDetalje();
        }

        private async Task UcitajDetalje()
        {
            var Drzava = await _serviceDrzave.GetById<Model.Drzava>(_id);

            txtNaziv.Text = Drzava.Naziv;

            var request = new Model.Requests.GradSearchRequest
            {
                DrzavaId = _id

            };

            var listGradovi = await _serviceGradovi.Get<List<Model.Grad>>(request);
            dgvGradovi.AutoGenerateColumns = false;
            dgvGradovi.DataSource = listGradovi;
        }

        private async void btnDodajGrad_Click(object sender, EventArgs e)
        {
            var frm = new frmGradDetalji(0, _id);
            if (frm.ShowDialog() == DialogResult.OK)
                await UcitajDetalje();
        }

        private async void dgvGradovi_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = int.Parse(dgvGradovi.SelectedRows[0].Cells[0].Value.ToString());

            var Grad = await _serviceGradovi.GetById<Model.Grad>(id);

            var frm = new frmGradDetalji(id, Grad.DrzavaId);
            if (frm.ShowDialog() == DialogResult.OK)
                await UcitajDetalje();
        }
    }
}
