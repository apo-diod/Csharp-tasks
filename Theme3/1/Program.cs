using System;

namespace Classes_basic_solution
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Equal function = new Equal(1, 0);
            Console.WriteLine(function.Func(10));
            Console.WriteLine(function.Root());
        }
    }
}
