namespace MediaTek86_Projet.Modele
{
    /// <summary>
    /// Classe Responsable
    /// </summary>
    public class Responsable
    {
        /// <summary>
        /// Login du responsable
        /// </summary>
        public string Login { get; }

        /// <summary>
        /// Mot de passe du responsable
        /// </summary>
        public string Pwd { get; }

        /// <summary>
        /// Valorise les propriétés
        /// </summary>
        /// <param name="login"></param>
        /// <param name="pwd"></param>
        public Responsable(string login, string pwd)
        {
            this.Login = login;
            this.Pwd = pwd;
        }
    }
}
