using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AreaOfTriagle
{
    class Program
    {
        static void Main(string[] args)
        {
            double S,p,a,b,c;            

            Console.Write("Введите а: ");
            a = Convert.ToInt32(Console.ReadLine());
            while (a <= 0)
            {
                Console.WriteLine("a неможет быть меньше нуля!");
                Console.Write("Введите а: ");
               a = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Введите b: ");
              b = Convert.ToInt32(Console.ReadLine());
            while (b <= 0)
            {
                Console.WriteLine("b неможет быть меньше нуля!");
                Console.Write("Введите b: ");
                b = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Введите c: ");
             c = Convert.ToInt32(Console.ReadLine());
            while (c <= 0)
            {
                Console.WriteLine("c неможет быть меньше нуля!");
                Console.Write("Введите c: ");
                c = Convert.ToInt32(Console.ReadLine());
            }

            p = (a + b + c) / 2;

            S = Math.Sqrt(p * ((p - a) * (p - b) * (p - c)));
            if (S<=0)            
                Console.WriteLine("Такого треугольника не существует!");
            else
            Console.WriteLine("Площадь треугольника равна: " + S);


            Console.ReadKey();
        }
    }
}
