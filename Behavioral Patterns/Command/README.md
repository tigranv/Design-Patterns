# Command

Encapsulate a request as an object, thereby letting you parameterize clients with different requests, queue or log requests, and support undoable operations.

![command](https://cloud.githubusercontent.com/assets/24522089/24660159/d9a8ab84-195f-11e7-94ac-16e51b9fbcd3.png)


> Frequency of use: **Medium high**

### The classes and objects participating in this pattern are:

**Command**  (Command)
* declares an interface for executing an operation

**ConcreteCommand**  (CalculatorCommand)
* defines a binding between a Receiver object and an action
* implements Execute by invoking the corresponding operation(s) on Receiver

**Client**  (CommandApp)
* creates a ConcreteCommand object and sets its receiver

**Invoker**  (User)
* asks the command to carry out the request

**Receiver**  (Calculator)
* knows how to perform the operations associated with carrying out the request.

----------------------------------------------------------------------------------------------------------------
> This project written on C# 6.0, .NET Framework 4.6 Visual Studio 2015 Comunity Edition
