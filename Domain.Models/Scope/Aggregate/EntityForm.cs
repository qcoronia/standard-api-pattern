using System;

namespace Domain.Models.Scope.Aggregate
{
    public class EntityForm
    {
        public Guid EntityId { get; set; }

        public string Name { get; set; }

        public int Quantity { get; set; }
    }
}
