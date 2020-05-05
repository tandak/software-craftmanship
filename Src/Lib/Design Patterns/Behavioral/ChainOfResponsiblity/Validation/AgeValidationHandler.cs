namespace software_craftsmanship.Lib.ChainOfResponsibility.Validation
{
    public class AgeValidationHandler : Handler<User>
    {
        public override void Handle(User request)
        {
            if (request.Age <= 18) throw new AgeValidationException("Sorry, you are too YOUNG to use this service");
            base.Handle(request);
        }
    }
}