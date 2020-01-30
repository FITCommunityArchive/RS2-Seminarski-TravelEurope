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

namespace TravelEurope.WinUI.Vozaci
{
    public partial class frmVozacDetalji : Form
    {
        private readonly APIService _serviceVozac = new APIService("Vozac");
        private readonly APIService _serviceMarka = new APIService("MarkaVozac");
        private readonly APIService _serviceTip = new APIService("TipVozac");
        private readonly APIService _serviceGorivo = new APIService("VrstaGoriva");
        private readonly APIService _serviceSVozac = new APIService("StatusVozaca");
        


        private int _id;

        public frmVozacDetalji(int id = 0)
        {
            _id = id;
            InitializeComponent();
        }

        private async void btnSnimi_Click(object sender, EventArgs e)
        {
            var request = new Model.Requests.VozacInsertRequest
            {
                Ime = txtIme.Text,
                Prezime = txtPrezime.Text,
                BrVozackeDozvole = Convert.ToInt32(txtVD.Text),
                StatusVozacaId = (cmbStatus.SelectedItem as Model.StatusVozaca).StatusVozacaId
            };

            if (_id == 0)
            {
                Model.Vozac entity = await _serviceVozac.Insert<Model.Vozac>(request);
                if (entity != null)
                {
                    MessageBox.Show("Vozač uspješno dodan.");
                    DialogResult = DialogResult.OK;
                    Close();
                }
            }
            //else
            //{
            //    Model.Korisnici entity = await _serviceVozac.Update<Model.Vozac>(_id, request);
            //    if (entity != null)
            //    {
            //        MessageBox.Show("Vozac ruta uspješno izmijenjeno.");
            //        DialogResult = DialogResult.OK;
            //        Close();
            //    }
            //}
        }

        private async void frmVozaciDetalji_Load(object sender, EventArgs e)
        {
            var lisStVozac = await _serviceSVozac.Get<List<Model.StatusVozaca>>(null);

            cmbStatus.DataSource = lisStVozac;
            cmbStatus.DisplayMember = "Status";

            if (_id != 0)
                await UcitajDetaljeAsync();
        }

        private async Task UcitajDetaljeAsync()
        {
            var v = await _serviceVozac.GetById<Model.Vozac>(_id);

            txtIme.Text = v.Ime;
            txtPrezime.Text = v.Prezime;
            txtVD.Text = v.BrVozackeDozvole;

            foreach (Model.StatusVozaca item in cmbStatus.Items)
            {
                if (item.StatusVozacaId == v.StatusVozacaId)
                    cmbStatus.SelectedItem = item;
            }
        }
    }
}
