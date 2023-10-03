using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace avto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Avto car = new Avto();
            car.Move();
        }
    }
}
