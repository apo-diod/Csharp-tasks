using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theme4._2
{
    class Employer
    {
        private LinkedList<Employee> employees = new LinkedList<Employee>();
        private int budget;
        private int maxN;
        public Employer(int n, int b)
        {
            maxN = n;
            budget = b;
        }
        public bool Zap(Employee e)
        {
            if(e.salary <= budget && employees.Count < maxN)
            {
                budget -= e.salary;
                employees.AddLast(e);
                return true;
            }
            return false;
        }
        public void Attest(int l, int percent)
        {
            foreach (Employee e in employees)
            {
                double per = ((double)percent) / 100;
                if(e.level > l && budget >= e.salary * per)
                {
                    budget -= (int)(e.salary * per);
                    e.salary = (int)( e.salary + e.salary * per);
                }
            }
        }
        public string ToStr()
        {
            string res = $"{budget}\n";
            foreach(Employee e in employees)
            {
                res += e.ToStr;
                res += "\n";
            }
            return res;
        }
    }
}
