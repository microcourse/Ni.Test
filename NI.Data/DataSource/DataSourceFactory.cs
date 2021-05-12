using System;
using System.Text;
using NI.Core.Data;
using NI.Data.DataSource.GitHub;
using NI.Data.DataSource.StackOverflow;

namespace NI.Data.DataSource
{
    public class DataSourceFactory : IDataSourceFactory
    {
        public IDataSource Create(string dataSourceName)
        {
            dataSourceName = dataSourceName ?? 
                             throw new ArgumentNullException(nameof(dataSourceName));


            switch (dataSourceName)
            {
                case DataSourceName.Github:
                    return new GithubDataSource();
                    
                case DataSourceName.StackOverflow:
                    return new StackOverflowDataSource();

                default:
                    throw new NotSupportedException(nameof(dataSourceName));
            }
            throw new NotImplementedException();
        }
    }
}
