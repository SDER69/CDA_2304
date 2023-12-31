﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryExpression
{
    public class Addition : Binaire
    {
        public Addition(Expression _opGauche, Expression _opDroite) : base(_opGauche, _opDroite)
        {
        }

        public override int Evalue()
        {
           return this.opGauche.Evalue() + this.opDroite.Evalue();
        }

        public override string ToString()
        {
            return this.opGauche.ToString() + "+" + this.opDroite.ToString();
        }

        /*public override String Format()
        { 
            return ToString() + " = " + this.Evalue();

        }*/

        /*public override String FormatGauche()
        { 
          return this.opGauche.FormatGauche() + "+" + this.opDroite.FormatGauche();
        }*/

        public override String FormatGauche()
        {
            return this.ToString();
        }


    }
}
