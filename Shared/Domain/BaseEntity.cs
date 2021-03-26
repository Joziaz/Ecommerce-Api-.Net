using System;
namespace api.Shared.Domain
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime Created { get; set; }
        
        public DateTime Modified { get; set; }
    }
}