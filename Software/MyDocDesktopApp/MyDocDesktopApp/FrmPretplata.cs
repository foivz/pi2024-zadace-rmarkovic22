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
    public partial class FrmPretplata : Form
    {
        public FrmPretplata()
        {
            InitializeComponent();
        }

        private void btnBasic_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Čestitamo! Uspješno ste odabrali Health Basic tarifu pretplate.", "Odabrali ste tarifu pretplate", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAdvance_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Čestitamo! Uspješno ste odabrali Health Advance tarifu pretplate.", "Odabrali ste tarifu pretplate", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnPremium_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Čestitamo! Uspješno ste odabrali Health Premium tarifu pretplate.", "Odabrali ste tarifu pretplate", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
