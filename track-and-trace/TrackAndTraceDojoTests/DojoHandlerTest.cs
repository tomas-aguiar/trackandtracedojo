using TrackAndTraceDojo;
using Xunit;
using NSubstitute;
using System.Collections.Generic;

namespace TrackAndTraceDojoTests
{
    public class DojoHandlerTest
    {
        private readonly DojoHandler _sut;
        private readonly ISort _sort;

        public DojoHandlerTest()
        {
            _sort = Substitute.For<ISort>();
        }
        
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

            List<RamdomNames> namesList = _sort.Randomize();

            _sort.Received(1).Randomize();
            Assert.NotEqual(names, namesList);
        }
    }
}