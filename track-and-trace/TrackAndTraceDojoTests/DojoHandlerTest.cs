using TrackAndTraceDojo;
using Xunit;
using NSubstitute;

namespace TrackAndTraceDojoTests
{
    public class DojoHandlerTest
    {
        private readonly DojoHandler _sut;
        private readonly Sort _sort;

        public DojoHandlerTest()
        {
            _sut = new DojoHandler();
            _sort = new NSubstitute(Sort);
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
            var sut = _sort.Random();
        }
    }
}