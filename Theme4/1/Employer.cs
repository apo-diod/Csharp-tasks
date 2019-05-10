using System;
using System.Collections.Generic;
using System.Linq;
namespace AgregationArray
{
    public class Employer
    {
        private List<Employee> Employees;
        private int budget;
        private int maxEmployees;

        public Employer(int n, int budg)
        {
            budget = budg;
            maxEmployees = n;
        }

        public bool Zap(Employee empl)
        {
            if (maxEmployees > Employees.Count && budget-empl.Money >= 0)
            {
                Employees.Add(empl);
                budget -= empl.Money;
                return true;
            }
            return false;
        }

        public void Attest(int lvl, int percent) => Employees.ForEach(x =>
        {
            if (x.Level > lvl && budget - (x.Money*(100/percent)) >= 0 )
                x.Money += x.Money * (100 / percent);
        });

        public string ToStr()
        {
            string res = $"Бюджет: {budget}| Максимальное кол-во работников: {maxEmployees}";
            foreach(Employee empl in Employees)
            {
                res += empl.ToStr() + "\n";
            }
            return res;
        }
    }
}
