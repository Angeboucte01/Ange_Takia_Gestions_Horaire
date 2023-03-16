using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratoire8
{
    internal class Point3D
    {
        //Definition des attributs du point3d
        private double x, y, z;

        //Definition des proprietes du point3d
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        //Definitions du constructeurs initialisant tout les ttributs

        public Point3D(double x, double y, double z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        //Une méthode permettant de translater le point d’un vecteur donné. Cette méthode aura pour signature 

        /* Arguments :double vx, double vy, double vz
         * Retour    :Aucun
         * Role      :permet de translater le point d’un vecteur donné
         */
        public void Bouger(double vx, double vy, double vz)
        {
            X += vx;
            Y += vy;
            Z += vz;
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
            return point.X == this.X && point.Y == this.Y && point.Z == this.Z;
        }

        //Redefinition de la methode ToString

        public override string ToString()
        {
            return $"[Point3D x :{X}.0, y : {Y}.0, z : {Z}.0].";
        }

        //definir une methode permettant de calculer la distance entre 2 point

        /* Arguments : un point p
         * Retour    : double
         * Role      :permet de calculer la distance entre deux point
         */

        public double Distance(Point3D p)
        {
            double distance = 0;
            if (p == null)
                return 0;
            else
                return distance = Math.Sqrt(Math.Pow(p.X - X, 2) + Math.Pow(p.Y - Y, 2) + Math.Pow(p.Z - Z, 2));
        }

    }
}
