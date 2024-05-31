using DBLayer;
using MyDocDesktopApp.models;
using MyDocDesktopApp.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace MyDocDesktopApp
{
    public partial class FrmDodaj : Form
    {
        public FrmDodaj()
        {
            InitializeComponent();
        }

        private void FrmDodaj_Load(object sender, EventArgs e)
        {
            
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {

            var ime = txtIme.Text;
            var prezime = txtPrezime.Text;
            var email = txtEmail.Text;
            var kontakt = txtKontakt.Text;

            PacijentiRepository.InsertPacijent(ime, prezime, email, kontakt);
            MessageBox.Show("Pacijent je uspješno dodan!");
            Close();
        }
    }
}
