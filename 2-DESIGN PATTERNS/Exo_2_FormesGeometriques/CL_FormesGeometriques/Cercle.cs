using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_FormesGeometriques
{
    public class Cercle : FormesGeometriques
    {
        public Cercle(int _x,int _y) : base(_x,_y)
        {
        }
         
        public override void Display()
        {
            Console.WriteLine("Je suis un cercle à la position : " +'\n' + "x = " + this.x + '\n' + "y = "+this.y);
        }

    }
}
