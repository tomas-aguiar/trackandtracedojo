using System;
using System.Collections.Generic;

namespace TrackAndTraceDojo
{
    public class DojoHandler
    {
        public static List<string> GetNames() => new List<string>
            {"Tomás", "Lucas", "Samuel", "Henrique", "Saulo", "Caio", "Diego"};
    }

    public class RamdomNames
    {
        public Guid Id;
        public string Name;
    }

    public interface ISort
    {
        List<RamdomNames> Randomize();
    }

    public class Sort : ISort
    {
        public List<RamdomNames> Randomize()
        {
            List<RamdomNames> names = new List<RamdomNames>();
            Random random = new Random();
            
            DojoHandler.GetNames().ForEach(x => names.Add(new RamdomNames {Id = Guid.NewGuid(), Name = x }));
            
            

            return names;
        }
    }
}