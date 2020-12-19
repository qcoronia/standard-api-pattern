using System;
using System.Collections.Generic;
using System.Text;
using Domain.Core.Scope.Aggregate.Operations.AggregateMatchesSearchTerm;
using Domain.Models.Scope.Aggregate;
using Xunit;

namespace Domain.Core.Tests.Scope.Aggregate
{
    public class AggregateMatchesSearchTermTest
    {
        [Fact]
        public void MatchesSearchTerm_Should_ReturnTrue()
        {
            var entity = new EntityListItem
            {
                EntityId = Guid.Empty,
                Name = string.Empty,
            };
            var searchTerm = string.Empty;

            var result = entity.MatchesSearchTerm(searchTerm);

            Assert.True(result);
        }
    }
}
