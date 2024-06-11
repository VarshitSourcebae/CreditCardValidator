namespace CreditCardValidator.Services
{
    public interface IValidationService
    {
        bool ValidateCreditCard(string creditCardNumber);
    }
}
