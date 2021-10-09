using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4
{
    class Program
    {
        static void Comparison()
        {
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            if (num1 > num2)
            {
                Console.WriteLine(num1);
            }
            else if (num2 > num1)
            {
                Console.WriteLine(num2);
            }
            else
            {
                Console.WriteLine("Числа равны");
            }
        }

        public static void Swap<T>(ref T a, ref T b) => (a, b) = (b, a);

        static void fakt(out int i)
        {
            int maxintvalue = 2147483647;
            int F = 1;
            for (int c = 18; c > 1; c--)
                F = F * c;

            i = F;
            Console.WriteLine("Факториал 5 =  " + F);
            Console.ReadLine();
            int z = 0;
            try
            {
                z = checked(maxintvalue + F);
            }
            catch (System.OverflowException e)
            {
                Console.WriteLine("CHECKED" + e.ToString());
            }

        }
        static int factorial(int i)
        {
            int result;

            if (i == 1)
                return 1;
            result = factorial(i - 1) * i;
            return result;
        }

        public static int GetNOD(int val1, int val2)
        {
            while ((val1 != 0) && (val2 != 0))
            {
                if (val1 > val2)
                    val1 -= val2;
                else
                    val2 -= val1;
            }

            return Math.Max(val1, val2);
        }

        static int FibRec(int p1, int p2, int n)
        {
            return n == 0 ? p1 : FibRec(p2, p1 + p2, n - 1);
        }
        static int Fib(int n)
        {
            return FibRec(0, 1, n);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Упражнение 5.1");
            Comparison();


            Console.WriteLine("Упражнение 5.2");
            int x = 10, y = 32;
            Console.WriteLine($"x: {x}, y: {y}");
            Swap(ref x, ref y);
            Console.WriteLine($"x: {y}, y: {x}");


            Console.WriteLine("Упражнение 5.3");
            int F;
            fakt(out F);


            Console.WriteLine("Упражнение 5.4");
            Console.WriteLine("Введите число: ");
            try
            {
                int i = int.Parse(Console.ReadLine());
                Console.WriteLine("{0}! = {1}", i, factorial(i));
            }
            catch (FormatException)
            {
                Console.WriteLine("Некорректное число");
            }


            Console.WriteLine("Домашнее задание 5.1");


            Console.WriteLine("Домашнее задание 5.2");



        }


    }
}
