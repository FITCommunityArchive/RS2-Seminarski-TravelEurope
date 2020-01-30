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

namespace TravelEurope.WinUI.Vozilo
{
    public partial class frmVozilaDetalji : Form
    {
        private readonly APIService _serviceVozila = new APIService("Vozilo");
        private readonly APIService _serviceMarka = new APIService("MarkaVozila");
        private readonly APIService _serviceTip = new APIService("TipVozila");
        private readonly APIService _serviceGorivo = new APIService("VrstaGoriva");
        private readonly APIService _serviceSVozila = new APIService("StatusVozila");


        private int _id;

        public frmVozilaDetalji(int id = 0)
        {
            _id = id;
            InitializeComponent();
        }

        private async void btnSnimi_Click(object sender, EventArgs e)
        {
            var request = new Model.Requests.VoziloInsertRequest
            {
                Naziv = txtNaziv.Text,
                TipVozilaId = (cmbTip.SelectedItem as Model.TipVozila).TipId,
                GodinaProizvodnje = int.Parse(cmbGodProizv.Items[cmbGodProizv.SelectedIndex].ToString()),
                MarkaVozilaId = (cmbMarka.SelectedItem as Model.MarkaVozila).MarkaId,
                StatusVozilaId = (cmbStatus.SelectedItem as Model.StatusVozila).StatusVozilaId,
                VrstaGorivaId = (cmbGorivo.SelectedItem as Model.VrstaGoriva).GorivoId,
                BrojSjedista = int.Parse(cmbSjediste.Items[cmbSjediste.SelectedIndex].ToString()),
                BrojVrata = int.Parse(cmbVrata.Items[cmbVrata.SelectedIndex].ToString()),
                Boja = txtBoja.Text
            };

            if (_id == 0)
            {
                Model.Vozilo entity = await _serviceVozila.Insert<Model.Vozilo>(request);
                if (entity != null)
                {
                    MessageBox.Show("Vozilo uspješno dodano.");
                    DialogResult = DialogResult.OK;
                    Close();
                }
            }
            //else
            //{
            //    Model.Korisnici entity = await _serviceVozila.Update<Model.Vozilo>(_id, request);
            //    if (entity != null)
            //    {
            //        MessageBox.Show("Vozilo ruta uspješno izmijenjeno.");
            //        DialogResult = DialogResult.OK;
            //        Close();
            //    }
            //}
        }

        private async void frmTuristickeRuteDetalji_Load(object sender, EventArgs e)
        {

            var listtipVozila = await _serviceTip.Get<List<Model.TipVozila>>(null);

            var listmarkaVozila = await _serviceMarka.Get<List<Model.MarkaVozila>>(null);

            var listVrGoriva = await _serviceGorivo.Get<List<Model.VrstaGoriva>>(null);

            var lisStVozila = await _serviceSVozila.Get<List<Model.StatusVozila>>(null);

            cmbTip.DataSource = listtipVozila;
            cmbTip.DisplayMember = "Naziv";

            cmbMarka.DataSource = listmarkaVozila;
            cmbMarka.DisplayMember = "Naziv";

            cmbGorivo.DataSource = listVrGoriva;
            cmbGorivo.DisplayMember = "Naziv";

            cmbStatus.DataSource = lisStVozila;
            cmbStatus.DisplayMember = "Status";

            var listSjedista = new List<int> { 12, 13, 14, 15 };
            var listVrata = new List<int> { 2, 4, 5, 8 };
            var godinaProizvodnje = new List<int> { 2015, 2016, 2017, 2018, 2019, 2020 };

            cmbSjediste.DataSource = listSjedista;
            cmbVrata.DataSource = listVrata;
            cmbGodProizv.DataSource = godinaProizvodnje;

            if (_id != 0)
                await UcitajDetaljeAsync();
        }

        private async Task UcitajDetaljeAsync()
        {
            var v = await _serviceVozila.GetById<Model.Vozilo>(_id);

            txtNaziv.Text = v.Naziv;
            txtBoja.Text = v.Boja;

            foreach (Model.TipVozila item in cmbTip.Items)
            {
                if (item.TipId == v.TipVozilaId)
                    cmbTip.SelectedItem = item;
            }
            foreach (Model.StatusVozila item in cmbStatus.Items)
            {
                if (item.StatusVozilaId == v.StatusVozilaId)
                    cmbStatus.SelectedItem = item;
            }
            foreach (Model.VrstaGoriva item in cmbGorivo.Items)
            {
                if (item.GorivoId == v.VrstaGorivaId)
                    cmbGorivo.SelectedItem = item;
            }
            foreach (Model.MarkaVozila item in cmbMarka.Items)
            {
                if (item.MarkaId == v.MarkaVozilaId)
                    cmbMarka.SelectedItem = item;
            }
        }
    }
}
