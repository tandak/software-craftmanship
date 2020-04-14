
using System.Collections.Generic;

namespace software_craftsmanship.Lib.ChainOfResponsiblity.Validation
{
    public class GenderValidationHandler : Handler<User>
    {
        private readonly ISet<string> Genders = new HashSet<string>()
        {
            "Male","Female","Non-Binary"
        };

        public override void Handle(User request)
        {
            if (!Genders.Contains(request.Gender))
            {
                throw new GenderValidationException("Not a valid gender in the system.");
            }
            base.Handle(request);
        }
    }
}
