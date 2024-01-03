using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryExpression
{
    public class Soustraction : Binaire
    {
        public Soustraction(Expression _opGauche, Expression _opDroite) : base(_opGauche, _opDroite)
        {
        }

        public override int Evalue()
        {
            return this.OpGauche.Evalue() - this.OpDroite.Evalue();
        }

        public override string ToString()
        {
            return this.OpGauche.ToString()+ "-" + this.OpDroite.ToString();
        }

        public override String Format()
        {
            return ToString() + " = " + this.Evalue();

        }
    }
}
