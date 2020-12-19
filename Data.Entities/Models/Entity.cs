using System;

namespace Data.Entities.Models
{
    public partial class Entity
    {
        public Guid PkEntityId { get; set; }

        public string EntityDescription { get; set; }
    }
}
