using System.Collections.Generic;
using Data.Entities.Models;

namespace Data.Entities.DbContext
{
    public class EntityDbContext
    {
        public ICollection<Entity> Entity { get; set; }

        public void SaveChanges()
        {
        }
    }
}
