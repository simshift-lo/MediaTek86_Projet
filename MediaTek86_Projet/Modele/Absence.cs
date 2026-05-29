using System;

namespace MediaTek86_Projet.Modele
{
    /// <summary>
    /// Classe Absence
    /// </summary>
    public class Absence
    {
        /// <summary>
        /// Id du personnel
        /// </summary>
        public int Idpersonnel { get; }
        /// <summary>
        /// Date de début
        /// </summary>
        public DateTime Datedebut { get; }
        /// <summary>
        /// Date de fin
        /// </summary>
        public DateTime Datefin { get; }
        /// <summary>
        /// Id du motif
        /// </summary>
        public int Idmotif { get; }

        /// <summary>
        /// Valorise les propriétés
        /// </summary>
        /// <param name="idpersonnel"></param>
        /// <param name="datedebut"></param>
        /// <param name="datefin"></param>
        /// <param name="idmotif"></param>
        public Absence(int idpersonnel, DateTime datedebut, DateTime datefin, int idmotif)
        {
            this.Idpersonnel = idpersonnel;
            this.Datedebut = datedebut;
            this.Datefin = datefin;
            this.Idmotif = idmotif;
        }
    }
}
