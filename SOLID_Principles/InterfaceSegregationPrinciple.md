# solId

## Interface Segregation pattern

> If a class doesn't use a method then it shouldn't be forced to use.

> An Interface is a structure which contains methods declarations that when inherited MUST be implemented.

> We should not create a large interface with a lot of methods. It can cause issues. The classes that don't need them also may end up implementing it.

> A large interface should be split into many smaller and relevant interface chunks so that classes can implement only those that are relevant or needed.

> For example:

```C#
interface printingMachine{
void printDoc(Doc d);
void scanDoc(Doc d);
void copyDoc(Doc d);
}

class OldPrinter : printingMachine{
void printDoc(Doc d){
System.Console.WriteLine("Document Printed!!");
}

void scanDoc(Doc d){

//Error

}

void copyDoc(Doc d){

//Error

}


}


```

> Making a fat interface like this can cause issues as in above snippet.

> TO avoid this we use the ISP.

```C#
interface printer{
void printDoc(Doc d);
}

interface copier{
void copyDoc(Doc d);
}

interface scanner{
void scanDoc(Doc d);
}

class OldPrinter : printer{
void printDoc(Doc d){
System.Console.WriteLine("Document printed!!");
}
}

class OldCopier : copier{

void copyDoc(Doc d){
System.Console.WriteLine("Document copied!!");
}
}

class OldScanner : scanner{
void scanDoc(Doc d){
System.WriteLine("Dcument scanned!!");
}
}

```
> Now after this segregation all the classes only use and implement the interfaces they actually need.
