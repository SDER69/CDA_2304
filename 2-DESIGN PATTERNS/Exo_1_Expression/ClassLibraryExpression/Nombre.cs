using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryExpression
{
    public class Nombre : Expression
    {
        // Attributs
        private int valeur;
        
        // Getters
        public int Valeur { get => valeur; set => valeur = value; }

        // Constructeurs
        public Nombre(int _valeur)
        {
            this.valeur = _valeur;
        }

        // Méthodes
        public override int Evalue()
        {
            int number = this.valeur;
            return number;
        }

        public override string ToString()
        {
            return this.valeur.ToString();
        }

        public override string Format()
        {
            throw new NotImplementedException();
        }
    }
}
