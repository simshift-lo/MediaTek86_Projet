using MediaTek86_Projet.dal;
using MediaTek86_Projet.Modele;
using System;
using System.Collections.Generic;

namespace MediaTek86_Projet.Controleur
{
    /// <summary>
    /// Gestion des absences
    /// </summary>
    public class ControleAbsence
    {
        /// <summary>
        /// Liste des absences du personnel
        /// </summary>
        public List<Absence> GetLesAbsences(int idpersonnel)
        {
            string requete = "SELECT idpersonnel, datedebut, datefin, idmotif FROM absence WHERE idpersonnel = @idpersonnel ORDER BY datedebut;";

            Dictionary<string, object> parametres = new Dictionary<string, object>();
            parametres.Add("@idpersonnel", idpersonnel);

            List<object[]> resultats = Access.GetInstance().Manager.ReqSelect(requete, parametres);
            List<Absence> lesAbsences = new List<Absence>();

            foreach (object[] ligne in resultats)
            {
                Absence absence = new Absence(
                    Convert.ToInt32(ligne[0]),
                    Convert.ToDateTime(ligne[1]),
                    Convert.ToDateTime(ligne[2]),
                    Convert.ToInt32(ligne[3])
                );

                lesAbsences.Add(absence);
            }

            return lesAbsences;
        }

        /// <summary>
        /// Liste des motifs
        /// </summary>
        public List<Motif> GetLesMotifs()
        {
            string requete = "SELECT idmotif, libelle FROM motif ORDER BY libelle;";

            List<object[]> resultats = Access.GetInstance().Manager.ReqSelect(requete);
            List<Motif> lesMotifs = new List<Motif>();

            foreach (object[] ligne in resultats)
            {
                Motif motif = new Motif(
                    Convert.ToInt32(ligne[0]),
                    ligne[1].ToString()
                );

                lesMotifs.Add(motif);
            }

            return lesMotifs;
        }

        /// <summary>
        /// Ajout d'une absence
        /// </summary>
        public void AjouterAbsence(Absence absence)
        {
            string requete = "INSERT INTO absence (idpersonnel, datedebut, datefin, idmotif) VALUES (@idpersonnel, @datedebut, @datefin, @idmotif);";

            Dictionary<string, object> parametres = new Dictionary<string, object>();
            parametres.Add("@idpersonnel", absence.Idpersonnel);
            parametres.Add("@datedebut", absence.Datedebut);
            parametres.Add("@datefin", absence.Datefin);
            parametres.Add("@idmotif", absence.Idmotif);

            Access.GetInstance().Manager.ReqUpdate(requete, parametres);
        }

        /// <summary>
        /// Modification d'une absence
        /// </summary>
        public void ModifierAbsence(Absence ancienneAbsence, Absence absence)
        {
            string requete = "UPDATE absence SET datedebut = @datedebut, datefin = @datefin, idmotif = @idmotif WHERE idpersonnel = @idpersonnel AND datedebut = @ancienneDatedebut;";

            Dictionary<string, object> parametres = new Dictionary<string, object>();
            parametres.Add("@idpersonnel", absence.Idpersonnel);
            parametres.Add("@ancienneDatedebut", ancienneAbsence.Datedebut);
            parametres.Add("@datedebut", absence.Datedebut);
            parametres.Add("@datefin", absence.Datefin);
            parametres.Add("@idmotif", absence.Idmotif);

            Access.GetInstance().Manager.ReqUpdate(requete, parametres);
        }

        /// <summary>
        /// Suppression d'une absence
        /// </summary>
        public void SupprimerAbsence(Absence absence)
        {
            string requete = "DELETE FROM absence WHERE idpersonnel = @idpersonnel AND datedebut = @datedebut;";

            Dictionary<string, object> parametres = new Dictionary<string, object>();
            parametres.Add("@idpersonnel", absence.Idpersonnel);
            parametres.Add("@datedebut", absence.Datedebut);

            Access.GetInstance().Manager.ReqUpdate(requete, parametres);
        }

        /// <summary>
        /// Recherche une absence sur la période
        /// </summary>
        public bool AbsenceChevauche(Absence absence)
        {
            string requete = "SELECT idpersonnel FROM absence WHERE idpersonnel = @idpersonnel AND datedebut <= @datefin AND datefin >= @datedebut;";

            Dictionary<string, object> parametres = new Dictionary<string, object>();
            parametres.Add("@idpersonnel", absence.Idpersonnel);
            parametres.Add("@datedebut", absence.Datedebut);
            parametres.Add("@datefin", absence.Datefin);

            List<object[]> resultats = Access.GetInstance().Manager.ReqSelect(requete, parametres);

            return resultats.Count > 0;
        }

        /// <summary>
        /// Recherche une autre absence sur la période
        /// </summary>
        public bool AbsenceChevaucheModification(Absence ancienneAbsence, Absence absence)
        {
            string requete = "SELECT idpersonnel FROM absence WHERE idpersonnel = @idpersonnel AND datedebut <= @datefin AND datefin >= @datedebut AND datedebut <> @ancienneDatedebut;";

            Dictionary<string, object> parametres = new Dictionary<string, object>();
            parametres.Add("@idpersonnel", absence.Idpersonnel);
            parametres.Add("@ancienneDatedebut", ancienneAbsence.Datedebut);
            parametres.Add("@datedebut", absence.Datedebut);
            parametres.Add("@datefin", absence.Datefin);

            List<object[]> resultats = Access.GetInstance().Manager.ReqSelect(requete, parametres);

            return resultats.Count > 0;
        }
    }
}