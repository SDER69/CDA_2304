using System.Data;

namespace CL_FormesGeometriques
{
    public abstract class FormeGeometrique
    {
        // Atrributs
        private int x;
        private int y;
       
        // Getters
        public int X { get => x; private set => x = value; }
        public int Y { get => y; private set => y = value; }
        

        // Constructeurs
        public FormeGeometrique(int _x, int _y)
        {
            this.x = _x;
            this.y = _y;
        }
        
        // Méthodes abstraites
        public abstract void Display();
        public abstract void Accept(IVisiteurDeFormeGeometrique v);
    }
}