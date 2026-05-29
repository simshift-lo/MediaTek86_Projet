using MediaTek86_Projet.Controleur;
using MediaTek86_Projet.Modele;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MediaTek86_Projet.Vue
{
    /// <summary>
    /// Fenêtre d'accueil
    /// </summary>
    public partial class FrmAccueil : Form
    {
        /// <summary>
        /// Initialise la fenêtre
        /// </summary>
        public FrmAccueil()
        {
            InitializeComponent();
            RemplirDgvPersonnel();
        }

        /// <summary>
        /// Liste du personnel
        /// </summary>
        private void RemplirDgvPersonnel()
        {
            ControlePersonnel controlePersonnel = new ControlePersonnel();
            List<Personnel> lesPersonnels = controlePersonnel.GetLesPersonnels();

            dgvPersonnel.Rows.Clear();
            dgvPersonnel.AllowUserToAddRows = false;

            foreach (Personnel personnel in lesPersonnels)
            {
                int ligne = dgvPersonnel.Rows.Add(
                    personnel.Nom,
                    personnel.Prenom,
                    personnel.Tel,
                    personnel.Mail
                );

                dgvPersonnel.Rows[ligne].Tag = personnel;
            }
        }

        /// <summary>
        /// Affiche les absences
        /// </summary>
        private void btnAbsences_Click(object sender, EventArgs e)
        {
            if (dgvPersonnel.CurrentRow == null)
            {
                MessageBox.Show("Aucun personnel sélectionné");
                return;
            }

            Personnel personnel = (Personnel)dgvPersonnel.CurrentRow.Tag;

            FrmAbsences frmAbsences = new FrmAbsences(personnel);
            frmAbsences.ShowDialog();
        }

        private void dgvPersonnel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAjouterPersonnel_Click(object sender, EventArgs e)
        {
            FrmPersonnel frmPersonnel = new FrmPersonnel();
            frmPersonnel.ShowDialog();

            RemplirDgvPersonnel();
        }

        private void btnModifierPersonnel_Click(object sender, EventArgs e)
        {
            if (dgvPersonnel.CurrentRow == null)
            {
                MessageBox.Show("Aucun personnel sélectionné");
                return;
            }

            Personnel personnel = (Personnel)dgvPersonnel.CurrentRow.Tag;

            FrmPersonnel frmPersonnel = new FrmPersonnel(personnel);
            frmPersonnel.ShowDialog();

            RemplirDgvPersonnel();
        }

        private void btnSupprimerPersonnel_Click(object sender, EventArgs e)
        {
            if (dgvPersonnel.CurrentRow == null)
            {
                MessageBox.Show("Aucun personnel sélectionné");
                return;
            }

            Personnel personnel = (Personnel)dgvPersonnel.CurrentRow.Tag;

            DialogResult reponse = MessageBox.Show("Supprimer ce personnel ?", "Suppression", MessageBoxButtons.YesNo);

            if (reponse == DialogResult.Yes)
            {
                ControlePersonnel controlePersonnel = new ControlePersonnel();
                controlePersonnel.SupprimerPersonnel(personnel);

                RemplirDgvPersonnel();
            }
        }

        private void lblTitre_Click(object sender, EventArgs e)
        {

        }
    }
}
