# Liskov substitution principle

The Liskov Substitution Principle (LSP) states that child class objects should be able to replace a parent class objects without compromising the application integrity. What this means essentially, is that we should put an effort to create such derived class objects which can replace objects of the base class without modifying its behavior. If we don’t, our application might end up being broken.

Does this make sense to you?

To make things clear, we are going to use a simple „Sum Calculator“ example, which will help us to understand how to implement the LSP better.

## Initial Project

In this example, we are going to have an array of numbers and a base functionality to sum all the numbers from that array. But let’s say we need to sum just even or just odd numbers.

## What We Gain By Implementing the LSP

By implementing the LSP, we are keeping our functionality intact and still having our subclasses act as a substitute to a base class.

Also, we encourage the code reusability by implementing the LCP and having better project maintenance as well.

## Conclusion

We can see that implementing the LSP is not that complicated but just the opposite. Most of us probably already implemented this principle many times in our code without knowing its name because in the object-oriented world Polymorphism is quite a big thing.

## Author

* **Ivan Žagar** 

## Go back
[Thranduil77/SOLID-design-principles](https://github.com/Thranduil77/SOLID-design-principles)
