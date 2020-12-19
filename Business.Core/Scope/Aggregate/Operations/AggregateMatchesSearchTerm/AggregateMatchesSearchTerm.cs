using System;
using System.Collections.Generic;
using System.Text;
using Domain.Models.Scope.Aggregate;

namespace Domain.Core.Scope.Aggregate.Operations.AggregateMatchesSearchTerm
{
    public static class AggregateMatchesSearchTerm
    {
        public static bool MatchesSearchTerm(this EntityListItem entityListItem, string searchTerm)
        {
            return $"{entityListItem.EntityId} {entityListItem.Name}".Contains(searchTerm);
        }
    }
}
