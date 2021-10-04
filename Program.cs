using System;

namespace BasicClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Forest f1 = new Forest("Amazon");
            Console.WriteLine(f1.Trees);
            f1.Grow();
            Console.WriteLine(f1.Trees);
        }
    }
}
