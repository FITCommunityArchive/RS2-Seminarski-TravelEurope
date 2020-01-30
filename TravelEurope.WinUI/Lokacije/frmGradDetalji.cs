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

namespace TravelEurope.WinUI.Lokacije
{
    public partial class frmGradDetalji : Form
    {
        private readonly APIService _serviceGradovi = new APIService("Grad");
        private int _gradID;
        private int _drzavaID;

        public frmGradDetalji(int gradID, int drzavaID)
        {
            _gradID = gradID;
            _drzavaID = drzavaID;
            InitializeComponent();
        }

        private async void btnSnimi_Click(object sender, EventArgs e)
        {
            var request = new Model.Requests.GradInsertRequest
            {
                Naziv = txtNaziv.Text,
                DrzavaId = _drzavaID
            };

            if (_gradID == 0)
            {
                Model.Grad entity = await _serviceGradovi.Insert<Model.Grad>(request);
                if (entity != null)
                {
                    MessageBox.Show("Grad uspješno dodan.");
                    DialogResult = DialogResult.OK;
                    Close();
                }
            }
            else
            {
                Model.Grad entity = await _serviceGradovi.Update<Model.Grad>(_gradID, request);
                if (entity != null)
                {
                    MessageBox.Show("Grad uspješno izmijenjen.");
                    DialogResult = DialogResult.OK;
                    Close();
                }
            }
        }

        private async void frmGradoviDetalji_Load(object sender, EventArgs e)
        {
            if (_gradID != 0)
            {
                await UcitajDetalje();
                this.Text = "Uredi grad";
            }
            else
            {
                this.Text = "Dodaj grad";

            }
        }

        private async Task UcitajDetalje()
        {
            var Grad = await _serviceGradovi.GetById<Model.Grad>(_gradID);

            txtNaziv.Text = Grad.Naziv;
        }
    }

}
