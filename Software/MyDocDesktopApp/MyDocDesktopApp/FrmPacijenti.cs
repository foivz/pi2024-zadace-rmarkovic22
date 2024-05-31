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
    public partial class FrmPacijenti : Form
    {
        public FrmPacijenti()
        {
            InitializeComponent();
        }

        private void dgvPacijenti_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void FrmPacijenti_Load(object sender, EventArgs e)
        {
            ShowPacijenti();
        }
        private void ShowPacijenti()
        {
            List<Pacijent> pacijenti = PacijentiRepository.GetPacijenti();
            dgvPacijenti.DataSource = pacijenti;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            FrmDodaj frmDodaj = new FrmDodaj();
            Hide();
            frmDodaj.ShowDialog();
            Close();
        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {

        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            string sql = $"DELETE FROM Pacijenti WHERE Id = {id}";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
            MessageBox.Show("Pacijent uspješno obrisan!", "Obrisan pacijent");
            Close();
        }
    }
}
