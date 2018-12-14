using System;

namespace RareBelief.Infrastructure.Model
{
    public interface IBaseEntity<T>
    {
        T Id { get; set; }
        DateTime DateCreated { get; set; }
    }
}
