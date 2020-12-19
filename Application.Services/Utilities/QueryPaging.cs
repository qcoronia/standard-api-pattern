using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Application.Service.Utilities
{
    public static class QueryPaging
    {
        public static IEnumerable<T> Paginate<T>(this IEnumerable<T> query, int page, int limit)
        {
            return query
                .Skip(Math.Max(0, page - 1) * limit)
                .Take(limit);
        }
    }
}
