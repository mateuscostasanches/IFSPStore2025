
namespace IFSPStore.Domain.Base
{
    public abstract class BaseEntity<TId> : IBaseEntity
    {

        #region Constructors
        public BaseEntity()
        {

        }

        public BaseEntity(TId id)
        {
            Id = id;
        }
        #endregion 

        public TId Id { get; set; }

    }
}
