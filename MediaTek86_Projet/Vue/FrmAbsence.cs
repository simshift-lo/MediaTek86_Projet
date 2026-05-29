using MediaTek86_Projet.Controleur;
using MediaTek86_Projet.Modele;
using System;
using System.Windows.Forms;

namespace MediaTek86_Projet.Vue
{
    /// <summary>
    /// Fenêtre absence
    /// </summary>
    public partial class FrmAbsence : Form
    {
        private Personnel personnel;
        private Absence absence;

        /// <summary>
        /// Ajout d'une absence
        /// </summary>
        public FrmAbsence(Personnel personnel)
        {
            InitializeComponent();
            RemplirCboMotif();

            this.personnel = personnel;
        }

        /// <summary>
        /// Modification d'une absence
        /// </summary>
        public FrmAbsence(Personnel personnel, Absence absence)
        {
            InitializeComponent();
            RemplirCboMotif();

            this.personnel = personnel;
            this.absence = absence;

            dtpDebut.Value = absence.Datedebut;
            dtpFin.Value = absence.Datefin;
            cboMotif.SelectedValue = absence.Idmotif;
        }

        /// <summary>
        /// Liste des motifs
        /// </summary>
        private void RemplirCboMotif()
        {
            ControleAbsence controleAbsence = new ControleAbsence();

            cboMotif.DataSource = controleAbsence.GetLesMotifs();
            cboMotif.DisplayMember = "Libelle";
            cboMotif.ValueMember = "Idmotif";
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            if (personnel == null || cboMotif.SelectedItem == null)
            {
                MessageBox.Show("Saisie incomplète");
                return;
            }

            if (dtpFin.Value.Date < dtpDebut.Value.Date)
            {
                MessageBox.Show("Date incorrecte");
                return;
            }

            Motif motif = (Motif)cboMotif.SelectedItem;

            Absence absence = new Absence(
                personnel.Idpersonnel,
                dtpDebut.Value.Date,
                dtpFin.Value.Date,
                motif.Idmotif
            );

            ControleAbsence controleAbsence = new ControleAbsence();

            if (this.absence == null)
            {
                if (controleAbsence.AbsenceChevauche(absence))
                {
                    MessageBox.Show("Absence déjà existante sur cette période");
                    return;
                }

                controleAbsence.AjouterAbsence(absence);
            }
            else
            {
                if (controleAbsence.AbsenceChevaucheModification(this.absence, absence))
                {
                    MessageBox.Show("Absence déjà existante sur cette période");
                    return;
                }

                controleAbsence.ModifierAbsence(this.absence, absence);
            }

            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
