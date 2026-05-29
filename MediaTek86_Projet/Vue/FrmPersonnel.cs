using MediaTek86_Projet.Modele;
using MediaTek86_Projet.Controleur;
using System;
using System.Windows.Forms;

namespace MediaTek86_Projet.Vue
{
    /// <summary>
    /// Gestion du personnel
    /// </summary>
    public partial class FrmPersonnel : Form
    {
        private Personnel personnel;

        /// <summary>
        /// Initialise la fenêtre
        /// </summary>
        public FrmPersonnel()
        {
            InitializeComponent();
            RemplirCboService();
        }

        /// <summary>
        /// Modification d'un personnel
        /// </summary>
        public FrmPersonnel(Personnel personnel)
        {
            InitializeComponent();
            RemplirCboService();

            this.personnel = personnel;

            txtNom.Text = personnel.Nom;
            txtPrenom.Text = personnel.Prenom;
            txtTel.Text = personnel.Tel;
            txtMail.Text = personnel.Mail;
            cboService.SelectedValue = personnel.Idservice;
        }

        /// <summary>
        /// Charge les services
        /// </summary>
        private void RemplirCboService()
        {
            ControlePersonnel controlePersonnel = new ControlePersonnel();

            cboService.DataSource = controlePersonnel.GetLesServices();
            cboService.DisplayMember = "Nom";
            cboService.ValueMember = "Idservice";
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            string nom = txtNom.Text.Trim();
            string prenom = txtPrenom.Text.Trim();
            string tel = txtTel.Text.Trim();
            string mail = txtMail.Text.Trim();

            if (nom == "" || prenom == "" || tel == "" || mail == "" || cboService.SelectedItem == null)
            {
                MessageBox.Show("Saisie incomplète");
                return;
            }

            Service service = (Service)cboService.SelectedItem;
            ControlePersonnel controlePersonnel = new ControlePersonnel();

            if (this.personnel == null)
            {
                Personnel nouveauPersonnel = new Personnel(0, nom, prenom, tel, mail, service.Idservice);
                controlePersonnel.AjouterPersonnel(nouveauPersonnel);
            }
            else
            {
                Personnel personnelModifie = new Personnel(this.personnel.Idpersonnel, nom, prenom, tel, mail, service.Idservice);
                controlePersonnel.ModifierPersonnel(personnelModifie);
            }

            this.Close();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
