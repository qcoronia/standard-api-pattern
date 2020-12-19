using System;
using System.Collections.Generic;
using Data.Entities.Models;

namespace Data.Repository.Scope.Aggregate
{
    public interface IAggregateRepository
    {
        void Create(Entity entity);

        IEnumerable<Entity> Query();

        Entity FindById(Guid id);

        void Save();
    }
}
