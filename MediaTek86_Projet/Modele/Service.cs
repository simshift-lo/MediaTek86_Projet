namespace MediaTek86_Projet.Modele
{
    /// <summary>
    /// Classe Service
    /// </summary>
    public class Service
    {
        /// <summary>
        /// Id du service
        /// </summary>
        public int Idservice { get; }

        /// <summary>
        /// Nom du service
        /// </summary>
        public string Nom { get; }

        /// <summary>
        /// Valorise les propriétés
        /// </summary>
        /// <param name="idservice"></param>
        /// <param name="nom"></param>
        public Service(int idservice, string nom)
        {
            this.Idservice = idservice;
            this.Nom = nom;
        }
    }
}
