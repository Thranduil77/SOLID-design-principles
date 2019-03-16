# Single responsibility principle

According to Wikipedia the single responsibility principle states that every class should have responsibility over a single part of the functionality provided by the software, and that responsibility should be entirely encapsulated by the class. All its services should be narrowly aligned with that responsibility.  The single responsibility principle is one of the SOLID design principles as defined by Robert Martin in his book Agile Software Development: Principles, Patterns, and Practices.

An important thing to note is that Martin defines a responsibility as “a reason to change” so when I think of the single responsibility principle I paraphrase it as a class should have only one reason to change.  When I am designing a system and it is time to start creating classes I always ask myself what things change together and what things change independently of one another.  When I find things that change together they can and often should be put together in the same class when they vary independently, I make sure and separate those things by using different classes.

While developing a project, we strive to write maintainable and readable code (beside the working part 😀 ). To accomplish this, each and every class should do its own task and do it well.

Yes, it is quite important for a class to have no more than one task. If it does, our code becomes harder to maintain, due to the fact that it is responsible for the execution of several different tasks and thus being more likely to change in the future.

This is completely opposite from what the Single Responsibility Principle (SRP) states.

The Single Responsibility Principle states that our classes should have only one reason to change or in other words, it should have only one responsibility.

Simple as that.

In this article, we are going to show you, through an example, how to create a code which abides by SRP rules. We will start with the code which isn’t SRP compliant and then refactor it to be in accordance with SRP. To finish our example, we will add a bit of reusability to our code, because we don’t want to repeat ourselves while coding.

## Benefits of Single Responsibility Principle

Our code has improved in several ways by implementing SRP. The first one being that it has become less complex. Because we are trying to accomplish only one task in our class, they have become free of clutter and simple to read. As we reduce code complexity, our code becomes readable and therefore maintainable.

As we could see from our example, if our class does its job well, we can reuse its logic in a project. Furthermore, with such a code, testing becomes easier as well.

When we implement SRP in our code, our methods become highly related (coherent). It means that different methods are joined to do one thing and to do it well.

Finally, our classes are less dependent on each other (decoupled) which is one of the most important things to achieve while working on a project.

## Potential Downsides of SRP

There is no strict rule which states what is that „one reason to change“ in our class. Everyone interprets this subjectively or rather how he/she feels it should be implemented. The rules are not clear to where we should draw the line, so we can potentially find different „right ways“ to implement the same feature.

But still, bottom line is that no matter what someone thinks about what reason to change is, we should all strive to write readable and maintainable code thus implementing Single Responsibility Principle in our own way.

One of the potential downsides is that in projects that are already written, is difficult to implement SRP. We don’t say that it is not possible, just that it will take longer and take more resources as well.

Implementing SRP leads to writing compact classes with tiny methods as well. And on a first look, this looks great. But having one big class decomposed into a lot of small classes creates an organizational risk. If those classes are not organized and grouped well, it could actually increase the amount of work needed to change a system and to understand it which is opposite of what we wanted to achieve in the first place.

## Conclusion

Implementing the Single Responsibility Principle should be always in our mind while writing code. It can be tough to write the code according to SRP right from scratch, but you can write your code iteratively and return to the parts that need attention later. Refactoring is a common practice and nobody writes code perfectly right away. So refactor towards the SRP later if you are not sure which class does what at that moment. It will help not only you but the other developers that need to maintain your code later as well.

## Author

* **Ivan Žagar** 

## Go back
[Thranduil77/SOLID-design-principles](https://github.com/Thranduil77/SOLID-design-principles)
