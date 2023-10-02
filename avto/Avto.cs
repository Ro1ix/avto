using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace avto
{
    public class Avto
    {
        private string id;
        private int bak_max;
        private float bak = 0;
        private float rashod;
        public void Info()
        {
            Console.WriteLine("Введите номер:");
            id = Console.ReadLine();
            Console.WriteLine("\nВведите объём бака (целое число):");
            bak_max = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nВведите расход топлива на 100 км:");
            rashod = float.Parse(Console.ReadLine());
        }
        public void Output()
        {
            Console.WriteLine($"Номер авто: {id}");
            Console.WriteLine($"Кол-во бензина в баке: {bak}");
            Console.WriteLine($"Расход топлива на 100 км: {rashod}");
        }
        public void Zapravka()
        {
            Console.WriteLine("\nСколько хотите заправить бензина?");
            bak += float.Parse(Console.ReadLine());
            Console.WriteLine($"\nВаш текущий уровень топлива: {bak}");
        }
        public void move()
        {

        }
    }
}