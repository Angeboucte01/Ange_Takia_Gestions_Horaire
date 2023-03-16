using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratoire009
{
    internal sealed class OuvrierPiece : Ouvrier
    {   
        public int NbrePiece { get; set; }
        public double PrixPiece { get; set; }
        public OuvrierPiece(string nom, string prenom, bool pH, int nbrePie, double prixPie) : base(nom, prenom, pH)
        {
            NbrePiece = nbrePie;
            PrixPiece = prixPie;
        }

        public override double CalculerSalaire()
        {
            return PrixPiece * NbrePiece;
        }

        public override bool Equals(object? obj)
        {    
            if (obj == null) return false;
            if(obj.GetType() != typeof(OuvrierPiece)) return false;
            OuvrierPiece other = (OuvrierPiece)obj;
            return base.Equals(obj) && NbrePiece == other.NbrePiece
                                    && PrixPiece == other.PrixPiece; 
        }

        public override string ToString()
        {
            return base.ToString() +"\n"+
                $"Nombre de piece : {NbrePiece}" + "\n" +
                $"Prix piece : {PrixPiece}";
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();  
        }
    }
}
