# Decision: Testing strategy - Writing consistent, readable and reproducible tests that focus on generating value for the project

__Context__

Focus should be on writing **Functional Component Tests** over (classic) Non-Functional Unit Tests. Functional Component Testing, means to focus the test on the use-case of the application. This allows for a more loose coupling between test code and application code, which results in code that is easier to refactor and maintain. These kinds of tests are achievable when testing from the **outside-in,** and naturally result in documentation of the application when done correctly.

If you find your self targeting your tests at code which is past the input/output of your application, **you should stop and re-think** why you are writing that test in the first place. This may seem strange, but you should remember that (sadly) nobody cares about how your highly optimised class with all its fancy business logic is if the application it self does not deliver on the use-cases. The upside of this however, is that your fancy, optimised code is being **holistically tested** when testing against the use-case, which means you generally do not need to write specific test for it! 😄

__Decision__

- **Test from the Outside-In with focus on the use cases.** This allows for writing a single, best-case-test, in the beginning and following up with test that support the use case if needed. E.g. tests that verify correct behaviour of the application when supporting a use case, such as handling of exceptions, correct logging, retries to external services etc.
- **Keep separate tests in separate test classes** with their own set up. Tests that focus on testing different parts of the application should be separated into different test classes with their own setup.
- **Name your tests using Given-When-Then** ([a concept from Behaviour Driven Design (BDD)](https://martinfowler.com/bliki/GivenWhenThen.html))in a way that make them readable for both technical and non-technical members of the team.
- **Grouping the test code in an Arrange-Act-Assert** manner, which allows for easier readability for the developer.
- **Be specific on what is asserted**. You can have as many assert as you want, as long as they are specific to what is being tested.
- **Abstract away noise and magic values** from the test if it does not contribute to the understandability of the test. This should result in tests that are easier to grasp at first sight.
- **Reserve the use of mocks and fakes** to situations where you do not have control of the code**.** Set your tests up to be tested from the outside-in, and use **mocks or fakes** only when really needed. E.g. when the application needs to talk to an external service, or you need to work with dates and time.
- **Treat test code the same way as you treat the rest of the code**. Don’t be afraid to **refactor the test code** or **question the purpose of the test code**.

__Consequences__

Maintainable tests which are loosely coupled to the application code, support the use-cases at the same time as holistically testing the rest of te application, and produce valuable documentation for the business.
