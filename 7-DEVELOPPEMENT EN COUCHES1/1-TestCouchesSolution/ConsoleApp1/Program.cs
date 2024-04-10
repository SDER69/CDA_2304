using CL_Domain;
using CL_PDomainPersistance;
using CL_PersistanceMySQL;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            PersistanceForEgg p = new PersistanceForEgg();
            //StructEgg s = p.Select(1);

            //Egg myEgg = new Egg(10.5f, 5, "noisette");
            //myEgg.SetPersistance(new PersistanceForEgg());
            //myEgg.Save();

            //PersistanceForEgg p = new PersistanceForEgg();
            //StructEgg s = myEgg.GetStruct();
            //p.Insert(s);


            Egg myEgg = new Egg(12f, 6, "lait");
            myEgg.SetPersistance(p);
            myEgg.Save();


        }
    }
}