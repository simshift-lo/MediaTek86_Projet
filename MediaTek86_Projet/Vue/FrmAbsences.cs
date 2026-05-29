using MediaTek86_Projet.Modele;
using System;
using System.Windows.Forms;
using MediaTek86_Projet.Controleur;

namespace MediaTek86_Projet.Vue
{
    /// <summary>
    /// Liste des absences
    /// </summary>
    public partial class FrmAbsences : Form
    {
        private Personnel personnel;

        /// <summary>
        /// Initialise la fenêtre
        /// </summary>
        public FrmAbsences()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Absences du personnel
        /// </summary>
        public FrmAbsences(Personnel personnel)
        {
            InitializeComponent();
            this.personnel = personnel;
            RemplirDgvAbsences();
        }

        /// <summary>
        /// Affiche les absences du personnel
        /// </summary>
        private void RemplirDgvAbsences()
        {
            ControleAbsence controleAbsence = new ControleAbsence();

            dgvAbsences.Rows.Clear();
            dgvAbsences.AllowUserToAddRows = false;

            foreach (Absence absence in controleAbsence.GetLesAbsences(personnel.Idpersonnel))
            {
                int ligne = dgvAbsences.Rows.Add(
                    absence.Datedebut.ToShortDateString(),
                    absence.Datefin.ToShortDateString(),
                    absence.Idmotif
                );

                dgvAbsences.Rows[ligne].Tag = absence;
            }
        }

        private void dgvAbsences_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAjouterAbsence_Click(object sender, EventArgs e)
        {
            FrmAbsence frmAbsence = new FrmAbsence(personnel);
            frmAbsence.ShowDialog();

            RemplirDgvAbsences();
        }

        private void btnModifierAbsence_Click(object sender, EventArgs e)
        {
            if (dgvAbsences.CurrentRow == null)
            {
                MessageBox.Show("Aucune absence sélectionnée");
                return;
            }

            Absence absence = (Absence)dgvAbsences.CurrentRow.Tag;

            FrmAbsence frmAbsence = new FrmAbsence(personnel, absence);
            frmAbsence.ShowDialog();

            RemplirDgvAbsences();
        }

        private void btnSupprimerAbsence_Click(object sender, EventArgs e)
        {
            if (dgvAbsences.CurrentRow == null)
            {
                MessageBox.Show("Aucune absence sélectionnée");
                return;
            }

            Absence absence = (Absence)dgvAbsences.CurrentRow.Tag;

            DialogResult reponse = MessageBox.Show("Supprimer cette absence ?", "Suppression", MessageBoxButtons.YesNo);

            if (reponse == DialogResult.Yes)
            {
                ControleAbsence controleAbsence = new ControleAbsence();
                controleAbsence.SupprimerAbsence(absence);

                RemplirDgvAbsences();
            }
        }
    }
}
