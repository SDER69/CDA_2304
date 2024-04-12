using ECF_Spa;

namespace TestsConsolePersistance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Chat c = new Chat(10, "Toto", 25, 2);
            c.Persistance = new PersistanceChat();
            c.Save();
        }
    }
}