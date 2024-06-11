namespace CreditCardValidator.Repositories
{
    public interface IValidationRepository
    {
        bool ValidateCreditCard(string creditCardNumber);
    }
}
