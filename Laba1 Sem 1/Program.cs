using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba1_Sem_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Как вас зовут?");
            string name = Console.ReadLine();
            Console.WriteLine("Какой язык вы знаете?");
            string yaz = Console.ReadLine();
            Console.WriteLine($"Я {name} я уже знаю {yaz}");

            Console.WriteLine("Второе задание:");
            Console.Write("Введите X: ");
            double X = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите Y: ");
            double Y = Convert.ToDouble(Console.ReadLine());

            
            double vectorMagnitude = Math.Sqrt(X * X + Y * Y);

            
            double cosTheta = X / vectorMagnitude;

            
            double theta = Math.Acos(cosTheta);

            
            double thetaDegrees = theta * (180.0 / Math.PI);

            Console.WriteLine($"Угол между вектором и осью X: {thetaDegrees:F2} градусов");
            Console.WriteLine("Задание 3");
            int S = 163;
            Console.WriteLine("Введите скорость авто");
            int v = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите через сколько часов");
            int t = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Автомобиль остановиться на {(v*t)-((v*t)/S)*S} км");


            Console.WriteLine("Задание 4");
            Console.WriteLine("Введите число 1");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число 2");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Random ran = new Random();
            Console.WriteLine($"Число : {ran.Next(x1,x2)}");


            Console.WriteLine("Задание 5:");
            Console.WriteLine("Введите число a");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число b");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число c");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число d");
            int d = Convert.ToInt32(Console.ReadLine());
            double Z = (a / c) * (b / d) - ((a * b - c) / c * d) + Math.Sqrt(d);
            Console.WriteLine($"Число {Z}ё");
            Console.ReadLine();
            
        }
    }
}
