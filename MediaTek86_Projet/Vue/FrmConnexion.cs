using System;
using System.Windows.Forms;
using MediaTek86_Projet.Controleur;

namespace MediaTek86_Projet.Vue
{
    /// <summary>
    /// Fenêtre de connexion
    /// </summary>
    public partial class FrmConnexion : Form
    {
        /// <summary>
        /// Initialise la fenêtre
        /// </summary>
        public FrmConnexion()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Connexion de l'utilisateur
        /// </summary>
        private void btnConnexion_Click(object sender, EventArgs e)
        {
            string login = txtLogin.Text.Trim();
            string pwd = txtPwd.Text.Trim();

            if (login == "" || pwd == "")
            {
                MessageBox.Show("Veuillez renseigner le login et le mot de passe.");
                return;
            }

            ControleConnexion controle = new ControleConnexion();

            if (controle.ControleAuthentification(login, pwd))
            {
                FrmAccueil frmAccueil = new FrmAccueil();
                frmAccueil.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login ou mot de passe incorrect.");
            }
        }

        private void txtPwd_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
