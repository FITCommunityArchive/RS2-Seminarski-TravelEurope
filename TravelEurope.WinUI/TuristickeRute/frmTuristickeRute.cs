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

namespace TravelEurope.WinUI.TuristickeRute
{
    public partial class frmTuristickeRute : Form
    {
        private readonly APIService _serviceTuristRuta = new APIService("TuristRuta");

        public frmTuristickeRute()
        {
            InitializeComponent();
        }

        private async void btnPretraga_Click(object sender, EventArgs e)
        {
            await UcitajFormu();
        }

        private async Task UcitajFormu()
        {
            var request = new Model.Requests.TuristickeRuteSearchRequest
            {
                Naziv = txtNazivRute.Text
            };

            List<Model.TuristRuta> lista = await _serviceTuristRuta.Get<List<Model.TuristRuta>>(request);

            dgvTuristRuta.AutoGenerateColumns = false;
            dgvTuristRuta.DataSource = lista;
        }

        private async void frmTuristRuta_Load(object sender, EventArgs e)
        {
            await UcitajFormu();
        }

        private async void btnDodajRutu_Click(object sender, EventArgs e)
        {

            var frm = new frmTuristickeRuteDodaj();
            if (frm.ShowDialog() == DialogResult.OK)
                await UcitajFormu();
        }

        private async void dgvTuristRuta_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = int.Parse(dgvTuristRuta.SelectedRows[0].Cells[0].Value.ToString());

            var frm = new frmTuristickeRuteDetalji(id);
            frm.ShowDialog();
            await UcitajFormu();
        }
    }
}
