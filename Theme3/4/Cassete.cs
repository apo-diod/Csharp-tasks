using System;
namespace LambdaDelegate
{
    public class Cassete
    {
        public readonly string Name, Genre, Country, Client;
        public readonly int Timestamp;

        public Cassete(string name, string genre, string country, string client, int timestamp)
        {
            Name = name;
            Genre = genre;
            Country = country;
            Client = client;
            Timestamp = timestamp;
        }
    }
}
