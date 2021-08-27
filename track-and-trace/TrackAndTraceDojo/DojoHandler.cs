using System.Collections.Generic;

namespace TrackAndTraceDojo
{
    public class DojoHandler
    {
        public List<string> GetNames()
        {
            List<string> names = new();
            names.Add("Tomás");
            names.Add("Lucas");
            names.Add("Samuel");
            names.Add("Henrrique");
            names.Add("Saulo");
            names.Add("Caio");
            names.Add("Diego");

            return names;
        }
    }
}