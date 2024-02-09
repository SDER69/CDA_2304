using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    public class ConcreteService : IService
    {
        public void Login(int age)
        {
            Console.WriteLine($"Tu es connecté. Ton âge est {age} ans.");
        }
    }
}
