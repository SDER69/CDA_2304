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
        private Expression opGauche;
        private Expression opDroite;

        // Getters
        public Expression OpGauche { get => opGauche; set => opGauche = value; }
        public Expression OpDroite { get => opDroite; set => opDroite = value; }

        // Constructeurs
        public Binaire(Expression _op1, Expression _op2)
        {
            this.OpGauche = _op1;
            this.OpDroite = _op2;
        }

        
    }
}
