using System;
using System.Collections.Generic;
using System.Text;
using Data.Entities.Models;
using Domain.Models.Scope.Aggregate;

namespace Application.Service.Scope.Aggregate
{
    public static class AggregateMapper
    {
        public static EntityListItem ToModel(this Entity entity)
        {
            return new EntityListItem
            {
                EntityId = entity.PkEntityId,
                Name = entity.EntityDescription,
            };
        }

        public static Entity FromModel(this EntityForm form)
        {
            return new Entity
            {
                PkEntityId = form.EntityId,
                EntityDescription = form.Name,
            };
        }
    }
}
