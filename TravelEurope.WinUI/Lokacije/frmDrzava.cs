using Flurl.Http;
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
    public partial class frmDrzava : Form
    {
        private readonly APIService _serviceDrzava = new APIService("Drzava");

        public frmDrzava()
        {
            InitializeComponent();
        }

        private async void btnPretraga_Click(object sender, EventArgs e)
        {
            await UcitajFormu();
        }

        private async Task UcitajFormu()
        {
            var request = new Model.Requests.DrzavaSearchRequest
            {
                Naziv = txtNazivDrzava.Text
            };

            List<Model.Drzava> lista = await _serviceDrzava.Get<List<Model.Drzava>>(request);

            dgvDrzava.AutoGenerateColumns = false;
            dgvDrzava.DataSource = lista;
        }

        private async void frmDrzava_Load(object sender, EventArgs e)
        {
            await UcitajFormu();
        }

        private async void dgvDrzava_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = int.Parse(dgvDrzava.SelectedRows[0].Cells[0].Value.ToString());

            var frm = new frmUrediDrzavu(id);
            frm.ShowDialog();
            await UcitajFormu();
        }

        private async void btnDodajDrzavu_Click(object sender, EventArgs e)
        {

            var frm = new frmDodajDrzavu();
            if (frm.ShowDialog() == DialogResult.OK)
                await UcitajFormu();
        }
    }
}
