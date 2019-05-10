using System;
namespace Entry_Exams
{
    public class Entrant
    {
        public readonly string Name;
        public readonly bool isContract;
        public Entrant(string name, bool contr)
        {
            Name = name;
            isContract = contr;
        }
    }
}
