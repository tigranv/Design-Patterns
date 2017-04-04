# Command

![command](https://cloud.githubusercontent.com/assets/24522089/24660159/d9a8ab84-195f-11e7-94ac-16e51b9fbcd3.png)


> Frequency of use: **Medium high**

### The classes and objects participating in this pattern are:

**Builder**  (VehicleBuilder)
* specifies an abstract interface for creating parts of a Product object

**ConcreteBuilder**  (MotorCycleBuilder, CarBuilder, ScooterBuilder)
* constructs and assembles parts of the product by implementing the Builder interface
* defines and keeps track of the representation it creates
* provides an interface for retrieving the product

**Director**  (Shop)
* constructs an object using the Builder interface

**Product**  (Vehicle)
* represents the complex object under construction. ConcreteBuilder builds the product's internal representation and defines the process by which it's assembled
* includes classes that define the constituent parts, including interfaces for assembling the parts into the final result

----------------------------------------------------------------------------------------------------------------
> This project written on C# 6.0, .NET Framework 4.6 Visual Studio 2015 Comunity Edition
