using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratoire8
{
    abstract class Forme
    {
        //Definition des attributs et proprietes

        public Point3D CentreGravite { get; set; }
        public double Densite { get; set; }


        //Définir un constructeur initialisant tous les attributs
        public Forme(Point3D centreGravite, double densite )
        {
            CentreGravite = centreGravite;
            Densite = densite;
        }

        //- Une méthode permettant de translater une forme d’un vecteur donné. Cette méthode aura pour signature
        public void Bouger(double vx, double vy, double vz)
        {
            CentreGravite.Bouger(vx, vy, vz);
        }

        //Redefinition de la methode Equals

        public override bool Equals(object obj)     //this avec obj
        {
            //1. comparer obj avec null
            if (obj == null) return false;
            //2. tester si obj est une point 
            if (obj.GetType() != typeof(Point3D)) return false; //obj is not point
            //3. conversion de obj vers un point
            Point3D point = (Point3D)obj;      //CAST (as)
            //4. Implementation du critere de comparaison
            return point.X == this.CentreGravite.X && point.Y == this.CentreGravite.Y && point.Z == this.CentreGravite.Z;
        }

        /* public override string ToString()
     {
         return $"[Forme Centre de Gravité :.0, y : {Y}.0, z : {Z}.0].";
     }*/

        //Définir une méthode pour calculer la surface d’une forme. La méthode est nommée Surface.Pourquoi cette méthode est abstraite
        //Cette methode est abstraite car son implementation n'est pas fourni

        public abstract double Surface();


        //Définir une méthode pour calculer le volume d’une forme. La méthode est nommée Volume.Pourquoi cette méthode est abstraite
        //Cette methode est abstraite car son implementation n'est pas fourni

        public abstract double Volume();

        //Définir une méthode pour calculer le poids d’une forme. La méthode est nommée Poids.Le poids est calculé par la formule suivante : Volume() * Densité.

        public  double poids ()
        {
            double poids = 0;
            return poids = Volume() * Densite;
        }


    }





}
