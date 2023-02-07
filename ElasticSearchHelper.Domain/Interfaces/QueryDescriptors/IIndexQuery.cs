namespace ElasticSearchHelper.Domain.Interfaces.QueryDescriptors
{
    public interface IIndexQuery<T> where T : class
    {
        void AutoMapIndex();
        void DocumentId(Nest.Id id);
        void UpdateContainers();
    }
}
