using CreditCardValidator.Services;
using Microsoft.AspNetCore.Mvc;

namespace CreditCardValidator.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValidationController : Controller
    {
        private readonly IValidationService _validationService;

        public ValidationController(IValidationService validationService)
        {
            _validationService = validationService;
        }

        /// <summary>
        /// Validates the given credit card number using the Luhn algorithm.
        /// </summary>
        /// <param name="creditCardNumber">The credit card number to validate.</param>
        /// <returns>Boolean indicating if the credit card number is valid.</returns>
        [HttpGet("ValidateCreditCard")]
        public IActionResult ValidateCreditCard(string creditCardNumber)
        {
            if (string.IsNullOrWhiteSpace(creditCardNumber))
            {
                return BadRequest("Credit card number is required.");
            }

            try
            {
                bool isValid = _validationService.ValidateCreditCard(creditCardNumber);
                return Ok(new { isValid });
            }
            catch (Exception ex)
            {
                // Log exception (consider using a logging framework like Serilog)
                return StatusCode(500, "An error occurred while processing your request.");
            }
        }
    }
}
