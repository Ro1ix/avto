using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace avto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
    public class avto
    {
        private string nom;
        private int bak;
        private double ras = new double();
        void info(string nom, float bak, float ras)
        {
            this.nom = Console.ReadLine();
            this.bak = Convert.ToInt32(Console.ReadLine());
            this.ras = Convert.ToDouble(Console.ReadLine());
        }
        void vivod()
        {
            Console.WriteLine(nom);
            Console.WriteLine(bak);
            Console.WriteLine(ras);
        }

    }
}
