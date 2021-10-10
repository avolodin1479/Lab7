using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите стороны первого треугольника");
            int a1 = Convert.ToInt32(Console.ReadLine());
            int b1 = Convert.ToInt32(Console.ReadLine());
            int c1 = Convert.ToInt32(Console.ReadLine());
            double S1;
            CulcArea(a1, b1, c1, out S1);
            Console.WriteLine("Площадь первого треугольника равна: {0:##########.00}",S1);

            Console.WriteLine("Введите стороны второго треугольника");
            int a2 = Convert.ToInt32(Console.ReadLine());
            int b2 = Convert.ToInt32(Console.ReadLine());
            int c2 = Convert.ToInt32(Console.ReadLine());
            double S2;
            CulcArea(a2, b2, c2, out S2);
            Console.WriteLine("Площадь второго треугольника равна: {0:##########.00}", S2);

            if (S1>S2)
            {
                Console.WriteLine("Площадь первого треугольника больше");
            }
            else
            {
                if (S1 < S2)
                {
                    Console.WriteLine("Площадь второго треугольника больше");
                }
                else
                {
                    Console.WriteLine("Площади треугольников равны");
                }
            }
            
            Console.ReadKey();
        }
        static void CulcArea(int a, int b, int c, out double S)
        {
            double p = ((double)a + b + c) / 2;
            S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

    }
}
