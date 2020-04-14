using System;

namespace software_craftsmanship.Lib.ChainOfResponsiblity.Validation
{
    public class ValidationException : Exception
    {
        public ValidationException(string message) : base(message)
        {
        }
    }
}
