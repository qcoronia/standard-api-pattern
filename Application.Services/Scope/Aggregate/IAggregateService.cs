using System;
using System.Collections.Generic;
using System.Text;
using Domain.Models.Scope.Aggregate;

namespace Application.Service.Scope.Aggregate
{
    public interface IAggregateService
    {
        IEnumerable<EntityListItem> Query(string searchTerm = "", int page = 1, int limit = 20);

        void Create(EntityForm form);
    }
}
