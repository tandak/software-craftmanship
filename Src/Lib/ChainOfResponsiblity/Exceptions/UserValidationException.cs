using System;

namespace software_craftsmanship.Lib.ChainOfResponsiblity
{
    public class UserValidationException : Exception
    {
        public UserValidationException(string message) : base(message)
        {
        }
    }
}
