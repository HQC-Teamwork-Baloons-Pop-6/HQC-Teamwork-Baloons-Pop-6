## PLAN/STEPS ##

**1.Data Level Refactorings**

- Replace a magic number with a named constant
- Rename a variable with more informative name
- Replace an expression with a method to simplify it or avoid code duplication
- Move an expression inline
- Introduce an intermediate variable
- Introduce explanatory variable
- Convert a multi-use variable to a multiple single-use variables
- Create separate variable for each usage
- Create a local variable for local purposes rather than a parameter
- Convert a data primitive to a class
- Additional behavior / validation logic (money)
- Convert a set of type codes (constants) to enum
- Convert a set of type codes to a class with subclasses with different behavior
- Change an array to an object
- When you use an array with different types in it
- Encapsulate a collection.

**2.Statement Level Refactorings**

- Decompose a boolean expression
- Move a complex boolean expression into a well-named boolean function
- Consolidate duplicated code in conditionals
- Return as soon as you know the answer instead of assigning a return value
- Use break or return instead of a loop control variable
- Replace conditionals with polymorphism
- Use null objects instead of testing for nulls

**3.Method Level Refactorings**

- Extract method / Inline method
- Rename method
- Convert a long routine to a class
- Add / remove parameter
- Combine similar methods by parameterizing them
- Substitute a complex algorithm with simpler
- Separate methods whose behavior depends on parameters passed in (create new ones)
- Pass a whole object rather than specific fields
- Return interface types / base class

**4.Class Level Refactorings**

- Change structure to class and vice versa
- Pull members up / push members down the hierarchy
- Extract specialized code into a subclass
- Combine similar code into a superclass
- Collapse hierarchy
- Replace inheritance with delegation
- Replace "is-a" with "has-a" relationship

**5.Class Interface Refactorings**

- Extract interface(s) / Keep interface segregation
- Move a method to another class
- Convert a class to two
- Delete a class
- Hide a delegating class (A calls B and C when A should call B and B call C)
- Remove the man in the middle
- Introduce (use) an extension class when we don’t have access to the original class
- Alternatively use decorator pattern
- Encapsulate an exposed member variable
- In C# always use properties
- Define proper access to getters and setters
- Remove setters to read-only data
- Hide data and routines that are not intended to be used outside of the class / hierarchy
- private > protected > internal > public
- Use strategy to avoid big class hierarchies
- Apply other design patterns to solve common class and class hierarchy problems (facade, adapter, etc.)

**6.System Level Refactorings**

- Move class (set of classes) to another namespace / assembly
- Provide a factory method instead of a simple constructor / Use fluent API
- Replace error codes with exceptions
- Extract strings to resource files
- Use dependency injection
- Apply architecture patterns

**7.Hints**

- Large repeating code fragments >> extract repeating code in separate method
- Large methods >> split them logically
- Large loop body or deep nesting >> extract method
- Class or method has weak cohesion >> split into several classes / methods
- Single change carry out changes in several classes >> classes have tight coupling >> consider redesign
- Related data are always used together but are not part of a single class >> group them in a class
- A method has too many parameters >> create a class to groups parameters together
- A method calls more methods from another class than from its own class >> move it
- Two classes are tightly coupled >> merge them or redesign them to separate their responsibilities
- Public non-constant fields >> make them private and define accessing properties
- Magic numbers in the code >> consider extracting constants
- Bad named class / method / variable >> rename it
- Complex boolean condition >> split it to several expressions or method calls
- Complex expression >> split it into few simple parts
- A set of constants is used as enumeration >> convert it to enumeration
- Method logic is too complex and is hard to understand >> extract several more simple methods or even create a new class
- Unused classes, methods, parameters, variables >> remove them
- Large data is passed by value without a good reason >> pass it by reference
- Few classes share repeating functionality >> extract base class and reuse the common code
- Different classes need to be instantiated depending on configuration setting >> use factory
- Code is not well formatted >> reformat it
- Too many classes in a single namespace >> split classes logically into more namespaces
- Unused using definitions >> remove them
- Non-descriptive error messages >> improve them
- Absence of defensive programming >> add it

**8.Other Hints**

- Correct behavior
- Conforming to the requirements
- Stable, no hangs, no crashes
- Bug free – works as expected
- Correct response to incorrect usage
- Readable – easy to read
- Understandable – self-documenting
- Maintainable – easy to modify when required

- Good identifiers' names
- Good names for variables, constants, methods, parameters, classes, structures, fields, properties, interfaces, structures, enumerations, namespaces.
- High-quality classes, interfaces and class hierarchies
- Good abstraction and encapsulation
- Simplicity, reusability, minimal complexity
- Strong cohesion, loose coupling

- High-quality methods
- Reduced complexity, improved readability
- Good method names and parameter names
- Strong cohesion, loose coupling
- Variables, data, expressions and constants
- Minimal variable scope, span, live time
- Simple expressions
- Correctly used constants
- Correctly organized data

- Correctly used control structures
- Simple statements
- Simple conditional statements and simple conditions
- Well organized loops without deep nesting
- Good code formatting
- Reflecting the logical structure of the program
- Good formatting of classes, methods, blocks, whitespace, long lines, alignment, etc.

- High-quality documentation and comments
- Effective comments
- Self-documenting code
- Defensive programming and exceptions
- Ubiquitous use of defensive programming
- Well organized exception handling
- Code tuning and optimization
- Quality code instead of good performance
- Code performance when required

- Following the corporate code conventions
- Formatting and style, naming, etc.
- Domain-specific best practices
- Well tested and reviewed
- Testable code
- Well designed unit tests
- Tests for all scenarios
- High code coverage
- Passed code reviews and inspections
