# Open-closed principle

The Open Closed Principle (OCP) is the SOLID principle which states that the software entities (classes or methods) should be open for extension but closed for modification.

But what does this really mean?

Basically, we should strive to write a code which doesn’t require modification every time a customer changes its request. Providing such a solution where we can extend the behavior of a class (with that additional customer’s request) and not modify that class, should be our goal most of the time.

In this article, we will show you how to write the code by following the Open Closed Principle with two different examples. Initially, none of the examples will obey the OCP rules, but right after the initial development, we are going to refactor the code using the OCP.

## Why Should We Implement the Open Closed Principle

By implementing the OCP we are lowering the chance of producing bugs in our project.

For example, if we have a fully working and already tested class in production, by extending it instead of changing it, we would definitely have a lesser impact on the rest of the system.

Therefore, we introduce another class to extend the behavior of the main class thus avoid the existing functionality modification that other classes may rely upon.

Another benefit is that we only have to test and deploy the new features, which wouldn’t be the case if we had to change existing functionality. Furthermore, if we decide that we don’t need this feature anymore (sometime in the future), all we have to do is to revert just newly implemented change and that’s it.

## Conclusion

We’ve seen how the OCP can help us create better and more maintainable code. But, as with everything else, we should be cautious when implementing this principle.

Sometimes it’s just impossible to extend our class and all we are left to do is to modify existing functionality. We shouldn’t be afraid to do it, it is quite normal, but at least we should try to make those changes as discrete as they can be.

So, we should develop our applications with the OCP in mind and we should strive to write extendable code as much as we can because it leads to the maintainable, scalable and testable codebase.

And that’s what we want, isn’t it?

## Author

* **Ivan Žagar** 

## Go back
[Thranduil77/SOLID-design-principles](https://github.com/Thranduil77/SOLID-design-principles)
