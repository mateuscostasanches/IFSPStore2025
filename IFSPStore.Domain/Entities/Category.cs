
using IFSPStore.Domain.Base;

namespace IFSPStore.Domain.Entities
{

    public class Category : BaseEntity<int>
    {

        #region Constructors
        public Category()
        {

        }

        public Category(int id, string name) : base(id)
        {
            Name = name;
        }
        #endregion 

        public string Name { get; set; }
    }

}
