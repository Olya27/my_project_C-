using System;

namespace цикли_златопольський
{
    internal class Program
    
    {
        static void Main(string[] args)


        {
            //Console.Write("Введіть максимальне значення параметру  ");
            //int param1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Введіть мінімальне значення параметру  ");
            //int param = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Введіть крок зміни параметру  ");
            //int crok = Convert.ToInt32(Console.ReadLine());

            //for (int i=param1; i>=param; i=i-crok)
            //{
            //    Console.Write($"  {i}");
            //}

            //5.4
            //Console.WriteLine("Числа");
            //int j = 0;
            //for (int j = 10; j < 26; j=j+1);
            //{
            //    double count1 = j;
            //    Console.Write($"{count1} ");
            //    double c = j + 0.4M;
            //    Console.WriteLine($" {c}");
            //}

            //5.4,b
            //int num = 0;
            //for (int  num = 25; num < 36; num++) ;
            //{
            //    decimal num1 = num;
            //    decimal num2 = num + 0.5M;
            //    decimal num3 = num - 0.2M;
            //    Console.WriteLine($"{num1} {num2} {num3}");

            //}

            //5.28 a
            //int result = 1;
            //for (int i=8; i<=15; i++)
            //{
            //    result = result * i;
            //}
            //Console.WriteLine($"Добуток всіх чисел від 8 до 15 = {result}");

            //5.28 b
            //Console.Write("Введіть значення а від 1 до 20  ");
            //int argg = Convert.ToInt32(Console.ReadLine());
            //long ress = 1;
            //if (argg < 1 || argg > 20)
            //{
            //    Console.WriteLine("Помилка, неприпустиме а");
            //}
            //else
            //{
            //    for (int j = argg; j <= 20; j++)
            //    {
            //        ress = ress * j;
            //    }
            //    Console.WriteLine($"Добуток всіх чисел від {argg} до 20 = {ress}");
            //}

            //5.28 с
            //Console.Write("Введіть значення а від 1 до 20  ");
            //int argg1 = Convert.ToInt32(Console.ReadLine());
            //long ress1 = 1;
            //if (argg1 < 1 || argg1 > 20)
            //{
            //    Console.WriteLine("Помилка, неприпустиме b");
            //}
            //else
            //{
            //    for (int j1 = 1; j1 <= argg1; j1++)
            //    {
            //        ress1 = ress1 * j1;
            //    }
            //    Console.WriteLine($"Добуток всіх чисел від 1 до {argg1} = {ress1}");
            //}

            //5.28 d
            //Console.Write("Введіть значення а ");
            //int arg1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Введіть значення b (більше ніж а) ");
            //int arg2 = Convert.ToInt32(Console.ReadLine());
            //long ress2 = 1;
            //if (arg1>arg2)
            //{
            //    Console.WriteLine("Помилка, неприпустимі параметри");
            //}
            //else
            //{
            //    for (int j2 = arg1; j2 <= arg2; j2++)
            //    {
            //        ress2 = ress2 * j2;
            //    }
            //    Console.WriteLine($"Добуток всіх чисел від {arg1} до {arg2} = {ress2}");
            //}

            //5.52
            //int summ = 0;
            //decimal avarage = 0;
            //for (int q=1; q<=20; q++)
            //{
            //    Console.WriteLine($"Введіть оцінку {q}-го учня");
            //    summ = summ + Convert.ToInt32(Console.ReadLine());
            //}
            //avarage = summ / 20;
            //Console.WriteLine($"Середня оцінка в групі {avarage}");

            //5.76
            //Console.WriteLine("Введіть показник степеня (натуральне число)");
            //int n = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Введіть основу степеня");
            //int l = Convert.ToInt32(Console.ReadLine());
            //long res_st;

            //if (n < 0)
            //{
            //    Console.WriteLine("ERROR");
            //}
            //else
            //{
            //    for (int st=1; st<=n; st++)
            //    {
            //        res_st = n;
            //        for (int st1=1; st1<=st; st1++)
            //        {
            //            res_st = res_st * n;
            //        }
            //        Console.WriteLine($"{l}^{n}={res_st}");
            //    }
            //}

            //6.4

            //Console.Write(" Введіть перше число послідовності");
            //decimal number = Convert.ToInt32(Console.ReadLine());
            //int counter=0;
            //while (number < 0)
            //{
            //    counter++;
            //    number++;
            //}
            //Console.WriteLine($"у послідовності {counter} відємних чисел");

            ////6.28
            ////Console.Write("Введіть число");
            ////int numb = Convert.ToInt32(Console.ReadLine());
            ////int ost = numb%10;
            ////decimal numb1 = numb;
            ////int rr = 1;
            ////int max = -1;
            ////int min = 9;
            ////while (ost > 0)
            ////{
            ////    numb1 = Math.Floor(ost);
            ////    if ost
            ////    rr++;

            ////}

            //6.52
            //Console.Write("Введіть число");
            //int pr = Convert.ToInt32(Console.ReadLine());
            //int iii = 2;
            //bool resultt1 = true;
            //while (iii < pr)
            //{
            //    if (pr % iii != 0)
            //    {
            //        resultt1 = true;
            //    }
            //    else if(pr % iii == 0)
            //    {
            //        resultt1 = false;
            //        Console.WriteLine($"{pr} не є простим числом");
            //        break;
            //    }
            //    iii++;
            //}
            //if (resultt1 == true)
            //{
            //    Console.WriteLine($"{pr} просте число");
            //}

            //6.76 a
            //    Console.Write("Введіть число");
            //    int st = Convert.ToInt32(Console.ReadLine());
            //    var cha = st;
            //    bool bb = true;
            //    int schetchik = 0;
            //    while (cha / 3 >= 1)
            //    {
            //        if (cha % 3 == 0)
            //        {
            //            cha = cha / 3;
            //            bb = true;
            //            schetchik++;
            //        }
            //        else if (cha % 3 != 0)
            //        {
            //            bb = false;
            //            break;
            //        }

            //    }
            //    if (bb == true && cha == 1)
            //    {
            //        Console.WriteLine($"{st} є 3 в {schetchik} степені");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{st} не є степенем 3");
            //    }



            //6.76 b
            //Console.Write("Введіть число ");
            //int st = Convert.ToInt32(Console.ReadLine());
            //var cha = st;
            //bool bb = true;
            //int schetchik = 0;
            //while (cha / 5 >= 1)
            //{
            //    if (cha % 5 == 0)
            //    {
            //        cha = cha / 5;
            //        bb = true;
            //        schetchik++;
            //    }
            //    else if (cha % 5 != 0)
            //    {
            //        bb = false;
            //        break;
            //    }

            //}
            //if (bb == true && cha == 1)
            //{
            //    Console.WriteLine($"{st} є 5 в {schetchik} степені");
            //}
            //else
            //{
            //    Console.WriteLine($"{st} не є степенем 5");
            //}

            //6.98
            //decimal summm = 1000;
            //decimal percent=1;
            //int i11 = 1;
            //int i22 = 1;

            //while (percent < 30)
            //{
            //    percent = summm * 0.02M;
            //    summm = summm + percent;
            //    i11++;
            //}
            //Console.WriteLine($"відсоток за депозитом перевищить 30 за {i11} місяців");
            //while (summm < 1200)
            //{
            //    percent = summm * 0.02M;
            //    summm = summm + percent;
            //    i22++;
            //}
            //Console.WriteLine($"Сума депозиту перевищить 1200 через {i22} місяців");


        }
    }
}

