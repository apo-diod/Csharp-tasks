using System;

namespace LambdaDelegate
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            VideoStore vs = new VideoStore("Hello world");
            vs.AddCassete(new Cassete("StarWars", "action", "USA", "none", 3));
            vs.AddCassete(new Cassete("StarWarsII", "action", "USA", "none", 5));
            vs.AddCassete(new Cassete("StarWarsIII", "action", "USA", "none", 7));
            vs.AddCassete(new Cassete("StarWarsIV", "action", "USA", "none", 4));
            vs.AddCassete(new Cassete("StarWarsV", "action", "USA", "none", 2));
            vs.AddCassete(new Cassete("StarWarsVI", "action", "USA", "none", 10));
            foreach (Cassete cas in vs.ChooseCassetes(x => x.Timestamp + 5 <= 10))
            {
                Console.WriteLine($"Cassete: {cas.Name} Client: {cas.Client} Timestamp: {cas.Timestamp}");
            }
        }
    }
}
