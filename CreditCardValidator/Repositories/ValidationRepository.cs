using CreditCardValidator.Utilities;

namespace CreditCardValidator.Repositories
{
    public class ValidationRepository : IValidationRepository
    {
        public bool ValidateCreditCard(string creditCardNumber)
        {
            return LuhnValidator.IsValid(creditCardNumber);
        }
    }
}
