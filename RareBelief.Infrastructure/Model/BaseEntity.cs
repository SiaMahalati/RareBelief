using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace RareBelief.Infrastructure.Model
{
    public class BaseEntity : IBaseEntity<int>
    {
        public BaseEntity()
        {
            DateCreated = DateTime.UtcNow;
        }

        [System.ComponentModel.DataAnnotations.Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public virtual int Id { get; set; }
        public virtual DateTime DateCreated { get; set; }
    }
}
