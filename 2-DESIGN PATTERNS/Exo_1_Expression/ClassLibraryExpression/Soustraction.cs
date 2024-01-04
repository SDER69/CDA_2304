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
            return this.opGauche.Evalue() - this.opDroite.Evalue();
        }

        public override string ToString()
        {
            if(this.opDroite is Nombre)
            {
                return this.opGauche.ToString() + "-" + this.opDroite.ToString();
            }
            else
            {
                return this.opGauche.ToString() + "-(" + this.opDroite.ToString() + ")";
            }
            //return this.opGauche.ToString()+ "-" + this.opDroite.ToString();
        }

        public override String FormatGauche()
        {
            return this.ToString();
        }

      


    }
}
