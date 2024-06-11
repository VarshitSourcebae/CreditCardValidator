# CreditCardValidator

## Description

A production-grade ASP.NET Web API that validates credit card numbers using the Luhn algorithm.

## Getting Started

### Prerequisites

- .NET SDK
- NUnit

### Running the Application

1. Clone the repository.
2. Navigate to the project directory.
3. Run the application:

```sh
dotnet run


-- Project Structure --
CreditCardValidator/
├── Controllers/
│   └── ValidationController.cs
├── Repositories/
│   ├── IValidationRepository.cs
│   └── ValidationRepository.cs
├── Services/
│   ├── IValidationService.cs
│   └── ValidationService.cs
├── Utilities/
│   └── LuhnValidator.cs
├── CreditCardValidator.csproj
└── Startup.cs
CreditCardValidator.Tests/
├── CreditCardValidator.Tests.csproj
└── ValidationRepositoryTests.cs
