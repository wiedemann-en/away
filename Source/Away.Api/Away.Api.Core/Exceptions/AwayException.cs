using System;
using System.Collections.Generic;
using System.Text;

namespace Away.Api.Core.Exceptions
{
    public class AwayException : Exception
    {
        public AwayException()
            : base() { }

        public AwayException(string message)
            : base(message) { }

        public AwayException(string message, Exception innerException)
            : base(message, innerException) { }
    }
}
