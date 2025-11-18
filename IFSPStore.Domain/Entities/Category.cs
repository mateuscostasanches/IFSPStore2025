using IFSPStore.Domain.Base;

namespace IFSPStore.Domain.Entities
{
    public class Category : BaseEntity<int>
    {
        public Category()
        {

        }

        public Category(int id, string name) : base(id)
        {
            Name = name;
        }

        public string Name { get; set; }
    }
}
