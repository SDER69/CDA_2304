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
        public Binaire(Expression _opGauche, Expression _opDroite)
        {
            this.opGauche = _opGauche;
            this.opDroite = _opDroite;
        }

        
    }
}
