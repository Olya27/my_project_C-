using System;

namespace zykly_metanit
{
    class Program
    {
        static void Main(string[] args)
        {
            //metanit_1
            //Console.Write("Введіть суму внеску ");
            //decimal sum = Convert.ToDecimal(Console.ReadLine());
            //Console.Write("Введіть кількість місяців  ");
            //int n = Convert.ToInt32(Console.ReadLine());
            
            //for (int i = 0; i <= n; i++)
            //{
            //    sum = sum * 1.07M;
            //}
            //Console.WriteLine($"Через {n} місяців сума становитиме {sum}");
            //Console.ReadKey();

            //metanit_3
            //for (int i = 1; i <= 10; i++)
            //{
            //    for(int j = 1; j <= 10; j++)
            //    {
            //        int result = i * j;
            //        Console.WriteLine($"{i}*{j}={result}");
            //    }
            //}

            //metanit_3
            //Console.Write("Введіть суму внеску ");
            //decimal sum1 = Convert.ToDecimal(Console.ReadLine());
            //Console.Write("Введіть кількість місяців  ");
            //int n1 = Convert.ToInt32(Console.ReadLine());
            //int i1 = 0;

            //while (i1<=n1)
            //{
            //    sum = sum * 1.07M;
            //    i1 += 1;
            //}
            //Console.WriteLine($"Через {n} місяців сума становитиме {sum}");
            //Console.ReadKey();

            //metanit_4
            int num1;
            int num2;
            do
            {
                Console.Write("Введіть а");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введіть b");
                num2 = Convert.ToInt32(Console.ReadLine());
            }
            while (num1 < 0 || num1 > 10 || num2 < 0 || num2 > 10);
            int res = num2 * num1;
            Console.WriteLine($"{num1}*{num2}={res}");
        }
    }
}
