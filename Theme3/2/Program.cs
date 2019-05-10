using System;

namespace Classes_overload_soution
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Sequence seq1 = new Sequence(10, 1, 2);
            seq1.Print();
            Console.WriteLine(seq1.CountOfPositive);
            Console.WriteLine(seq1.MultBetw());
            Sequence seq2 = new Sequence(Console.ReadLine());
            seq2.Print();
            Console.WriteLine(seq2.CountOfPositive);
            Console.WriteLine(seq2.MultBetw());
        }
    }
}
