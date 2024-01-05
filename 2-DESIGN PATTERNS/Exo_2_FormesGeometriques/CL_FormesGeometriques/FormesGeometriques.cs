namespace CL_FormesGeometriques
{
    public abstract class FormesGeometriques
    {
        // Atrributs
        protected int x;
        protected int y;

        // Constructeurs
        public FormesGeometriques(int _x, int _y)
        {
            this.x = _x;
            this.y = _y;
        }

        public abstract void Display();
    }
}