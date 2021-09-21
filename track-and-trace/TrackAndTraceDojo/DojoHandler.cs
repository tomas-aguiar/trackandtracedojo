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

    public static class Sort
    {
        public static List<string> Randomize(List<string> namesList)
        {
            List<string> list;
            do
            {
                List<RamdomNames> names = new List<RamdomNames>();
                namesList.ForEach(x => names.Add(new RamdomNames {Id = Guid.NewGuid(), Name = x}));
                list = names.OrderBy(i => i.Id).Select(x => x.Name).ToList();
            } while (list == namesList);
            

            return list;
        }
    }
}