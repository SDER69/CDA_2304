using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_FormesGeometriques
{
    public class Carre : Rectangle
    {
        public Carre(int _x,int _y,int _cote) : base(_x, _y, _cote,_cote) { }

        public override void Display()
        {
            Console.WriteLine("Je suis un carré à la position : " + '\n' + "x = " + this.X + '\n' + "y = " + this.Y );
        }

        public override void Accept(IVisiteurDeFormeGeometrique v)
        {
            v.Visit(this);
        }
    }
}
