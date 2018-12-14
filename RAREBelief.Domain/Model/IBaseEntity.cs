using System;

namespace RAREBelief.Domain.Model
{
    public interface IBaseEntity<T>
    {
        T Id { get; set; }
        DateTime DateCreated { get; set; }
    }
}
