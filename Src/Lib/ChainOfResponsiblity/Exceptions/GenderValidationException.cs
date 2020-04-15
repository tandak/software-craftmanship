namespace software_craftsmanship.Lib.ChainOfResponsibility.Validation
{
    public class GenderValidationException : ValidationException
    {
        public GenderValidationException(string message) : base(message)
        {
        }
    }
}