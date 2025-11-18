namespace IFSPStore.Domain.Base
{
    public abstract class BaseEntity<TId> : IBaseEntity
    {
        public BaseEntity()
        {

        }

        public BaseEntity(TId id)
        {
            Id = id;
        }
        public TId Id { get; set; }

        public string Nome;

    }
}
