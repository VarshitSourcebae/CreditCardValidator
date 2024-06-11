
using CreditCardValidator.Repositories;

namespace CreditCardValidator.Test
{
    public class Tests
    {
        private IValidationRepository _validationRepository;

        [SetUp]
        public void SetUp()
        {
            _validationRepository = new ValidationRepository();
        }

        [TestCase("4532015112830366")] // Valid Visa
        [TestCase("6011111111111117")] // Valid Discover
        [TestCase("123456781234567")] // Invalid number
        public void ValidateCreditCard_ShouldPrintValidationResult(string creditCardNumber)
        {
            bool result = _validationRepository.ValidateCreditCard(creditCardNumber);
            if (result)
            {
                TestContext.WriteLine($"{creditCardNumber} is valid.");
            }
            else
            {
                TestContext.WriteLine($"{creditCardNumber} is invalid.");
            }
        }
    }
}