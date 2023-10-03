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
        private float bak;
        private float rashod;
        private float km_max;
        private float km = 0;
        private int otvet;
        private Random random = new Random();
        public void Info()
        {
            Console.WriteLine("Введите номер автомобиля:");
            id = Console.ReadLine();
            bak = random.Next(250, 1001);
            Console.WriteLine("\nВведите расход топлива на 100 км:");
            rashod = float.Parse(Console.ReadLine());
        }
        public void Output()
        {
            Console.WriteLine($"\nНомер авто: {id}");
            Console.WriteLine($"Кол-во бензина в баке: {bak}");
            Console.WriteLine($"Расход топлива на 100 км: {rashod}");
        }
        public void Zapravka()
        {
            Console.WriteLine("\nСколько хотите заправить бензина?");
            bak = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"\nВаш текущий уровень топлива: {bak}\n");
        }
        public void Move()
        {
            do
            {

                Info();
                Output();
                km_max = random.Next(100, 10001);
                Console.WriteLine($"\nВы собираетесь проехать такое расстояние:\n{km_max} км\n\nПоехали!\n");
                km = 0;
                do
                {
                    km += rashod / 100 * bak;
                    if (km < km_max)
                    {
                        Console.WriteLine($"Вы проехали только {km} км. Осталось {km_max - km}\nВам не хватает бензина.Желаете заправиться?\n(Нажмите 1, чтобы заправиться)");
                        otvet = Convert.ToInt32(Console.ReadLine());
                        if (otvet == 1)
                        {
                            Zapravka();
                        }
                        else
                        {
                            Console.WriteLine("\nИгра окончена");
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Вы проехали {km_max} км.\nПоздравляем, вы проехали это расстояние!\nВремя для новой поездки!\n");
                        break;
                    }
                } while (km < km_max);
            } while (otvet == 1);
        }
    }
}