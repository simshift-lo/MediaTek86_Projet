using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTek86_Projet.Modele
{
    /// <summary>
    /// Classe Personnel
    /// </summary>
    public class Personnel
    {
        /// <summary>
        /// Id du personnel
        /// </summary>
        public int Idpersonnel { get; }

        /// <summary>
        /// Nom du personnel
        /// </summary>
        public string Nom { get; }

        /// <summary>
        /// Prénom du personnel
        /// </summary>
        public string Prenom { get; }

        /// <summary>
        /// Téléphone du personnel
        /// </summary>
        public string Tel { get; }

        /// <summary>
        /// Mail du personnel
        /// </summary>
        public string Mail { get; }

        /// <summary>
        /// Id du service
        /// </summary>
        public int Idservice { get; }

        /// <summary>
        /// Valorise les propriétés
        /// </summary>
        /// <param name="idpersonnel"></param>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <param name="tel"></param>
        /// <param name="mail"></param>
        /// <param name="idservice"></param>
        public Personnel(int idpersonnel, string nom, string prenom, string tel, string mail, int idservice)
        {
            this.Idpersonnel = idpersonnel;
            this.Nom = nom;
            this.Prenom = prenom;
            this.Tel = tel;
            this.Mail = mail;
            this.Idservice = idservice;
        }
    }
}
