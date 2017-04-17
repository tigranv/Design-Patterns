# Chain Of Responsibility

Avoid coupling the sender of a request to its receiver by giving more than one object a chance to handle the request. Chain the receiving objects and pass the request along the chain until an object handles it.

![chainofresponsibility](https://cloud.githubusercontent.com/assets/24522089/25088692/3d1812b2-2389-11e7-8bb7-7df1ee58813a.png)

> Frequency of use: **Medium low**

### The classes and objects participating in this pattern are:

**AbstractFactory** (ContinentFactory)
* declares an interface for operations that create abstract products 

**ConcreteFactory** (AfricaFactory, AmericaFactory)
* implements the operations to create concrete product objects 

**AbstractProduct** (Herbivore, Carnivore)
* declares an interface for a type of product object 

**Product** (Wildebeest, Lion, Bison, Wolf)
* defines a product object to be created by the corresponding concrete factory  
* implements the AbstractProduct interface

**Client**  (AnimalWorld)
* uses interfaces declared by AbstractFactory and AbstractProduct classes

-------------------------------------------------------------------------------------------



> This Project written on C# 6.0, .NET Framework 4.6 Visual Studio 2015 Comunity Edition
