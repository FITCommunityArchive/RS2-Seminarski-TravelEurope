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

namespace TravelEurope.WinUI.Korisnici
{
    public partial class frmKorisniciDetalji : Form
    {
        private readonly APIService _serviceKorisnici = new APIService("Korisnici");
        private readonly APIService _serviceUloge = new APIService("Uloge");
        private readonly APIService _serviceDrzave = new APIService("Drzave");
        private readonly APIService _serviceGradovi = new APIService("Gradovi");

        private int _id;

        public frmKorisniciDetalji(int id = 0)
        {
            _id = id;
            InitializeComponent();
        }

        private async void btnSnimi_Click(object sender, EventArgs e)
        {
            var request = new Model.Requests.KorisniciInsertRequest
            {
                Ime = txtIme.Text,
                Prezime = txtPrezime.Text,
                UserName = txtKorisnickoIme.Text,
                Email = txtEmail.Text,
                Password = txtLozinka.Text,
                PasswordConfirmation = txtLozinkaPotvrda.Text,
                GradId = (cmbGradovi.SelectedItem as Model.Grad).GradId,
            };

            if (_id == 0)
            {
                Model.Korisnici entity = await _serviceKorisnici.Insert<Model.Korisnici>(request);
                if (entity != null)
                {
                    MessageBox.Show("Korisnik uspješno dodan.");
                    DialogResult = DialogResult.OK;
                    Close();
                }
            }
            else
            {
                Model.Korisnici entity = await _serviceKorisnici.Update<Model.Korisnici>(_id, request);
                if (entity != null)
                {
                    MessageBox.Show("Korisnik uspješno izmijenjen.");
                    DialogResult = DialogResult.OK;
                    Close();
                }
            }
        }

        private async void frmKorisniciDetalji_Load(object sender, EventArgs e)
        {
            var listDrzave = await _serviceDrzave.Get<List<Model.Drzava>>(null);

            cmbDrzave.DataSource = listDrzave;

            await RefreshGradovi();

            if (_id != 0)
                await UcitajDetaljeAsync();
        }

        private async Task UcitajDetaljeAsync()
        {
            var korisnik = await _serviceKorisnici.GetById<Model.Korisnici>(_id);

            txtIme.Text = korisnik.Ime;
            txtPrezime.Text = korisnik.Prezime;
            txtEmail.Text = korisnik.Email;
            txtKorisnickoIme.Text = korisnik.UserName;

            foreach (Model.Drzava item in cmbDrzave.Items)
            {
                if (item.DrzavaId == korisnik.Grad.DrzavaId)
                    cmbDrzave.SelectedItem = item;
            }
            await RefreshGradovi();
            foreach (Model.Grad item in cmbGradovi.Items)
            {
                if (item.GradId == korisnik.GradId)
                    cmbGradovi.SelectedItem = item;

            }
        }

        private async Task RefreshGradovi()
        {
            Model.Drzava Drzava = cmbDrzave.SelectedItem as Model.Drzava;
            if (Drzava == null)
                return;

            var request = new GradSearchRequest
            {
                DrzavaId = Drzava.DrzavaId
            };

            var listGradovi = await _serviceGradovi.Get<List<Model.Grad>>(request);
            cmbGradovi.DataSource = listGradovi;
        }

        private async void cmbDrzave_SelectedIndexChanged(object sender, EventArgs e)
        {
            await RefreshGradovi();
        }
    }
}
