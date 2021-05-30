using System;

namespace Class
{

    class Person
    {
        public int a;
        public int b;
        private bool square;

        public int A
        {
            get
            {
                return a;
            }
            set
            {
                a = value;
            }
        }
        public int B
        {
            get
            {
                return b;
            }
            set
            {
                b = value;
            }
        }
        private bool Square
        {
            set
            {
                if (a == b)
                {
                    square = true;
                }
                else
                {
                    square = false;
                }
            }
        }


        public class Cat
        {
            readonly string Name;
            static readonly double MaxEnergy;

        }

        public void PrintInfo()
        {
            Console.WriteLine($"Довжина: {a}  Висота: {b}");
        }
        public void Perimeter()
        {
            int perim = 2 * a + 2 * b;
            Console.WriteLine($"Периметр= {perim}");
        }

        public void Area()
        {
            int area = a * b;
            Console.WriteLine($"Площа={area}");
        }


        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Hello World!");
            }
        }
    }

}
