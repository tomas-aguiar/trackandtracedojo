using System.Collections.Generic;

namespace TrackAndTraceDojo
{
    public class DojoHandler
    {
        public List<string> GetNames() => new List<string> { "Tomás", "Lucas", "Samuel", "Henrique", "Saulo", "Caio", "Diego" };
    }


    public interface ISort
    {
        List<string> Randomize();
    }
    public class Sort : ISort
    {

    }
}