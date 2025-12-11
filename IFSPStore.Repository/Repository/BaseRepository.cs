
using IFSPStore.Domain.Base;
using IFSPStore.Repository.Context;
using Microsoft.EntityFrameworkCore;

namespace IFSPStore.Repository.Repository
{

    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : BaseEntity<int>
    {

        #region Variables
        protected IFSPStoreContext _mySqlContext;
        #endregion

        #region Methods database
        public BaseRepository(IFSPStoreContext mySqlContext)
        {
            _mySqlContext = mySqlContext;
        }

        public void AttachObject(object obj)
        {
            _mySqlContext.Attach(obj);
        }

        public void CleanChageTracker()
        {
            _mySqlContext.ChangeTracker.Clear();
        }

        public void Insert(TEntity obj)
        {
            _mySqlContext.Set<TEntity>().Add(obj);
            _mySqlContext.SaveChanges(); 
        }

        public void Update(TEntity obj)
        {    
            _mySqlContext.Entry(obj).State = EntityState.Modified;
            _mySqlContext.SaveChanges();
        }

        public void Delete(object id)
        {
            _mySqlContext.Set<TEntity>().Remove(Select(id));
            _mySqlContext.SaveChanges();
        }

        public IList<TEntity> Select(IList<string>? includes = null)
        {
            var dbContext = _mySqlContext.Set<TEntity>().AsQueryable();
            if(includes != null)
            {
                foreach(var include in includes)
                {
                    dbContext = dbContext.Include(include);
                }
            }
            return dbContext.ToList();
        }

        public TEntity Select(object id, IList<string>? includes = null)
        {
            var dbContext = _mySqlContext.Set<TEntity>().AsQueryable();
            if (includes != null)
            {
                foreach (var include in includes)
                {
                    dbContext = dbContext.Include(include);
                }
            }
            return dbContext.ToList().Find(x => x.Id == (int)id);
        }
        #endregion 

    }

}
