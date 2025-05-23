# Solid

## Single responsibility principle

> It states that a single module or a class should be responsible for a single piece of functionality of the system.

> Basically, a module or a class should do only one thing.

> Or, as uncle Bob says, A class or a module should have only reason to change.

> For example: Let's say that we have a class ReportManager

> This class does three things: Writes reports, Formats them, and Saves them to a file.

> Here, this class has three functionalities, or we can say it has three reasone to change.

> By three reasons to change I mean that now we need to change the class or modify it if:

1. If Writing reports rules change
2. If formatting rules change
3. If file-saving rules change

> Why should the class ReportManager be changes three times here?

> Instead we could make separate classes for each of them and handle any related changes there.

> This doesn't imply that every small functionality should be separated and made into a class. This would defeat the purpose of having a class entirely.

> But it says that the different functional parts of a class should be separated and only similar functionalities that don't break or provide another reason to change should be kept together in the class.

### Benefits/Advantages of Single responsibility principle

> Makes working in group easier as without SRP applied the same class would be changes for different reasons leading to errors/bugs.

> Makes it easier to find and fix bugs because we know the exact origin. For eg: Following SRP we have created a class printDocs now if the documents are not printed and errors occur there, we know exactly where to look.

> Fewer merge conflicts as files will have single reason to change and conflicts that do exist will be easier to resolve.
