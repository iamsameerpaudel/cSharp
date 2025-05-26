# soliD

## Dependency inversion principle

### High level class

> The module/class that contains the core business logic. The module that decides what happens. For eg: The outer main class

### Low level class

> The module/class that is used by the High level module/class to do technical or some specific task. The higher level module/class is dependent on this module/class but this module/class doesn't contain the core business logic.

> For example:

```c#

class manager{

public void addDeveloper(){

}
public void addDesigner(){

}
public void addQA(){

}

}

class Developer{
	public void doWork(){

	}
	public void report(){

	}
}
class Designer{
	public void doWork(){

	}
	public void report(){

	}

}
class QA{
	public void doWork(){

	}
	public void report(){

	}

}

class Program{
	static void Main(String[] args){
		manager mgr1 = new manager();
		Developer dev1 = new Developer();
		mgr1.addDeveloper(dev1);

	}
}
```

> we can see that the manager class is dependent on the Developer, Desigener, QA classes...If we needed to add a new type of employee, say tester, or If any changes were to be made in the lower classes it could cause some potential errors. This is very difficult to scale..

```c#

interface IEmployee{
	void work();
	void report();
}
class manager{
	void addEmployee(IEmployee employee){
		System.Console.WriteLine("Employee added!!")
	}
}

class Developer:IEmployee{
	void work(){
		System.Console.WriteLine("Working!!")

	}
	void report(){
		System.Console.WriteLine("Work done!!")

	}
}
class Designer:IEmployee{
	void work(){
		System.Console.WriteLine("Working!!")

	}
	void report(){
		System.Console.WriteLine("Work done!!")

	}
}
class tester:IEmployee{
	void work(){
		System.Console.WriteLine("Working!!")

	}
	void report(){
		System.Console.WriteLine("Work done!!")

	}
}
class QA:IEmployee{
	void work(){
		System.Console.WriteLine("Working!!")

	}
	void report(){
		System.Console.WriteLine("Work done!!")
	}
}


class Program{
	static void Main(String[] args){
		manager mgr = new manager();
		mgr.addEmployee(new Developer());
		mgr.addEmployee(new Tester());
	}
}

```
> Here, manager doesn't have to be aware of the type of employee. We can extend this by using more types of employees but the manager class won't have t be changed. This is the thing about DIP. The high level class (manager) is not dependent on Employees class. Changes in these classes won't cause error in the manager class.

> The core principle is that the modules should depend on abstractions instead of details. Abstractions should not depend on details rather detils should depend on abstractions.