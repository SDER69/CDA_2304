using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_FormesGeometriques
{
    public class Rectangle : FormeGeometrique
    {
        private int width;
        private int height;

        public int Width { get => width; private set => width = value; }
        public int Height { get => height; private set => height = value; }

        public Rectangle(int _x,int _y,int _width,int _height) : base (_x, _y)
        {
            this.width = _width;
            this.height = _height;
        }

        public override void Display()
        {
            Console.WriteLine("Je suis un rectangle à la position : " + '\n' + "x = " + this.X + '\n' + "y = " + this.Y);
        }

        public override void Accept(IVisiteurDeFormeGeometrique v)
        {
            v.Visit(this);
        }
    }
}
