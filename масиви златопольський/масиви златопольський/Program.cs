using System;
using System.Linq;

namespace масиви_златопольський
{
    public class tasks
    {
        public static void task1()
        {
            //11.4
            int[] age = new int[12];
            Random rnd = new Random();
            for (int i = 0; i < 12; i++)
            {
                age[i] = rnd.Next(163, 190);
            }
            foreach(var i in age)
            {
                Console.WriteLine(i);
            }
        }

        public static void task2()
        {
            //11.28
            int[] aaa = { 1, 3, 22, -4, -10, 3 };
            int summ = 0;
            for (int i = 0; i < 6; i++)
            {
                summ = summ + aaa[i];
            }
            if (summ > 0)
            {
                Console.WriteLine("Сума більша 0");
            }
        }
        public static void task2_Sasha()
        {
            int[] aaa = { 1, 3, 22, -4, -10, 3 };
            int summ = aaa.Sum(); 
            if (summ > 0) Console.WriteLine("Сума більша 0");
        }
        public static void task3()
        {
            //11.39
            int[] kkk = { 5, 2, 7, 6, 4, 5, 1, 3, 9, 8, 10, 12, 15, 13, 6 };
            for (int i = 0; i <= kkk.Length; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write($"{kkk[i]} ");
                }
            }
            for (int j = 0; j <= kkk.Length; j++)
            {
                if (j % 3 == 0)
                {
                    Console.Write($"{kkk[j]} ");
                }
            }
        }

        public static void task3_Sasha()
        {
            //11.39
            int[] kkk = { 5, 2, 7, 6, 4, 5, 1, 3, 9, 8, 10, 12, 15, 13, 6 };
            var res1 = kkk.Select((item, index) => new { Item = item, Index = index })
                .Where(n => n.Index % 2 == 0).Select(n => n.Item);
            foreach(var i in res1)
            {
                Console.WriteLine(i);
            }
        }
        public static void task4()
        {
            //11.63
            int[] kkk1 = { 5, 2, -7, 6, -4, 5, 1, 3, -9, 8, 10, -12, -15, 13, 6 };
            int sum11 = 0;
            for (int i1 = 0; i1 <= kkk1.Length-1; i1++)
            {
                if (i1 >= 0)
                {
                    sum11 = sum11 + kkk1[i1];
                }
            }
            Console.WriteLine($"сума невідємних елементів {sum11}");
        }

        public static void task4_Sasha()
        {
            //11.63
            int[] kkk1 = { 5, 2, -7, 6, -4, 5, 1, 3, -9, 8, 10, -12, -15, 13, 6 };
            int res = kkk1.Where(x => x >= 0).Select(x => x).ToArray().Length;
            Console.WriteLine($"сума невідємних елементів {res}");
        }

        public static void task5_Sasha()
        {
            //11.87
            int[] kkk1 = { 5, 2, -7, 6, -4, 5, 1, 3, -9, 8, 10, -12, -15, 13, 6, 6, 6, 6, 6, 6, 6, 6, };
            var man = kkk1.Where(x => x < 0).Select(x => x).Average();
            var woman = kkk1.Where(x => x > 0).Select(x => x).Average();
            Console.WriteLine($"man {man},woman {woman}");
        }

        public static void task6_Sasha()
        {
            //11.111
            int[] kkk1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25 };
            var res = kkk1.Max();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            tasks.task5_Sasha();
            

            

            

            



        }
    }
}
