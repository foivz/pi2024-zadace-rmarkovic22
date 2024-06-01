using DBLayer;
using MyDocDesktopApp.models;
using MyDocDesktopApp.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyDocDesktopApp
{
    public partial class FrmAzuriraj : Form
    {
        private Pacijent pacijent;

        public Pacijent SelectedPacijent { get => pacijent; set => pacijent = value; }
        public FrmAzuriraj(Pacijent selectedPacijent)
        {
            InitializeComponent();
            SelectedPacijent = selectedPacijent;
        }

        private void FrmAzuriraj_Load(object sender, EventArgs e)
        {
            SetFormText();

            var id = PacijentiRepository.GetPacijenti();
            comboBox1.DataSource = id;
            comboBox1.DisplayMember = "Ime"; 
            comboBox1.ValueMember = "Id"; 

        }

        private void SetFormText()
        {
            Text = SelectedPacijent.Id + " " + SelectedPacijent.Ime;
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            Pacijent selectedPacijent = comboBox1.SelectedItem as Pacijent; ;
            string email = txtEmail.Text;
            string kontakt = txtKontakt.Text;

            PacijentiRepository.UpdatePacijent(selectedPacijent.Id, selectedPacijent.Ime, selectedPacijent.Prezime, email, kontakt);
            MessageBox.Show("Pacijent je uspješno ažuriran", "Uspješno ažuriranje");
            Close();
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtKontakt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
