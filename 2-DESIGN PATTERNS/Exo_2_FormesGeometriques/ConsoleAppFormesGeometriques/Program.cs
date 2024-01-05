using CL_FormesGeometriques;

namespace ConsoleAppFormesGeometriques
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cercle c1 = new Cercle(5,6);
            c1.Display();

            Console.WriteLine();

            Rectangle r1 = new Rectangle(10,5);
            r1.Display();

            Console.WriteLine();

            Carre ca1 = new Carre(5,5);
            ca1.Display();
        
        }
    }
}