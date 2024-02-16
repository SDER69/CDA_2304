using System.Security.Authentication;

namespace TestsUnitairesConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tests de la méthode Addition

            // Test 1
            /*int a = 1;
            int b = 2;
            int resultat = Addition(a,b);
            if (resultat != 3)
                Console.WriteLine("Le test a raté");
            else
                Console.WriteLine("Le test est ok");

            // Test 2
            a = 0;
            b = 0;
            resultat = Addition(a,b);
            if (resultat != 0)
                Console.WriteLine("Le test a raté");
            else
                Console.WriteLine("Le test est ok");

            // Test 3
            a = -5;
            b = 5;
            resultat = Addition(a,b);
            if (resultat != 0)
                Console.WriteLine("Le test a raté");
            else
                Console.WriteLine("Le test est ok");*/
//-------------------------------------------------------------------------------------------------------------------------------//
            // Tests avec la méthode TDD
            // Etape 1 et 2 : Ecrire le test et le tester
            /*string phrase1 = "";
            if(CompteMots(phrase1) != 0)
                Console.WriteLine("Echec du test");
            else 
                Console.WriteLine("Le test est ok");
            */
            // Etape 3 : Remaniement --> aucune amélioration à apporter à la méthode

            // Etape 4 : Ecriture d'un autre test
            string phrase2 = "mot";
            if (CompteMots(phrase2) != 1)
                
                    Console.WriteLine("Echec du test");
                else
                    Console.WriteLine("Le test est ok");
                    Console.WriteLine(phrase2.Length);







        }

        public static int Addition(int a, int b)
        {
            return a + b;
        }

        private static int CompteMots(string phrase)
        {
            if (phrase.Length == 0)
                return 0;
            return 1; 
            
        }
    }
}