using ClassLibraryProduction;
using System.Runtime.CompilerServices;

namespace ConsoleAppProductionTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Production p = new Production("Production A", 120, 'A');
            if(p != null)
            {
                p.NewCrateProduced += P_NewCrateProduced;
                p.StartProduction();
                Thread.Sleep(500);
                p.SuspendProduction();
                Thread.Sleep(500);
                p.StartProduction();
            }   
        }

        private static void P_NewCrateProduced(int numberOfCratesProduced, int target, Production p)
        {
            Console.WriteLine("Le nombre de caisses produites de la "+p.ProductionName+ " est de " + numberOfCratesProduced);
        }

       
    }
}