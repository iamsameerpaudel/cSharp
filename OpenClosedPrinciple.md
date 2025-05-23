# sOlid

## Open/Close Principle

> Entities (Classes, Modules, functions etc.) should be open to extension but closed for modification or alteration in the existing working code.

> New features are welcome and should be allowed to be added but without changing the existing tested working code.

> Whenever we change the existing code, we take the risk of creating potential bugs.

> We can use interfaces, abstract classes etc. to add features to a class without modifying it.

> Example:

```c#
class Tiger{
public string FavFood {get; set;}
}
class Dog{
    public string FavFood {get; set;}
}

class Sound{
public string MakeSound(object animal){
    if( animal is Tiger tiger ){
        return "Roar";
    }else if(animal is Dog dog){
        return "Woof";
    }
}
}
```

> This is not good at all. If we need to add another animal, say Elephant, we need to change the working Sound class. In a larger codebase this could cause issues and potential bugs can be created.

> Instead we can do the following:

```C#

interface Animal{
    string MakeSound();
}

class Tiger:Animal{
    public string FavFood {get; set;}
    public string MakeSound(){
        return "Roar";
    }
}
class Dog: Animal{
    public string FavFood {get; set;}
    public string MakeSound(){
        return "Woof";
    }
}

class Sound{
    public string speak(Animal animal){
        return animal.MakeSound();
    }
}
```
> This is wayy better. Now if we need to add a new feature of Elephant we don't need to change any of the existing code.

```c#
class Elephant : Animal{
    public string FavFood {get; set;}
    public string MakeSound(){
        return "Trumpet";
    }
}
```
> Only doing this would be enough, we won't need to change anything else.