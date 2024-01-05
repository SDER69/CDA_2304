using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_FormesGeometriques
{
    public class GroupeFormesGeometriques : FormesGeometriques
    {
        public GroupeFormesGeometriques(int _x, int _y) : base(_x, _y)
        {
        }

        public override void Display()
        {
            Console.WriteLine("x = "+this.x+ "y" +this.y);
        }

        public bool AjouterFormeGeometrique(FormesGeometriques fg)
        {
            return false;
        }

        public bool RetirerFormeGeometrique(FormesGeometriques fg)
        {
            return false;
        }
    }
}
