using System;
using System.Collections.Generic;
namespace Entry_Exams
{
    public class Faculty
    {

        private int budget_count, contract_count;
        public string Name;
        private LinkedList<Entrant> budgetEntrants, contractEntrance;
        public Faculty(string name, int budget_count, int contract_count)
        {
            this.budget_count = budget_count;
            this.contract_count = contract_count;
            Name = name;
            budgetEntrants = new LinkedList<Entrant>();
            contractEntrance = new LinkedList<Entrant>();
        }

        public void addToBudget(Entrant entr)
        {
            budgetEntrants.AddLast(entr);
            Console.WriteLine($"Добавлен ученик {entr.Name} на бюджет");
        }
        public bool CanAddToBudget => budget_count != budgetEntrants.Count;

        public void addToContract(Entrant entr)
        {
            contractEntrance.AddLast(entr);
            Console.WriteLine($"Добавлен ученик {entr.Name} на контракт");
        }
        public bool CanAddToContract => contract_count != contractEntrance.Count;
    }
}
