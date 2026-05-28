using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTek86_Projet.Modele
{
    /// <summary>
    /// Classe Motif
    /// </summary>
    public class Motif
    {
        /// <summary>
        /// Id du motif
        /// </summary>
        public int Idmotif { get; }

        /// <summary>
        /// Libellé du motif
        /// </summary>
        public string Libelle { get; }

        /// <summary>
        /// Valorise les propriétés
        /// </summary>
        /// <param name="idmotif"></param>
        /// <param name="libelle"></param>
        public Motif(int idmotif, string libelle)
        {
            this.Idmotif = idmotif;
            this.Libelle = libelle;
        }
    }
}
