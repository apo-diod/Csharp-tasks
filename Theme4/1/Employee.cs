using System;
using System.Collections.Generic;
namespace AgregationArray
{
    public class Employee
    {
        public Employee(string n, int lvl)
        {
            Name = n;
            Level = lvl;
            Money = Level * 100;
        }

        public string Name { get; }

        public int Level { get; }

        public int Money { get; set; }

        public string ToStr()
        {
            return Name + ": level = " + Level + "| Salary = " + Money;
        }
    }
}
