This project is .NET 9 and uses C# 13.

Make sure all code generated is inside of the MyMonkeyApp project, which may be a subfolder inside of the main folder.

It is on GitHub at https://github.com/CodeMonster/MonkeyApp

## Project Context
This is a console application that manages monkey species data and integrates with GitHub through MCP servers.

## C# Coding Standards
- Use PascalCase for class names, method names, and properties
- Use camelCase for local variables and parameters
- Use descriptive names that clearly indicate purpose
- Use `var` for local variables when the type is obvious
- Prefer explicit types when it improves readability
- Use async/await for asynchronous operations
- Follow the repository pattern for data access
- Use proper exception handling with try-catch blocks
- Implement IDisposable when managing resources
- Use nullable reference types to avoid null reference exceptions
- use file-scoped namespaces for cleaner code organization
- don't add comments to obvious code, but do add comments to complex logic
- remove all trailing white spaces
- always reformat the document when making changes
- remove unused usings
- classes should be sealed by default unless inheritance is required

## Naming Conventions
- Classes: `MonkeyHelper`, `Monkey`, `Program`
- Methods: `GetMonkeys()`, `GetRandomMonkey()`, `GetMonkeyByName()`
- Properties: `Name`, `Location`, `Population`
- Variables: `selectedMonkey`, `monkeyCount`, `userInput`
- Constants: `MAX_MONKEYS`, `DEFAULT_POPULATION`

## Architecture
- Console application with interactive menu
- Static helper class for data management
- Model classes for data representation
- Separation of concerns between UI and business logic
