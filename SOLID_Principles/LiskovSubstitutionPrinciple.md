# soLid

## Liskov Substitution Principle

> Objects of a superclass should be replacable with objects of its subclasses without altering the expected behaviour.

> It means that when a subclass or a childclass inherits from a base or parent class, the child class should be able replace base class withour breaking functionality.

> For example: Let there be a vehicle class and it consists of two methods
- startEngine()
- move()

> Now, we inherit this class to two subclasses Car and Bicycle

> What's the problem? 

> The problem is that car can make use of both the methods, it has an engine and it can move

> But Bicycle? It can move but it doesn't have an engine, So using the startEngine() method can cause some errors or exceptions.

> We should avoid these cases. 

> We should inherit only if the subclass supports all the methods and fields of the base class.

> What can we do??

> We can either not inherit from the base class if the subclass cannot support the field or methods of the subclass

> Or, we can separate the fields and methods from the base class that the subclass cannot inherit and create an interface for subclasses that do support them.


> For example:

```c#

class Bird{
public void fly(){
//statements
}

//statements

}

class Eagle : Bird{
//Eagles can fly
}

class Penguin : Bird{

//Penguins can't fly

}

```
> Here, LSP is violated. Eagles can fly and thus having the fly method there makes sense but even Penguin has the fly method inside it but we know that penguins cannot fly.

>  Since not all birds fly, we segregate flying behavior into an interface

```c#
class Bird{
//statements
}
interface flyingBird{
void fly();
}

class Eagle : Bird, flyingBird{
//Eagles can fly 
}

class Penguin : Bird{
//Penguins don't need to fly
}

```