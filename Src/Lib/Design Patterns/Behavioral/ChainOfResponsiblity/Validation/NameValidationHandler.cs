namespace software_craftsmanship.Lib.ChainOfResponsibility.Validation
{
    public class NameValidationHandler : Handler<User>
    {
        public override void Handle(User request)
        {
            if (request.Name.Length <= 1) throw new NameValidationaException("Name is too short.");
            base.Handle(request);
        }
    }
}