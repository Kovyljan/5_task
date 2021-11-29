using System;

namespace _5._1_task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 7 (семь) чисел: ");
            double N_1 = Convert.ToDouble(Console.ReadLine());
            double N_2 = Convert.ToDouble(Console.ReadLine());
            double N_3 = Convert.ToDouble(Console.ReadLine());
            double N_4 = Convert.ToDouble(Console.ReadLine());
            double N_5 = Convert.ToDouble(Console.ReadLine());
            double N_6 = Convert.ToDouble(Console.ReadLine());
            double N_7 = Convert.ToDouble(Console.ReadLine());

            double[] array = new double[7] { N_1, N_2, N_3, N_4, N_5, N_6, N_7 };

            Console.WriteLine();
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine(array[i]);
            }
            double sum = N_1 + N_2 + N_3 + N_4 + N_5 + N_6 + N_7;
            Console.WriteLine("Среднее арифмитическое равно {0:f2}", sum / 7);
            Console.ReadKey();
        }
    }
}
