using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections;

namespace if_const
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] x = new int[] {1, 2, 1, 10, 9 };
            object p = x;
            Array.Sort(x);
            int i = 0;
            bool r;
            int k = 0;
            while (i < x.Length-1)
            {
                k = x[i + 1] - x[i] <= 0 ? k+=1 : k;
                i++;
            }
            if (k > 0) r = false;
            else r = true;
            Console.WriteLine(r);
            
        }
    }
}
