using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Classwork4
{
    class Program
    {
        static int[] BubbleSort(int[] mas)
        {
            int temp;
            for (int i = 0; i < mas.Length; i++)
            {
                for (int j = i + 1; j < mas.Length; j++)
                {
                    if (mas[i] > mas[j])
                    {
                        temp = mas[i];
                        mas[i] = mas[j];
                        mas[j] = temp;
                    }
                }
            }
            return mas;
        }


        static void Myarray(params int[] myarray)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            Random nums = new Random();
            myarray = new int[n];
            int sum = 0, proud = 1, average;
            for (int i = 0; i < myarray.Length; i++)
            {
                myarray[i] = nums.Next();
                Console.WriteLine(myarray[i] + " ");
            }
            for (int i = 0; i < myarray.Length; i++)
            {
                sum = sum + myarray[i];
            }
            for (int i = 0; i < myarray.Length; i++)
            {
                proud = proud * myarray[i];
            }
            average = sum / myarray.Length;
            Console.WriteLine(sum + " " + proud + " " + average);
        }


        static void Quadratic()
        {
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());
            double d = b * b - 4 * a * c;
            if (d == 0)
            {
                double x = (-b) / (2 * a);
                Console.WriteLine(x); 
            }
            else if (d < 0)
            {
                Console.WriteLine("У уравнения нет вещественных корней");
            }
            else
            {
                double x1 = ((-b) + Math.Sqrt(d)) / (2 * a);
                double x2 = ((-b) - Math.Sqrt(d)) / (2 * a);
                Console.WriteLine(x1 + " " + x2);
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1");
            Console.WriteLine("Введите коэффициенты квадратного уравнения");
            Quadratic();


            Console.WriteLine("Задание 2");
            int[] array = new int[20];
            Random numbers = new Random();
            for (int i = 0; i < 20; i++)
            {
                array[i] = numbers.Next();
                Console.WriteLine(array[i] + " ");
            }
            Console.WriteLine("Введите любое число из этого массива");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите ещё одно число из этого массива");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int index1 = Array.IndexOf(array, num1);
            int index2 = Array.IndexOf(array, num2);
            int index = array[index1];
            array[index1] = array[index2];
            array[index2] = index;
            Console.WriteLine("Изменённый массив:");
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine(array[i] + " ");
            }


            Console.WriteLine("Задание 3");
            Console.WriteLine("Введите количество чисел");
            int count = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите числа для сортировки:");
            int[] mas = new int[count];
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = Convert.ToInt32(Console.ReadLine());
            }
            BubbleSort(mas);
            Console.WriteLine("После сортировки:");
            for (int i = 0; i < mas.Length; i++)
            {
                Console.WriteLine(mas[i]);
            }


            Console.WriteLine("Задание 4");
            Console.WriteLine("Введите количество элементов");
            Myarray();


            Console.WriteLine("Задание 5");
            bool flag = true;
            while (flag)
            {
                try
                {
                    Console.WriteLine("Введите число от 0 до 9");
                    string str = Console.ReadLine();
                    if (str == "exit" || str == "выйти")
                    {
                        flag = false;
                        continue;
                    }
                    int number = Convert.ToInt32(str);
                    if (number < 0 || number > 9)
                    {
                        throw new Exception();
                    }
                    switch (number)
                    {
                        case 0:
                            Console.WriteLine("#####\n#   #\n#   #\n#   #\n#####");
                            break;
                        case 1:
                            Console.WriteLine("#\n#\n#\n#\n#");
                            break;
                        case 2:
                            Console.WriteLine("####\n   #\n####\n#   \n####");
                            break;
                        case 3:
                            Console.WriteLine("####\n   #\n####\n   #\n####");
                            break;
                        case 4:
                            Console.WriteLine("#  #\n#  #\n####\n   #\n   #");
                            break;
                        case 5:
                            Console.WriteLine("####\n#   \n####\n   #\n####");
                            break;
                        case 6:
                            Console.WriteLine("####\n#   \n####\n#  #\n####");
                            break;
                        case 7:
                            Console.WriteLine("####\n   #\n  ####\n   #\n   #");
                            break;
                        case 8:
                            Console.WriteLine("####\n#  #\n####\n#  #\n####");
                            break;
                        case 9:
                            Console.WriteLine("####\n#  #\n####\n   #\n####");
                            break;
                        default:
                            break;
                    }
                }
                catch (Exception)
                {
                    Console.Clear();
                    for (int i = 0; i < 1008; i++)
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.Write("Ошибка");
                    }
                    Thread.Sleep(3000);
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.Clear();
                }
            }
            Console.ReadKey();
        }
    }       
}
