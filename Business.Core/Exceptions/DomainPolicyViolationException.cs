using System;

namespace Domain.Core.Exceptions
{
    public class DomainPolicyViolationException : Exception
    {
        public DomainPolicyViolationException(string customParam)
            : base($"Custom Message: {customParam}")
        {
        }
    }
}
