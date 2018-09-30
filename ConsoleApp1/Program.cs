using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*      Здравствуйте!
    Я немного не понял, как именно требовалось вводить данные в задании, поэтому реализовал 2 способа. Исключительно для удобства проверяющему все сделано в одной программе. Спасибо!
 */
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int q;
            Console.WriteLine("Введите 1, если хотите вводить числа через пробел, введите 2, если через Enter");
            q = int.Parse(Console.ReadLine());
            // Способ ввода через пробел
            if (q == 1)
            {
                Console.WriteLine("Введите 10 чисел через пробел");
                string t = Console.ReadLine();
                string[] splitString = t.Split(' ');
                double[] y = new double[10];
                for (int i = 0; i < 10; i++)
                {
                    double x;
                    double.TryParse(splitString[i], out x);
                    y[i] = x;
                }
                Console.WriteLine("Исходный массив");
                for (int i = 0; i < 10; i++)
                {
                    Console.Write(y[i]);
                    Console.Write(" ");
                }
                Console.WriteLine();
                double s;
                for (int k = 0; k < 10; k++)
                {
                    for (int i = 0; i < 9; i++)
                        if (y[i] > y[i + 1])
                        {
                            s = y[i];
                            y[i] = y[i + 1];
                            y[i + 1] = s;
                        }
                }
                Console.WriteLine("Полученный массив");
                for (int i = 0; i < 10; i++)
                {
                    Console.Write(y[i]);
                    Console.Write(" ");
                }
                Console.ReadLine();
            }
            else
            {
                // Способ ввода через Enter
                if (q == 2)
                {
                    double[] y = new double[10];
                    for (int i = 0; i < 10; i++)
                        y[i] = double.Parse(Console.ReadLine());
                    Console.WriteLine("Исходный массив");
                    for (int i = 0; i < 10; i++)
                    {
                        Console.Write(y[i]);
                        Console.Write(" ");
                    }
                    Console.WriteLine();
                    double s;
                    for (int k = 0; k < 10; k++)
                    {
                        for (int i = 0; i < 9; i++)
                            if (y[i] > y[i + 1])
                            {
                                s = y[i];
                                y[i] = y[i + 1];
                                y[i + 1] = s;
                            }
                    }
                    Console.WriteLine("Полученный массив");
                    for (int i = 0; i < 10; i++)
                    {
                        Console.Write(y[i]);
                        Console.Write(" ");
                    }
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Вы ввели не то число");
                    Console.ReadLine();
                }
               
            }
        }
    }
}
