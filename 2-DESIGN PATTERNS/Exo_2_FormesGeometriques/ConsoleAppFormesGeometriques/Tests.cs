using CL_FormesGeometriques;

namespace ConsoleAppFormesGeometriques
{
    internal class Tests
    {
        static void Main(string[] args)
        {
            Cercle c1 = new Cercle(5,6,5);
            //c1.Display();

            //Console.WriteLine();

            Rectangle r1 = new Rectangle(10,5,10,20);
            //r1.Display();

            //Console.WriteLine();

            Carre ca1 = new Carre(5,5,5);
            //ca1.Display();
            
            //Console.WriteLine();

            GroupeFormesGeometriques gfg = new GroupeFormesGeometriques(10,6);
            gfg.AjouterFormeGeometrique(c1);
            gfg.AjouterFormeGeometrique(r1);
            gfg.AjouterFormeGeometrique(ca1);
            //gfg.Display();
            //Console.WriteLine();
            //gfg.RetirerFormeGeometrique(c1);
            //gfg.RetirerFormeGeometrique(r1);
            //gfg.Display();
           
            gfg.Accept(new VisiteurDeFormeGeometriquePourConsole());


        
        }
    }
}