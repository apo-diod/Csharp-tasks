using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theme4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            Employer empl = new Employer(4, rand.Next(1000, 3000));
            for (int i = 0; i < 4; i++)
            {
                Employee e = new Employee($"Employee{i}", rand.Next(4, 10));
                empl.Zap(e);
            }
            empl.Attest(5, 20);
            Console.WriteLine(empl.ToStr());
            Console.ReadKey();
        }
    }
}
