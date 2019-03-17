# Interface segregation principle

The Interface Segregation Principle states that no client should be forced to depend on methods it does not use. So, this is the basic definition which we can read in many different articles, but what does this really mean?

Let’s imagine that we are starting a new feature in our project. We start with some code and from that code, an interface emerges with the required declarations. Soon after, the customer decides that they want another feature which is similar to the previous one and we decide to implement the same interface in another class. But now, as a consequence, we don’t need all the methods from that interface, just some of them. Of course, we have to implement all the methods, which we shouldn’t have to, and that ’s the problem and where the ISP helps us a lot.

Basically, the ISP states that we should reduce code objects down to the smallest required implementation thus creating interfaces with only required declarations. As a result, an interface which has a lot of different declarations should be split up into smaller interfaces.

## Starting Example

There are vehicles that we can drive, and there are those we can fly with. But there are cars we can drive and fly (yes those are on sale). So, we want to create a code structure which supports all the actions for a single vehicle.

Now if we want to develop a behavior for a multifunctional car, this interface is going to be perfect for us.

This is working great. Our interface covers all the required actions.

But now, we want to implement the Car class and the Airplane class as well.

Now we can see what the problem with the IVehicle interface is. It contains only one required declaration per each class. The other method, which is not required, is implemented to throw an exception. That is a bad idea because we should be writing our code to do something and not just to throw exceptions. Furthermore, we would have to put an additional effort to document our class so that users know why they shouldn’t be using the not implemented method. A really bad idea.

So, in order to fix this problem, we are going to do some refactoring to our code and write it in accordance to ISP.

## Implementing the ISP In the Current Solution

The first thing we are going to do is to divide our IVehicle interface to ICar and IAirplane interface.

## What are the Benefits of the Interface Segregation Principle

We can see from the example above, that smaller interface is a lot easier to implement due to not having to implement methods that our class doesn’t need.

Of course, due to the simplicity of our example, we can make a single interface with a single method inside it. But in real-world projects, we often come up with an interface with multiple methods, which is perfectly normal as long as those methods are highly related to each other. Therefore, we make sure that our class needs all these actions to complete its task.

Another benefit is that the Interface Segregation Principle increases readability and maintainability of our code. We are reducing our class implementation only to required actions without any additional or unnecessary code.

## Conclusion

To sum this article up, we should put an effort into creating smaller interfaces while developing our project. Yes, we may end up with a lot of different interfaces in the end but from our point of view, this is much better than having a few large interfaces that can force us to implement non-required methods in our classes.

## Author

* **Ivan Žagar** 

## Go back
[Thranduil77/SOLID-design-principles](https://github.com/Thranduil77/SOLID-design-principles)
