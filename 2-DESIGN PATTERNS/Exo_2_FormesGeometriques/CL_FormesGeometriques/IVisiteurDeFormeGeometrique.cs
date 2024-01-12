using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_FormesGeometriques
{
    public interface IVisiteurDeFormeGeometrique
    {
         void Visit(Cercle c);
         void Visit(Rectangle r);
         void Visit(Carre ca);
         void Visit(GroupeFormesGeometriques gfg);
    }
}
