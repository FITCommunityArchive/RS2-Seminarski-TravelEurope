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
    public partial class frmTuristickeRuteDetalji : Form
    {
        private readonly APIService _serviceTuristRuta = new APIService("TuristRuta");
        private readonly APIService _serviceDrzava = new APIService("Drzava");
        private readonly APIService _serviceVodici = new APIService("TuristickiVodic");

        private int _id;

        public frmTuristickeRuteDetalji(int id = 0)
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
                Model.TuristickiVodic entity = await _serviceTuristRuta.Insert<Model.TuristickiVodic>(request);
                if (entity != null)
                {
                    MessageBox.Show("Turist ruta uspješno dodana.");
                    DialogResult = DialogResult.OK;
                    Close();
                }
            }
            //else
            //{
            //    Model.Korisnici entity = await _serviceTuristRuta.Update<Model.TuristRuta>(_id, request);
            //    if (entity != null)
            //    {
            //        MessageBox.Show("Turist ruta uspješno izmijenjena.");
            //        DialogResult = DialogResult.OK;
            //        Close();
            //    }
            //}
        }

        private async void frmTuristickeRuteDetalji_Load(object sender, EventArgs e)
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
    }
}
