using System;
namespace Ecommerce.Shared.Domain
{
    public abstract class BaseEntity
    {
        public int Id { get; private set; }

        public bool IsDeleted { get; private set; }

        public DateTime Created { get; private set; }

        public DateTime Modified { get; private set; }

        public void Delete()
        {
            IsDeleted = true;
        }

        public void SetCreatedDate()
        {
            if (Created == default)
                Created = DateTime.Now;
        }

        public void SetModifiedDate()
        {
            Modified = DateTime.Now;
        }
    }
}