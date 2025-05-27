## Singleton Pattern

> It ensures that ONLY one instance of a class can be created and it also provides global access to it.

> The class cannot be instantiated with new keyword. Why? Because here, we keep the constructor private.

> The class is instantiated with a static method inside the class, and whenever this method is called the same instance is returned, ensuring ONLY ONE instance is present.

> Only should be used when 100% sure that only one instance of the class will ever be needed/used.

> This class works just like any other normal class. The only unique thing about this class is that it can only have one instance

> It can have other normal fields, properties, methods etc.

> Is this a good idea?? I have no idea, yet.

> Could cause some issues during multithreading
