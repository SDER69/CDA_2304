using CL_Domain;

namespace TestsConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Personne p = new Personne("Marco","Polo",45);
            p.Persistance = new PersistancePersonne();
            p.Save();
        }
    }
}