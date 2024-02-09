namespace ProxyPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IService proxy = new Proxy();

            // Connexion non autorisée
            proxy.Login(15);

            // Connexion autorisée
            proxy.Login(18);
        }
    }
}