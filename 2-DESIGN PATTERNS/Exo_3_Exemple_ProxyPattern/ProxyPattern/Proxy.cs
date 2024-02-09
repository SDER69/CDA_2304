using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    public class Proxy : IService
    {
        private IService service;

        public Proxy()
        {
            this.service = new ConcreteService();
        }
        public void Login(int age)
        {
            if (age < 18) 
            {
                Console.WriteLine("Connexion interdite.Tu es mineur.");
            }
            else
            {
                service.Login(age); 
            }
        }
    }
}
