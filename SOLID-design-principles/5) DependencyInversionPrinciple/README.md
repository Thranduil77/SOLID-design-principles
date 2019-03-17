# Dependency inversion principle

The basic idea behind the Dependency Inversion Principle is that we should create the higher level modules with its complex logic in such a way to be reusable and unaffected by any change from the lower level modules in our application. To achieve this kind of behavior in our apps, we introduce abstraction which decouples higher from lower level modules.

Having this idea in mind the Dependency Inversion Principle states that

High-level modules should not depend on low-level modules, both should depend on abstractions.
Abstractions should not depend on details. Details should depend on abstractions.
We are going to make all of this easier to understand with an example and additional explanations.

## What are the High-Level and Low-Level Modules

The high-level modules describe those operations in our application that has more abstract nature and contain more complex logic. These modules orchestrate low-level modules in our application.

The low-level modules contain more specific individual components focusing on details and smaller parts of the application. These modules are used inside the high-level modules in our app.

What we need to understand when talking about DIP and these modules is that both, the high-level and low-level modules, depend on abstractions. We can find different opinions about if the DIP inverts dependency between high and low-level modules or not. Some agree with the first opinion and others prefer the second. But the common ground is that the DIP  creates a decoupled structure between high and low-level modules by introducing abstraction between them.

## Benefits of Implementing the Dependency Inversion Principle

Reducing the number of dependencies among modules is an important part of the process of creating an application. This is something that we get if we implement DIP correctly. Our classes are not tightly coupled with the lower-tier objects and we can easily reuse the logic from the high-tier modules.

So, the main reason why DIP is so important is the modularity and reusability of the application modules.

It is also important to mention that changing already implemented modules is risky. By depending on abstraction and not on a concrete implementation, we can reduce that risk by not having to change high-level modules in our project.

Finally, DIP when applied correctly gives us the flexibility and stability at the level of the entire architecture of our application. Our application will be able to evolve more securely and become stable and robust.

## Conclusion

So to sum up, the Dependency Inversion Principle is the last part of the SOLID principles which introduce an abstraction between high and low-level components inside our project to remove dependencies between them.

If someone asks: „Should I put an effort to implement the DIP into my code?“, our answer would be: „Yes you should“.  Loosely coupled code and reusable components should be our goal and responsibility when developing software applications.


## Author

* **Ivan Žagar** 

## Go back
[Thranduil77/SOLID-design-principles](https://github.com/Thranduil77/SOLID-design-principles)
