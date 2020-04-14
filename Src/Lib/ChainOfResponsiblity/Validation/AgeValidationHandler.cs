namespace software_craftsmanship.Lib.ChainOfResponsiblity.Validation
{
    public class AgeValidationHandler : Handler<User>
    {
        public override void Handle(User request)
        {
            if (request.Age <= 18)
            {
                throw new NameValidationaException("Sorry, you are too YOUNG to use this service");
            }
            base.Handle(request);
        }
    }
}
