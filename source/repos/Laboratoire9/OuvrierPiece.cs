using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratoire9
{
    internal class OuvrierPiece : Ouvrier
    {
        public int NbrePiece { get; set; }
        public double PriPiece { get; set; }

        public OuvrierPiece(string nom, string prenom, bool plageHoraire, int nbrePiece, double prixPiece) : base(nom, prenom, plageHoraire)
        {
            NbrePiece = nbrePiece;
            PriPiece = prixPiece;
        }


        public override double CalculerSalaire()
        {
            return  NbrePiece * PriPiece;
        }
    }
}
