namespace software_craftsmanship.Lib.ChainOfResponsibility.Validation
{
    public class AgeValidationException : ValidationException
    {
        public AgeValidationException(string message) : base(message)
        {
        }
    }
}