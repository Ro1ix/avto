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
        private float speed;
        //private float probeg;
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
        public void SpeedUp()
        {

        }
        public void SpeedDown()
        {

        }
        public void Move()
        {
            do
            {
                Console.WriteLine("\nС какой скоростью хотите ехать?\nПримечание: скорость ниже или равная 60 км/ч будет расходовать топливо в 1,5 раза меньше.\nСкорость выше 90 км/ч - в 1,5 раза больше");
                speed = float.Parse(Console.ReadLine());
                km_max = random.Next(100, 10001);
                Console.WriteLine($"\nВы собираетесь проехать такое расстояние:\n{km_max} км\n\nПоехали!\n");
                km = 0;
                do
                {
                    if (speed > 90)
                        km += (float)(rashod * 1.5 / 100 * bak);
                    else if (speed <= 55)
                        km += (float)(rashod / 1.5 / 100 * bak);
                    else
                        km += rashod / 100 * bak;
                    if (km < km_max)
                    {
                        Console.WriteLine($"Вы проехали только {km} км. Осталось {km_max - km}\nВам не хватает бензина. Желаете заправиться?\n(Нажмите 1, чтобы заправиться)");
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