using software_craftsmanship.Lib.ChainOfResponsiblity.Validation;

namespace software_craftsmanship.Lib.ChainOfResponsiblity
{
    public class UserProcessor
    {
        /* Using COR means our User Processor does not need to know anything about
         the implemenation of validation of age, name and gender. It removes the need
         for ugly if statements. (DECOUPLING CODE)
         - Can easily add or remove validation handlers.
         - Created a extensible object orientated and dynamic implementation.
         - Also beautiful use of single responsiblity */

        public bool Register(User user)
        {
            try
            {
                var handler = new NameValidationHandler();
                handler
                    .SetNext(new AgeValidationHandler())
                    .SetNext(new GenderValidationHandler());

                handler.Handle(user);

            }
            catch(UserValidationException ex)
            {
                return false;
            }
            return true;
        }
    }
}
