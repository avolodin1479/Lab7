using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину ребра куба");
            double a = Convert.ToDouble(Console.ReadLine());
            double S;
            double V;
            CulcCube(a, out S, out V);
            Console.WriteLine("Площадь куба равна {0:##########,00}", S);
            Console.WriteLine("Объем куба равен {0:#######,00}", V);
            Console.ReadKey();
        }
        static void CulcCube(double a, out double S, out double V)
        {
            S = 6 * Math.Pow(a, 2);
            V = Math.Pow(a, 3);
        }

    }
}
