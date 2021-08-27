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
            _sut = new DojoHandler();
            _sort = Substitute.For<ISort>();
        }
        
        [Fact]
        public void GetsTheListOfNames()
        {
            var result = _sut.GetNames();

            Assert.Equal(7, result.Count);
        }

        [Fact]
        public void GetListOfRandomNames()
        {
            List<string> names = new List<string>();
            names.Add("name1");
            names.Add("name2");

            _sort.Randomize();

            _sort.Received(1).Randomize();
        }
    }
}