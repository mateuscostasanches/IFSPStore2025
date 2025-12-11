
namespace IFSPStore.Domain.Base
{
    public interface IBaseRepository<TEntity> where TEntity : IBaseEntity
    {

        void CleanChageTracker();
        void AttachObject(object obj);
        void Insert(TEntity obj);
        void Update(TEntity obj);
        void Delete(object id);
        IList<TEntity> Select(IList<string>? includes = null);
        TEntity Select(object id, IList<string>? includes = null);

    }

}
