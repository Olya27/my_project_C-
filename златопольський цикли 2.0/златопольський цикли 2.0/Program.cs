using System;

namespace златопольський_цикли_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            //int numnum = 0;
            //int qnum = 1;
            //int qnum1 = 1;
            //int rows = 1;
            //do
            //{


            //    do
            //    {
            //        if (numnum < 4)
            //        {
            //            qnum++;
            //            Console.Write($"{numnum++} ");
            //        }
            //        else
            //        {
            //            qnum++;
            //            Console.Write($"{numnum--}");
            //        }
            //        qnum1++;
            //    }

            //    while (qnum < qnum1 && qnum1<6);
            //    rows++;
            //    Console.WriteLine(" ");

            //}
            //while (rows <= 5 );

            //7.28
            //int chyslo = 200;
            //int kst_dilnykiw = 0;
            //int dilnyk = 2;
            //int kst_chysel = 0;
            //do
            //{
            //    dilnyk = 2;
            //    do
            //    {
            //        if (chyslo % dilnyk == 0)
            //        {
            //            kst_dilnykiw++;
            //        }
            //        dilnyk++;
            //    }
            //    while (dilnyk < chyslo);
            //    if (kst_dilnykiw == 6)
            //    {
            //        kst_chysel++;
            //    }
            //    chyslo++;
            //}
            //while (chyslo <= 500);
            //Console.WriteLine($"У проміжку 200-500 {kst_chysel} чисел в яких рівно 6 дільників");

            //7.52
            //int teliata = 1;
            //int byky = 1;
            //int korowa = 1;
            //Random rnd = new Random();
            //do
            //{
            //    teliata = rnd.Next(1, 100);
            //    byky = rnd.Next(1, 100);
            //    korowa = rnd.Next(1, 100);
            //}
            //while (teliata * 0.05M + korowa * 5 + byky * 10 != 100);
            //Console.WriteLine($"потрібно купити {korowa} корів, {teliata} телят i {byky} биків");


            //7.76
            //decimal temp;
            //int rah = 1;
            //int day = 1;
            //decimal min;
            //temp = Convert.ToDecimal(Console.ReadLine());
            //min = temp;
            //do
            //{
            //    temp = Convert.ToDecimal(Console.ReadLine());
            //    if (temp < min)
            //    {
            //        min = temp;
            //        rah = 1;
            //    }
            //    else if (temp == min)
            //    {
            //        rah++;
            //    }
            //    day++;
            //}
            //while (day < 31);
            //Console.WriteLine($"за місяць було {rah} днів з мінімальною температурою");

            //7.98
            Console.Write("введіть n");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("введіть p");
            int p = Convert.ToInt32(Console.ReadLine());
            decimal summ = 0;
            decimal x;
            int n1 = 1;
            Console.WriteLine("Введіть числа");
            do
            {
                x = Convert.ToDecimal(Console.ReadLine());
                n1++;
                if (x > 20.5M)
                {
                    summ = summ + x;
                }
            }
            while (n1 < n);
            if (summ < p)
            {
                Console.WriteLine($"Сума всіх чисел з {n} записаних, які більше 20,5 менша за {p}");
            }
            else
            {
                Console.WriteLine($"Сума більша за {p}");
            }

            //7.122
            int num_min = 1;
            int num_max = 1;
            int quantity = 1;
            Console.WriteLine("Введіть кількість людей у списку");
            int quant = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введіть вік кожної людини в списку");  
            int current_age = Convert.ToInt32(Console.ReadLine());
            int max1 = current_age;
            int min2 = current_age;
            do
            {
                if (current_age < min2)
                {
                    min2 = current_age;
                    num_min = quantity;
                }
                else if (current_age > max1)
                {
                    max1 = current_age;
                    num_max = quantity;
                }
                quantity++;
            }
            while (quant > quantity);
            if (num_max > num_min)
            {
                Console.WriteLine("Найстарша людина в списку пізніше за наймолодшу");
            }
            else if (num_min > num_max)
            {
                Console.WriteLine("Наймолодша людина в списку пізніше за найстаршу");
            }

        }
    }
}
