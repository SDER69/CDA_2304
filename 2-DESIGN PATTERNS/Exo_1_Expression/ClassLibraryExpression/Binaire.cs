using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryExpression
{
    public abstract class Binaire : Expression
    {
        // Attributs
        protected Expression opGauche;
        protected Expression opDroite;


        // Constructeurs
        public Binaire(Expression _op1, Expression _op2)
        {
            this.opGauche = _op1;
            this.opDroite = _op2;
        }

        
    }
}
