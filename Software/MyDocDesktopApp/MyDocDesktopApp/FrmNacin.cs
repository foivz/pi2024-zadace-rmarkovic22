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
    public partial class FrmNacin : Form
    {
        public FrmNacin()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnIndividualno_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Čestitamo! Odabrali ste individualni način korištenja.", "Odabrali ste način korištenja", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnPretplata_Click(object sender, EventArgs e)
        {
            FrmPretplata frmPretplata = new FrmPretplata();
            frmPretplata.ShowDialog();
        }
    }
}
