# Chain Of Responsibility

Avoid coupling the sender of a request to its receiver by giving more than one object a chance to handle the request. Chain the receiving objects and pass the request along the chain until an object handles it.

![chainofresponsibility](https://cloud.githubusercontent.com/assets/24522089/25088692/3d1812b2-2389-11e7-8bb7-7df1ee58813a.png)

> Frequency of use: **Medium low**

### The classes and objects participating in this pattern are:

**Handler**   (Approver)
* defines an interface for handling the requests
* (optional) implements the successor link

**ConcreteHandler**  (Director, VicePresident, President)
* handles requests it is responsible for
* can access its successor
* if the ConcreteHandler can handle the request, it does so; otherwise it forwards the request to its successor


-------------------------------------------------------------------------------------------



> This Project written on C# 6.0, .NET Framework 4.6 Visual Studio 2015 Comunity Edition
