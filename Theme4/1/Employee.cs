using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theme4._2
{
    class Employee
    {
        public readonly string name;
        public int salary;
        public readonly int level;
        public Employee(string n, int l)
        {
            level = l;
            name = n;
            salary = level * 100;
        }
        public string ToStr => $"{name}:{level}:{salary}";
    }
}
