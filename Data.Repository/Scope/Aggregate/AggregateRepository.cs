using System;
using System.Collections.Generic;
using System.Linq;
using Data.Entities.DbContext;
using Data.Entities.Models;

namespace Data.Repository.Scope.Aggregate
{
    public class AggregateRepository : IAggregateRepository
    {
        public AggregateRepository(EntityDbContext db)
        {
            this.Db = db;
        }

        public EntityDbContext Db { get; }

        public IEnumerable<Entity> Query()
        {
            return this.Db.Entity.AsEnumerable();
        }

        public Entity FindById(Guid id)
        {
            return this.Db.Entity.FirstOrDefault(e => e.PkEntityId == id);
        }

        public void Create(Entity entity)
        {
            this.Db.Entity.Add(entity);
        }

        public void Save()
        {
            this.Db.SaveChanges();
        }
    }
}
