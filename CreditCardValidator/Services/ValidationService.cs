using CreditCardValidator.Repositories;

namespace CreditCardValidator.Services
{
    public class ValidationService : IValidationService
    {
        private readonly IValidationRepository _validationRepository;

        public ValidationService(IValidationRepository validationRepository)
        {
            _validationRepository = validationRepository;
        }

        public bool ValidateCreditCard(string creditCardNumber)
        {
            return _validationRepository.ValidateCreditCard(creditCardNumber);
        }
    }
}
