using CL_FormesGeometriques;
using System.Drawing;

namespace WinFormsAppFormesGeometriques
{
    public class VisiteurDeFormeGeometriquePourWinforms : IVisiteurDeFormeGeometrique
    {
        Graphics graphics;

        public VisiteurDeFormeGeometriquePourWinforms(Graphics graphics)
        {
            this.graphics = graphics;
        }

        public void Visit(Cercle c)
        {
            Console.WriteLine("Je suis un cercle à la position : " + '\n' + "x = " + c.X + '\n' + "y = " + c.Y);
        }


        public void Visit(GroupeFormesGeometriques gfg)
        {
            Console.WriteLine("Je suis un GroupeFormesGeometriques à la position : " + '\n' + "x = " + gfg.X + '\n' + "y = " + gfg.Y);
        }

        public void Visit(CL_FormesGeometriques.Rectangle r)
        {
            Pen pen = new Pen(Color.Red);
            graphics.DrawRectangle(pen, 10, 10, 200, 100);
        }
    }
}