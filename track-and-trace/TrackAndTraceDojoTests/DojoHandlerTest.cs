using TrackAndTraceDojo;
using Xunit;
using NSubstitute;
using System.Collections.Generic;

namespace TrackAndTraceDojoTests
{
    public class DojoHandlerTest
    {
        private readonly DojoHandler _sut;
        
        
        [Fact]
        public void GetsTheListOfNames()
        {
            var result = DojoHandler.GetNames();

            Assert.Equal(7, result.Count);
        }

        [Fact]
        public void GetListOfRandomNames()
        {
            List<string> names = new List<string>();
            names.Add("name1");
            names.Add("name2");

            var namesList = Sort.Randomize(names);

            Assert.NotEqual(names, namesList);
        }
    }
}