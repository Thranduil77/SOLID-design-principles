# Single responsibility principle

According to Wikipedia the single responsibility principle states that every class should have responsibility over a single part of the functionality provided by the software, and that responsibility should be entirely encapsulated by the class. All its services should be narrowly aligned with that responsibility.  The single responsibility principle is one of the SOLID design principles as defined by Robert Martin in his book Agile Software Development: Principles, Patterns, and Practices.

An important thing to note is that Martin defines a responsibility as “a reason to change” so when I think of the single responsibility principle I paraphrase it as a class should have only one reason to change.  When I am designing a system and it is time to start creating classes I always ask myself what things change together and what things change independently of one another.  When I find things that change together they can and often should be put together in the same class when they vary independently, I make sure and separate those things by using different classes.

## Author

* **Ivan Žagar** 

## Go back
[Thranduil77/SOLID-design-principles](https://github.com/Thranduil77/SOLID-design-principles)
