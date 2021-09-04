using GimmeBooks.ViewModels.AppObjects;
using System;

namespace GimmeBooks.ViewModels
{
    public interface IEntity<T>
    {
        T Id { get; set; }
    }

    public class EntityBase_vw<T>
    {
        public T Id { get; set; }
        //public long CreaterId { get; set; }
        //public long? ModifierId { get; set; }

        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }

        //public virtual UserApp_vw CreatedBy { get; set; }
        //public virtual UserApp_vw ModifiedBy { get; set; }
    }
}
