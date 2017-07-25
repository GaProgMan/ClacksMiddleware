using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using ClacksMiddleware;
using Xunit;

namespace tests
{
    public class GnuTerryPratchettHeaderTests
    {
        private int _onNextCalledTimes;
        private readonly Task _onNextResult = Task.FromResult(0);
        private readonly RequestDelegate _onNext;
        private readonly DefaultHttpContext _context;
        
        public GnuTerryPratchettHeaderTests()
        {
            _onNext = _ =>
            {
                Interlocked.Increment(ref _onNextCalledTimes);
                return _onNextResult;
            };
            _context = new DefaultHttpContext();
        }

        [Fact]
        public async Task Invoke_HeaderIsPresent()
        {
            // arrange
            var secureHeadersMiddleware = new GnuTerryPratchett(_onNext);

            // act
            await secureHeadersMiddleware.Invoke(_context);
            
            // assert
            Assert.True(_context.Response.Headers.ContainsKey(Constants.XClacksOverheadHeaderName));
            Assert.Equal("GNU Terry Pratchett",
                _context.Response.Headers[Constants.XClacksOverheadHeaderName]);
 
        }
    }
}
