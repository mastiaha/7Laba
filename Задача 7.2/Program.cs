using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_7._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину ребра куба");
            int a = Convert.ToInt32(Console.ReadLine());
            
            double v = Objom(a);
            double S = SPoverhnocti(a);
            Console.WriteLine("Объем куба составляет {0}",v);
            Console.WriteLine("Площадь общей поверхности куба составляет {0}",S);
            Console.WriteLine("Для выхода из программы нажмите любую клавишу");
            Console.ReadKey();
        }
        static double Objom (int a)
        {
            double v = Math.Pow(a,3);
            return v;
        }
        static double SPoverhnocti(int a)
        {
            double S = a * a * 6; // где 6 это количество граней куба
            return S;
        }
    }
}
