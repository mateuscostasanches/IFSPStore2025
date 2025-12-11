
using IFSPStore.Domain.Base;

namespace IFSPStore.Domain.Entities
{

    public class City : BaseEntity<int>
    {

        #region Constructors
        public City()
        {

        }

        public City(int id, string name, string state) : base(id)
        {
            Name = name;
            State = state;
        }
        #endregion 

        public string Name { get; set; }
        public string State { get; set; }

    }

}
