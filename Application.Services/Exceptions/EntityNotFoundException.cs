using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Service.Exceptions
{
    public class EntityNotFoundException : Exception
    {
        public EntityNotFoundException(string entityName, Guid id)
            : base($"'{entityName}' wit id '{id}' was not found: ")
        {
        }
    }
}
