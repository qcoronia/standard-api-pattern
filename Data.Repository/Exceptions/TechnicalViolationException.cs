using System;

namespace Data.Repository.Exceptions
{
    public class TechnicalViolationException : Exception
    {
        public TechnicalViolationException(string customParam)
            : base($"Custom Message: {customParam}")
        {
        }
    }
}
