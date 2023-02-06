﻿namespace ElasticSearchHelper.Domain.Interfaces.QueryDescriptors
{
    public interface IBulkQuery<T> where T : class
    {
        void AddCollectionToSave(IEnumerable<T> items, string id);

        void AddCollectionToSaveAnonymous(IEnumerable<T> items);

        void AddCollectionToDelete(IEnumerable<T> items);
    }
}
