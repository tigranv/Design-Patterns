# Decorator

![decorator](https://cloud.githubusercontent.com/assets/24522089/24169945/90478c70-0e98-11e7-92f9-a020b9904ab8.png)

> Frequency of use: **Medium**

### The classes and objects participating in this pattern are:

**Component**   (LibraryItem)
* defines the interface for objects that can have responsibilities added to them dynamically.

**ConcreteComponent**   (Book, Video)
* defines an object to which additional responsibilities can be attached.

**Decorator**   (Decorator)
* maintains a reference to a Component object and defines an interface that conforms to Component's interface.

**ConcreteDecorator**   (Borrowable)
* adds responsibilities to the component.


-------------------------------------------------------------------------------------------------
> This project written on C# 6.0, .NET Framework 4.6 Visual Studio 2015 Comunity Edition
