using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class Program
    {

        int i = 0;
        public static double BBod(string[] args, int i)
        {
            double a;
            try
            {
                if (args.Length != 3)
                    a = Convert.ToDouble(Console.ReadLine());
                else
                {
                    a = Convert.ToDouble(args[i]);

                }
            }
            catch
            {
                Console.WriteLine("Повторите ввод числа ");
                a = BBod(args, i);
            }
            return a;
        }
        public static void decision(string[] args)
        {
            double a, b, c, D, x1, x2;
            Console.WriteLine("Введите коэффициент a: ");
            a = BBod(args, 0);
            Console.WriteLine("Введите коэффициент b: ");
            b = BBod(args, 1);
            Console.WriteLine("Введите коэффициент c: ");
            c = BBod(args, 2);
            D = Math.Pow(b, 2) - 4 * a * c;
            Console.WriteLine(D.ToString(), "/n");
            if (a == 0)
            {
                x1 = -1 * c / b;
                Console.WriteLine("Единственный корень в уравнении ", x1);
                Console.ReadKey();
            }
            else if (b == 0)
            {
                x1 = Math.Sqrt(-1 * c / a);
                x2 = -1 * Math.Sqrt(-1 * c / a);
                Console.WriteLine("x1= {0}\nx2= {1}", x1, x2);
                Console.ReadKey();
            }
            else if (D > 0 || D == 0)
            {
                x1 = (-b + Math.Sqrt(D)) / (2 * a);
                x2 = (-b - Math.Sqrt(D)) / (2 * a);
                Console.WriteLine("x1= {0}\nx2= {1}", x1, x2);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Дискриминант отрицательный, корней нет");
                Console.ReadKey();
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine(args.Length);
            decision(args);
        }


    }
}