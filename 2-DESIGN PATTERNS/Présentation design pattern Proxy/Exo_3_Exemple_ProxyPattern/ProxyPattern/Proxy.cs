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

        private bool CheckIsMajor(int age)
        {
            return (age >= 18);
        }

        public void Login(int age)
        {
            if (CheckIsMajor(age)) 
            {
                service.Login(age);
            }
            else
            {
                Console.WriteLine("Connexion interdite.Tu es mineur.");  
            }
        }
    }
}
