using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_7._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значения сторон первого треугольника");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значения сторон второго треугольника");
            int a1 = Convert.ToInt32(Console.ReadLine());
            int b1 = Convert.ToInt32(Console.ReadLine());
            int c1 = Convert.ToInt32(Console.ReadLine());

            int Sum = CalcSum(a, b, c);
            double p = (double)Sum / 2;
            double S = Geron(a, b, c, p);
            int Sum1 = CalcSum(a1, b1, c1);
            double p1 = (double)Sum1 / 2;
            double S1 = Geron(a1, b1, c1, p1);
            Console.WriteLine("Площадь первого треугольника равна {0:.00}, площадь второго треугольника равна {1:.00}", S, S1);
            if (S > S1)
            {
                Console.WriteLine("Площадь первого треугольника больше площади второго треугольника");
            }
            else if (S == S1)
            {
                Console.WriteLine("Площади треугольников равны");
            }
            else
            Console.WriteLine("Площадь первого треугольника меньше площади второго треугольника");
            Console.WriteLine("Для выхода из программы нажмите любую клавишу");
            Console.ReadKey();
        }
        static int CalcSum(int a, int b, int c)
        {
            int Sum = a + b + c;
            return Sum;
        }
        static double Geron(int a, int b, int c, double p)
        {
            double S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return S;
        }

    }
}

