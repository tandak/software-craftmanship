using System;

namespace software_craftsmanship.Lib.ChainOfResponsibility.Validation
{
    public class ValidationException : Exception
    {
        public ValidationException(string message) : base(message)
        {
        }
    }
}