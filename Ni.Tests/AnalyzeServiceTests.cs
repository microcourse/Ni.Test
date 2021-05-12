using System;
using System.Threading.Tasks;
using NI.Core.Data;
using NI.Core.Services;
using NI.Data.DataSource;
using Ni.Services;
using Ni.Services.Flow;
using Xunit;

namespace Ni.Tests
{
    public class AnalyzeServiceTests
    {
        [Fact]
        public async Task StackOverflow_Test()
        {
            var service = CreateService();
            var result = await service.AnalyzeAsync(DataSourceName.StackOverflow);

            Assert.True(result.Length > 0);

        }

        [Fact]
        public async Task GitHub_Test()
        {
            var service = CreateService();
            var result = await service.AnalyzeAsync(DataSourceName.Github);

            Assert.True(result.Length > 0);
        }

        [Fact]
        public async Task GitHub_Flow_Test()
        {
            var service = CreateService();
            var result = await service.AnalyzeAsync(DataSourceName.Github, 1);

            Assert.True(result.Length > 0);
        }



        private static IAnalyzeService CreateService()
        {
            return new AnalyzeService(
                new DataSourceFactory(),
                new AnalyzeFlowFactory());
        }
    }
}
