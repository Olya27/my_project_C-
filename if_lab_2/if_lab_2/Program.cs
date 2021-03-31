using System;

namespace if_lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //metanit_1
            Console.Write("Введіть число  ");
            decimal a = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Введіть число  ");
            decimal b = Convert.ToDecimal(Console.ReadLine());

            if (a == b)
            {
                Console.WriteLine($"{a} рівне {b}");
            }
            else if (a > b)
            {
                Console.WriteLine($"{a} більше {b}");
            }
            else if (a < b)
            {
                Console.WriteLine($"{a} менше {b}");
            }

            //metanit_2
            Console.Write("Введіть число  ");
            decimal k = Convert.ToDecimal(Console.ReadLine());
            if (k > 5 && k < 10)
            {
                Console.WriteLine("число між 5 і 10");
            }
            else
            {
                Console.WriteLine("невідоме число");
            }

            //metanit_3
            Console.Write("Введіть число  ");
            decimal c = Convert.ToDecimal(Console.ReadLine());

            if (c == 5 || c==10)
            {
                Console.WriteLine($"число рівне 5 або 10");
            }
            else 
            {
                Console.WriteLine($"невідоме число");
            }

            //metanit_4
            Console.Write("Введіть суму вкладу  ");
            decimal d = Convert.ToDecimal(Console.ReadLine());
            decimal g = 0;
            if (d < 100)
            {
                const decimal v = 5 / 100;
                g = g * v;
            }
            else if (d < 200 && d > 100) 
            {
                const decimal v = 7 / 100;
                g = g * v;
            }
            else if (d > 200)
            {
                const decimal v = 1 / 10;
                g = g * v;
            }
            d = d * g;
            Console.WriteLine($"{d}");


            //metanit_5
            Console.Write("Введіть суму вкладу  ");
            decimal d1 = Convert.ToDecimal(Console.ReadLine());
            decimal g1 = 0;
            if (d1 < 100)
            {
                const decimal v = 5 / 100;
                g1 = g1* v + 15 ;
            } 
            else if (d1 < 200 && d > 100)
            {
                const decimal v = 7 / 100;
                g1 = g1 * v + 15;
            }
            else if (d1 > 200)
            {
                const decimal v = 1 / 10;
                g1 = g1 * v + 15;
            }
            d1 = d1 * g;
            Console.WriteLine($"{d1}");

            //metanit_6

        }
    }
}
