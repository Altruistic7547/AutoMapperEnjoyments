# AutoMapperEnjoyments

This project was developed with one intention in mind: **To explore and leverage the powerful capabilities of AutoMapper** for seamless object mapping.

I once received life-changing advice from my seniors that the best possible way to **enjoy any topic is rooted in writing unit test cases** around it. Through the use of MSTest unit tests, I enjoyed various features and configurations that AutoMapper has to offer while ensuring solid validation and assertions for mapped data.

## Tech Enjoyed In This Project

- .NET 7
- AutoMapper 13.0.1
- AutoFac 8.1.1
- MSTest
- Shouldly

## Solution Content

AutoMapperEnjoyments

- **AutoMapperEnjoyments.ConsoleApp**
	- demonstration on how we can use AutoMapper
	- demonstration on how we can leverage dependency injection using AutoFac for code reusability

- **AutoMapperEnjoyments.Core**
	- Contains ideal data models and data transfer objects (DTOs) of a total of 4 different business domains.
	- Game Development
	- Movie Management
	- Purchsing
	- Resource Management
	- Contains AutoMapper mapping profiles for each business domain.
	- By structuring this way, we are ensuring maintainability and reusability for AutoMapper Mappings.
	- Contains necessary AutoMapper mapping configurations
	- This initialises our AutoMapper using IMapper.

- **AutoMapperEnjoyments.MapsUnitTests**
	- This project will leverage MSTest to write unit test cases of AutoMapper mappings.

## Key Features

- **AutoMapper Configuration**: Best practices for setting up AutoMapper in a structured manner.
- **MSTest Unit Tests**: Validating mappings and ensuring data integrity.
- **DTOs and DataModels**: Mapping complex objects and handling edge cases.
- **Dependency Injection (DI)**: Configuring AutoMapper in a DI container for reusability.

## Why anyone should enjoy AutoMapper?

AutoMapper **simplifies the object-to-object mapping process**, reducing boilerplate code and enhancing readability.

By mapping complex data models to DTOs, it becomes easier to transfer data between layers in your application. This is the jade key for maintaining clean, maintainable, and performant code.

## How to really enjoy this repository

1. Clone the repository to your local machine.
2. Open the solution in Visual Studio.
3. Install required NuGet packages, including AutoMapper, AutoFac, and MSTest.
4. Explore the Core project for the AutoMapper Configuration and ConsoleApp for the usage and testing.
5. Run the tests to see the mappings in action.
6. Enjoy!

## Resources I have enjoyed

- [AutoMapper in C# with Examples](https://dotnettutorials.net/lesson/automapper-in-c-sharp/)

- [.NET 8 🔥🚀 : Guide to AutoMapper - Simplify Your Object Mapping](https://youtu.be/87fhsf8gfDg?si=yd8-vkDlRmEmHzic)

- [AutoMapper in C# .NET Core with Unit tests | CodeNx](https://medium.com/codenx/automapper-in-net-core-778f9c874164)

- [Mastering AutoMapper in C#: A Comprehensive Guide](https://www.bytehide.com/blog/automapper-csharp)


## Concluding..
-> You can take advantage of the reusable structure and seamless AutoMapper experience to explore the repository and experiment with your own mappings!�

-> Modify the templates to fit your project needs, and feel free to contribute enhancements or raise issues.


Thank you for reading!!😊