using System;
using System.Collections.Generic;

namespace TrackAndTraceDojo
{
    public class DojoHandler
    {
        public List<string> GetNames() => new List<string> { "Tomás", "Lucas", "Samuel", "Henrique", "Saulo", "Caio", "Diego" };
    }

    public class RamdomNames
    {
        public int id;
        public string name;
    }

    public interface ISort
    {
        List<string> Randomize();
    }
    public class Sort : ISort
    {
        public List<string> Randomize()
        {
            List<RamdomNames> names = new List<RamdomNames>();
            Random random = new Random();
            RamdomNames name = new RamdomNames();
            name.id = 
            names.Add( random.
            throw new NotImplementedException();
        }
    }
}