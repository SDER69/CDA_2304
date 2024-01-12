using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_FormesGeometriques
{
    public class Cercle : FormeGeometrique
    {
        int rayon;

        public int Rayon { get => rayon; set => rayon = value; }

        public Cercle(int _x,int _y, int rayon) : base(_x, _y)
        {
            this.Rayon = rayon; 
        }

        public override void Display()
        {
            Console.WriteLine("Je suis un cercle à la position : " +'\n' + "x = " + this.X + '\n' + "y = "+this.Y);
        }

        public override void Accept(IVisiteurDeFormeGeometrique v)
        {
            v.Visit(this);
        }

    }
}
