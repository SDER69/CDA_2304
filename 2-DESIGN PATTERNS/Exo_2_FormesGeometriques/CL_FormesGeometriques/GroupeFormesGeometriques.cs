using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace CL_FormesGeometriques
{
    public class GroupeFormesGeometriques : FormeGeometrique
    {
        private List<FormeGeometrique> formesGeometriques;

        public GroupeFormesGeometriques(int _x, int _y) : base(_x, _y)
        {
            formesGeometriques = new List<FormeGeometrique>();
        }

        public override void Display()
        {
            foreach (FormeGeometrique fg in formesGeometriques)
            {
              fg.Display();
            }
        }

        public bool AjouterFormeGeometrique(FormeGeometrique fg)
        {
            formesGeometriques.Add(fg);
            return true;
        }

        public bool RetirerFormeGeometrique(FormeGeometrique fg)
        {
            formesGeometriques.Remove(fg);
            return true;    
        }

        public override void Accept(IVisiteurDeFormeGeometrique v)
        {
            v.Visit(this);
            foreach (FormeGeometrique fg in formesGeometriques)
            {
                fg.Accept(v);
            }

        }
    }
}
