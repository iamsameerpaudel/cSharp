# Don't Repeat Yourself(DRY)

> It is aimed at reducing repetitions in the code. 

> Repetation makes code difficult to maintain, causes more bugs and there is just more unnecessary code.

> DRY principle makes it easy to reuse our code. Makes the code easier to understand and maintain.

> DRY can be implemented via various methods:

- ### Functions and methods
> Wrapping the repeated code inside a function and calling the function. Code isn't repeated and is significantly easier to implement and maintain.

- ### Modules

> Repeated logic in a separate module so that they can be accesses frequently avoiding bloat and repetition.

- ### Inheritance

> If the same fields and methods are needed in multiple classes then just inheriting the class would be a farrr better option instead of just copy-pasting the code.

- ### Templates or components

> Creating components of small segmenents of the code for improving reusability.

> These are some methods that can be used to implement DRY

> For example:

```c#
System.Console.WriteLine("Tomorrow is off day");
WriteLog("Tomorrow is off day");
sendEmailToEveryoone("Tomorrow is off day");
```

> This is awful. Imagine of we need to send hundreds of notifications. 

> A better way would be:

```c#
void notify(String message){
System.Console.WriteLine(message);
WriteLog(message);
sendEmailToEveryoone(message);
}

```

> Now we can add as many outlets inside this notify function and the message would be sent to all of them and we only had to enter the message once.


> Write reusable, clean code it helps to avoid inconsistany and makes maintaining easier.

> But overdoing DRY also can make the code messy. It should be used very properly and with proper uderstanding.