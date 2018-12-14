using System;

namespace RareBelief.Infrastructure.Model
{
    public class BaseEntityWithoutId
    {
        public BaseEntityWithoutId()
        {
            DateCreated = DateTime.UtcNow;
        }

        public virtual DateTime DateCreated { get; set; }
        public virtual DateTime? DateUpdated { get; set; }
        public virtual DateTime? DateDeleted { get; set; }
    }
}
