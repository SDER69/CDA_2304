using CL_FormesGeometriques;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppFormesGeometriques
{
    public class VisiteurDeFormeGeometriquePourConsole : IVisiteurDeFormeGeometrique
    {
        public void Visit(Cercle c)
        {
            Console.WriteLine("Je suis un cercle à la position : " + '\n' + "x = " + c.X + '\n' + "y = " + c.Y);
        }

        public void Visit(Rectangle r)
        {
            Console.WriteLine("Je suis un rectangle à la position : " + '\n' + "x = " + r.X + '\n' + "y = " + r.Y);
        }

        public void Visit(Carre ca)
        {
            Console.WriteLine("Je suis un carré à la position : " + '\n' + "x = " + ca.X + '\n' + "y = " + ca.Y);
        }

        public void Visit(GroupeFormesGeometriques gfg)
        {
            Console.WriteLine("Je suis un GroupeFormesGeometriques à la position : " + '\n' + "x = " + gfg.X + '\n' + "y = " + gfg.Y);
        }
    }
}

