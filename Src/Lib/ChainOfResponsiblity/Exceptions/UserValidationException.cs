using System;

namespace software_craftsmanship.Lib.ChainOfResponsibility
{
    public class UserValidationException : Exception
    {
        public UserValidationException(string message) : base(message)
        {
        }
    }
}