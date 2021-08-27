using TrackAndTraceDojo;
using Xunit;
using NSubstitute;

namespace TrackAndTraceDojoTests
{
    public class DojoHandlerTest
    {
        private readonly DojoHandler _sut;

        public DojoHandlerTest()
        {
            _sut = new DojoHandler();
        }
        
        [Fact]
        public void GetsTheListOfNames()
        {
            var result = _sut.GetNames();

            Assert.Equal(7, result.Count);
        }

        [Fact]
        public void 
    }
}