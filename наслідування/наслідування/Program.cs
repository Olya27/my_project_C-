using System;

namespace наслідування
{

    public abstract class Animal
    {
        public float Weight { get; set; }
        public string Color { get; set; }

        public Animal(string color, float weight)
        {
            Color = color;
            Weight = weight;
        }

        public abstract string MakeSound();
    }

    public abstract class AnimalWithTail : Animal
    {
        public float TailLenght { get; set; }
        public AnimalWithTail(string color, float weight, float tailLenght) : base(color, weight)
        {
            Color = color;
            Weight = weight;
            TailLenght = tailLenght;
        }
    }


    public class Cat : AnimalWithTail
    {
        public Cat(string color, float weight, float tailLenght) : base(color, weight, tailLenght)
        {
            Color = color;
            Weight = weight;
            TailLenght = tailLenght;
        }

        private string purr()
        {
            return "purrrr";
        }
        private string meow()
        {
            return "meow";
        }

        public override string MakeSound()
        {
            return meow() + purr();
        }


        public override string ToString()
        {
            return "This is a Cat," + Color + " " + Weight + " " + TailLenght;
        }
    }

    public class Dog : AnimalWithTail
    {
        public Dog(string color, float weight, float tailLenght) : base(color, weight, tailLenght)
        {
            Color = color;
            Weight = weight;
            TailLenght = tailLenght;

        }


        public override string MakeSound()
        {
            return "woof";
        }


        public override string ToString()
        {
            return "This is a dog," + Color + " " + Weight + " " + TailLenght;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
