using System;
using System.Threading.Tasks;
using NI.Core.Data;
using NI.Data.DataSource;
using Xunit;

namespace Ni.Tests
{
    public class DataSourceTests
    {
        [Fact]
        public async Task StackOverflow_Test()
        {
            var factory = CreateFactory();
            var dataSource = factory.Create(DataSourceName.StackOverflow);
            var result = await dataSource.FetchAsync();

            Assert.True(result.Count > 0);

        }

        [Fact]
        public async Task GitHub_Test()
        {
            var factory = CreateFactory();
            var dataSource = factory.Create(DataSourceName.Github);
            var result = await dataSource.FetchAsync();

            Assert.True(result.Count > 0);
        }


        private static IDataSourceFactory CreateFactory()
        {
            return new DataSourceFactory();
        }
    }
}
