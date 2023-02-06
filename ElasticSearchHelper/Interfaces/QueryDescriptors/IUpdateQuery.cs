namespace ElasticSearchHelper.Domain.Interfaces.QueryDescriptors
{
    public interface IUpdateQuery<T> where T : class
    {
        void UpdateDocument(object doc);
        void EnableElasticShardRefresh();
        void EnableDocAsUpsert();
    }
}
