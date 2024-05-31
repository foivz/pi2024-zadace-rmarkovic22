using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyDocDesktopApp
{
    public partial class FrmLogin : Form
    {
        string usernameKorisnik = "korisnik";
        string passwordKorisnik = "korisnik";
        string usernameLijecnik = "lijecnik";
        string passwordLijecnik = "lijecnik";

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                MessageBox.Show("Korisnicko ime nije uneseno!", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(txtUsername.Text == "")
            {
                MessageBox.Show("Lozinka nije unesena!", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (txtUsername.Text == usernameKorisnik && txtPassword.Text == passwordKorisnik)
                {
                    FrmNacin frmNacin = new FrmNacin();
                    Hide();
                    frmNacin.ShowDialog();
                    Close();
                }
                if(txtUsername.Text == usernameLijecnik && txtPassword.Text == passwordLijecnik)
                {
                    dgvPacijenti dgvPacijenti = new dgvPacijenti();
                    Hide();
                    dgvPacijenti.ShowDialog();
                    Close();
                }
                else
                {
                    MessageBox.Show("Krivi podaci!", "Problem", MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            
            
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
        
        }
        private void TxtUsername_TextChanged(object sender, EventArgs e)
        { 
        }
    }
}
