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
        private readonly APIService _serviceTuristRute = new APIService("TuristRute");
        private readonly APIService _serviceDrzave = new APIService("Drzave");
        private readonly APIService _serviceVodici = new APIService("TuristickiVodici");
        private readonly APIService _serviceRuteSlike = new APIService("RuteSlike");

        private int _id;

        public frmTuristickeRuteDetalji(int id = 0)
        {
            _id = id;
            InitializeComponent();
        }

        private async void btnSnimi_Click(object sender, EventArgs e)
        {
            var request = new Model.Requests.TuristRuteInsertRequest
            {
                Naziv = txtNaziv.Text,
                Opis = txtOpis.Text,
                DrzavaId = (cmbDrzave.SelectedItem as Model.Drzave).DrzavaId,
                TuristickiVodicId = (cmbVodici.SelectedItem as Model.TuristickiVodici).TuristickiVodicId,
            };

            if (_id == 0)
            {
                Model.TuristRute entity = await _serviceTuristRute.Insert<Model.TuristRute>(request);
                if (entity != null)
                {
                    MessageBox.Show("Turist ruta uspješno dodana.");
                    DialogResult = DialogResult.OK;
                    Close();
                }
            }
            else
            {
                Model.TuristRute entity = await _serviceTuristRute.Update<Model.TuristRute>(_id, request);
                if (entity != null)
                {
                    MessageBox.Show("Turist ruta uspješno izmijenjena.");
                    DialogResult = DialogResult.OK;
                    Close();
                }
            }
        }

        private async void frmTuristickeRuteDetalji_Load(object sender, EventArgs e)
        {
            var listDrzave = await _serviceDrzave.Get<List<Model.Drzave>>(null);
            var listVodici = await _serviceVodici.Get<List<Model.TuristickiVodici>>(null);

            cmbDrzave.DataSource = listDrzave;
            cmbVodici.DataSource = listVodici;

            cmbDrzave.DisplayMember = "Naziv";
            cmbVodici.DisplayMember = "ip";

            await UcitajListuSlika();

            if (_id != 0)
                await UcitajDetaljeAsync();
        }

        private async Task UcitajDetaljeAsync()
        {
            var tr = await _serviceTuristRute.GetById<Model.TuristRute>(_id);

            txtNaziv.Text = tr.Naziv;
            txtOpis.Text = tr.Opis;
            //cmbDrzave.Text = tr.Drzava.Naziv;
            //cmbVodici.Text = tr.TuristickiVodic.Ime;
            

            //foreach (Model.Drzave item in cmbDrzave.Items)
            //{
            //    if (item.DrzavaId == tr.DrzavaId)
            //        cmbDrzave.SelectedItem = item;
            //}
            foreach (Model.TuristickiVodici item in cmbVodici.Items)
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
                var listVodici = await _serviceVodici.Get<List<Model.TuristickiVodici>>(null);
                cmbVodici.DataSource = listVodici;
            }
        }

        private async void btnDodajDrzavu_Click(object sender, EventArgs e)
        {
            var frm = new Lokacije.frmDodajDrzavu();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                var listDrzave = await _serviceDrzave.Get<List<Model.Drzave>>(null);
                cmbDrzave.DataSource = listDrzave;
            }
        }

        private async Task UcitajListuSlika()
        {
            var requestRuteSlike = new Model.Requests.RuteSlikeSearchRequest
            {
                TuristRutaId = _id
            };
            var listRuteSlike = await _serviceRuteSlike.Get<List<Model.RuteSlike>>(requestRuteSlike);
            dgvSlike.AutoGenerateColumns = false;
            dgvSlike.DataSource = listRuteSlike;
        }

        private async void btnDodajSliku_Click(object sender, EventArgs e)
        {
            var frm = new frmTuristickeRuteDetaljiSlike(0, _id);
            if (frm.ShowDialog() == DialogResult.OK)
                await UcitajListuSlika();
        }

        private async void dgvSlike_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = int.Parse(dgvSlike.SelectedRows[0].Cells[0].Value.ToString());

            var frm = new frmTuristickeRuteDetaljiSlike(id, _id);
            if (frm.ShowDialog() == DialogResult.OK)
                await UcitajListuSlika();
        }

        private async void btnIzbrisiSliku_Click(object sender, EventArgs e)
        {
            var RuteSlikeId = int.Parse(dgvSlike.SelectedRows[0].Cells[0].Value.ToString());

            var success = await _serviceRuteSlike.Remove(RuteSlikeId);
            if (success)
            {
                MessageBox.Show("Slika je izbrisana.");
                await UcitajListuSlika();
            }
        }

        private void dgvSlike_SelectionChanged(object sender, EventArgs e)
        {
            var rowsCount = dgvSlike.SelectedRows.Count;
            if (rowsCount == 0)
                btnIzbrisiSliku.Enabled = false;
            else
                btnIzbrisiSliku.Enabled = true;
        }

        private async Task button2_ClickAsync(object sender, EventArgs e)
        {
            var id = int.Parse(dgvSlike.SelectedRows[0].Cells[0].Value.ToString());

            var success = await _serviceRuteSlike.Remove(id);
            if (success)
            {
                MessageBox.Show("Slika je izbrisana.");
                await UcitajListuSlika();
            }
        }
    }
}
