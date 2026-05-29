using MediaTek86_Projet.dal;
using System.Collections.Generic;

namespace MediaTek86_Projet.Controleur
{
    /// <summary>
    /// Gère la connexion d'un responsable
    /// </summary>
    public class ControleConnexion
    {
        /// <summary>
        /// Vérifie le login et le mot de passe dans la BDD
        /// </summary>
        public bool ControleAuthentification(string login, string pwd)
        {
            string requete = "SELECT login FROM responsable WHERE login = @login AND pwd = SHA2(@pwd, 256);";

            Dictionary<string, object> parametres = new Dictionary<string, object>();
            parametres.Add("@login", login);
            parametres.Add("@pwd", pwd);

            List<object[]> resultats = Access.GetInstance().Manager.ReqSelect(requete, parametres);

            return resultats.Count > 0;
        }
    }
}