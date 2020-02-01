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

namespace TravelEurope.WinUI.TuristickeRute
{
    public partial class frmTuristickeRuteDodaj : Form
    {
        private readonly APIService _serviceTuristRuta = new APIService("TuristRuta");
        private readonly APIService _serviceDrzava = new APIService("Drzava");
        private readonly APIService _serviceVodici = new APIService("TuristickiVodic");
        private readonly APIService _serviceRuteSlike = new APIService("RuteSlike");

        private int _id;

        public frmTuristickeRuteDodaj(int id = 0)
        {
            _id = id;
            InitializeComponent();
        }

        private async void btnSnimi_Click(object sender, EventArgs e)
        {
            var request = new Model.Requests.TuristickeRuteInsertRequest
            {
                Naziv = txtNaziv.Text,
                Opis = txtOpis.Text,
                DrzavaId = (cmbDrzave.SelectedItem as Model.Drzava).DrzavaId,
                TuristickiVodicId = (cmbVodici.SelectedItem as Model.TuristickiVodic).TuristickiVodicId,
            };

            if (_id == 0)
            {
                Model.TuristRuta entity = await _serviceTuristRuta.Insert<Model.TuristRuta>(request);
                if (entity != null)
                {
                    MessageBox.Show("Turist ruta uspješno dodana.");
                    DialogResult = DialogResult.OK;
                    Close();
                }
            }
            else
            {
                Model.TuristRuta entity = await _serviceTuristRuta.Update<Model.TuristRuta>(_id, request);
                if (entity != null)
                {
                    MessageBox.Show("Turist ruta uspješno izmijenjena.");
                    DialogResult = DialogResult.OK;
                    Close();
                }
            }
        }

        private async void frmTuristickeRuteDodaj_Load(object sender, EventArgs e)
        {
            var listDrzave = await _serviceDrzava.Get<List<Model.Drzava>>(null);
            var listVodici = await _serviceVodici.Get<List<Model.TuristickiVodic>>(null);

            cmbDrzave.DataSource = listDrzave;
            cmbVodici.DataSource = listVodici;

            cmbDrzave.DisplayMember = "Naziv";
            cmbVodici.DisplayMember = "ip";

            if (_id != 0)
                await UcitajDetaljeAsync();
        }

        private async Task UcitajDetaljeAsync()
        {
            var tr = await _serviceTuristRuta.GetById<Model.TuristRuta>(_id);

            txtNaziv.Text = tr.Naziv;
            txtOpis.Text = tr.Opis;
            cmbDrzave.Text = tr.Drzava.Naziv;
            cmbVodici.Text = tr.TuristickiVodic.Ime;


            foreach (Model.Drzava item in cmbDrzave.Items)
            {
                if (item.DrzavaId == tr.DrzavaId)
                    cmbDrzave.SelectedItem = item;
            }
            foreach (Model.TuristickiVodic item in cmbVodici.Items)
            {
                if (item.TuristickiVodicId == tr.TuristickiVodicId)
                    cmbVodici.SelectedItem = item;
            }
        }

        private async void btnDodajVodica_Click(object sender, EventArgs e)
        {
            var frm = new TuristickiVodici.frmTuristickiVodiciDetalji();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                var listVodici = await _serviceVodici.Get<List<Model.TuristickiVodic>>(null);
                cmbVodici.DataSource = listVodici;
            }
        }

        private async void btnDodajDrzavu_Click(object sender, EventArgs e)
        {
            var frm = new Lokacije.frmDodajDrzavu();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                var listDrzave = await _serviceVodici.Get<List<Model.Drzava>>(null);
                cmbDrzave.DataSource = listDrzave;
            }
        }
    }
}
