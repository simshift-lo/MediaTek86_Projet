using MediaTek86_Projet.dal;
using MediaTek86_Projet.Modele;
using System;
using System.Collections.Generic;

namespace MediaTek86_Projet.Controleur
{
    /// <summary>
    /// Gère les données du personnel
    /// </summary>
    public class ControlePersonnel
    {
        /// <summary>
        /// Liste du personnel
        /// </summary>
        public List<Personnel> GetLesPersonnels()
        {
            string requete = "SELECT idpersonnel, nom, prenom, tel, mail, idservice FROM personnel ORDER BY nom, prenom;";

            List<object[]> resultats = Access.GetInstance().Manager.ReqSelect(requete);
            List<Personnel> lesPersonnels = new List<Personnel>();

            foreach (object[] ligne in resultats)
            {
                Personnel personnel = new Personnel(
                    Convert.ToInt32(ligne[0]),
                    ligne[1].ToString(),
                    ligne[2].ToString(),
                    ligne[3].ToString(),
                    ligne[4].ToString(),
                    Convert.ToInt32(ligne[5])
                );

                lesPersonnels.Add(personnel);
            }

            return lesPersonnels;
        }

        /// <summary>
        /// liste des services
        /// </summary>
        public List<Service> GetLesServices()
        {
            string requete = "SELECT idservice, nom FROM service ORDER BY nom;";

            List<object[]> resultats = Access.GetInstance().Manager.ReqSelect(requete);
            List<Service> lesServices = new List<Service>();

            foreach (object[] ligne in resultats)
            {
                Service service = new Service(
                    Convert.ToInt32(ligne[0]),
                    ligne[1].ToString()
                );

                lesServices.Add(service);
            }

            return lesServices;
        }

        /// <summary>
        /// Ajout d'un personnel
        /// </summary>
        public void AjouterPersonnel(Personnel personnel)
        {
            string requete = "INSERT INTO personnel (nom, prenom, tel, mail, idservice) VALUES (@nom, @prenom, @tel, @mail, @idservice);";

            Dictionary<string, object> parametres = new Dictionary<string, object>();
            parametres.Add("@nom", personnel.Nom);
            parametres.Add("@prenom", personnel.Prenom);
            parametres.Add("@tel", personnel.Tel);
            parametres.Add("@mail", personnel.Mail);
            parametres.Add("@idservice", personnel.Idservice);

            Access.GetInstance().Manager.ReqUpdate(requete, parametres);
        }

        /// <summary>
        /// Modification d'un personnel
        /// </summary>
        public void ModifierPersonnel(Personnel personnel)
        {
            string requete = "UPDATE personnel SET nom = @nom, prenom = @prenom, tel = @tel, mail = @mail, idservice = @idservice WHERE idpersonnel = @idpersonnel;";

            Dictionary<string, object> parametres = new Dictionary<string, object>();
            parametres.Add("@idpersonnel", personnel.Idpersonnel);
            parametres.Add("@nom", personnel.Nom);
            parametres.Add("@prenom", personnel.Prenom);
            parametres.Add("@tel", personnel.Tel);
            parametres.Add("@mail", personnel.Mail);
            parametres.Add("@idservice", personnel.Idservice);

            Access.GetInstance().Manager.ReqUpdate(requete, parametres);
        }

        /// <summary>
        /// Suppression d'un personnel
        /// </summary>
        public void SupprimerPersonnel(Personnel personnel)
        {
            string requete = "DELETE FROM personnel WHERE idpersonnel = @idpersonnel;";

            Dictionary<string, object> parametres = new Dictionary<string, object>();
            parametres.Add("@idpersonnel", personnel.Idpersonnel);

            Access.GetInstance().Manager.ReqUpdate(requete, parametres);
        }
    }
}