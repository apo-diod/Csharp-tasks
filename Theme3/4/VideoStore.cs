using System;
using System.Collections.Generic;
using System.Linq;
namespace LambdaDelegate
{
    public class VideoStore
    {
        public readonly string Name;
        private static readonly List<Cassete> Cassetes = new List<Cassete>();

        public VideoStore(string name) => Name = name;

        public void AddCassete(Cassete cassete) => Cassetes.Add(cassete);

        public List<Cassete> ChooseCassetes(Func<Cassete, bool> predicate) => Cassetes.Where(predicate).ToList();
    }
}
