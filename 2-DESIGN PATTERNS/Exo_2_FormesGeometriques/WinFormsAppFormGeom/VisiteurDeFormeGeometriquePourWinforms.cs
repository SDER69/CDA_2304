using CL_FormesGeometriques;
using System.Drawing;

namespace WinFormsAppFormGeom
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
            Pen pen = new Pen(Color.Red);
            graphics.DrawEllipse(pen, c.X, c.Y, c.Rayon*2, c.Rayon*2);
        }


        public void Visit(GroupeFormesGeometriques gfg)
        {
            
        }

        public void Visit(CL_FormesGeometriques.Rectangle r)
        {
            Pen pen = new Pen(Color.Red);
            graphics.DrawRectangle(pen, r.X, r.Y, r.Width, r.Height);
        }

        public void Visit(Carre ca)
        {
            Pen pen = new Pen(Color.Black);
            graphics.DrawRectangle(pen, ca.X, ca.Y, ca.Width, ca.Height);
        }
    }
}