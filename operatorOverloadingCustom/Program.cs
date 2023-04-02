using System;

namespace awesome
{
    public class newClass
    {
        public int coolNumber { get; set; }

        // binary
        public static newClass operator +(newClass a, newClass b)
        {
            newClass c = new newClass();
            c.coolNumber = a.coolNumber + b.coolNumber;
            return c;
        }

        // comparison
        public static bool operator <(newClass a, newClass b)
        {
            bool result = false;
            if (a.coolNumber < b.coolNumber)
                result = true;
            return result;
        }

        public static bool operator >(newClass a, newClass b)
        {
            bool result = false;
            if (a.coolNumber > b.coolNumber)
                result = true;
            return result;
        }

        // unary
        public static newClass operator -(newClass a)
        {
            a.coolNumber = -a.coolNumber;
            return a;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            newClass ClassA = new newClass();
            newClass ClassB = new newClass();
            ClassA.coolNumber = 1;
            ClassB.coolNumber = 2;

            Console.WriteLine((ClassA.coolNumber + ClassB.coolNumber));
            Console.WriteLine((-ClassA.coolNumber));
            Console.WriteLine((ClassA.coolNumber < ClassB.coolNumber));
            Console.WriteLine((ClassA.coolNumber > ClassB.coolNumber));
        }
    }
}
