namespace NI.Core.Data
{
    public interface IDataSourceFactory
    {
        IDataSource Create(string dataSourceName);
    }
}