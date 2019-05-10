using System;

namespace Entry_Exams
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите кол-во бюджетных мест:");
            int countOfBudget = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите кол-во контрактных мест:");
            int countOfContract = int.Parse(Console.ReadLine());
            Faculty faculty = new Faculty("Applied science", countOfBudget, countOfContract);
            int i = 1;
            while (faculty.CanAddToBudget)
            {
                faculty.addToBudget(new Entrant(i + "", i % 2 != 0));
                i++;
            }
            Console.WriteLine("Бюджетные места кончились!");
            while (faculty.CanAddToContract)
            {
                if (i % 2 != 0)
                    faculty.addToContract(new Entrant(i + "", i % 2 != 0));
                i++;
            }
            Console.WriteLine("Контрактные места кончились");
            Console.WriteLine("Набор учеников закончился");
        }
    }
}
