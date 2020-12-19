using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Service.Exceptions
{
    public class SummarizedServiceOperationException : Exception
    {
        public SummarizedServiceOperationException(string customParam)
            : base($"Custom Message: {customParam}")
        {
        }
    }
}
