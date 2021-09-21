using System;
using System.Collections.Generic;
using System.Linq;

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
        List<string> Randomize();
    }

    public class Sort : ISort
    {
        public List<string> Randomize()
        {
            List<RamdomNames> names = new List<RamdomNames>();
            Random random = new Random();

            DojoHandler.GetNames().ForEach(x => names.Add(new RamdomNames { Id = Guid.NewGuid(), Name = x }));

            var list = names.OrderBy(i => i.Id).Select(x => x.Name).ToList();

            return list;
        }
    }
}