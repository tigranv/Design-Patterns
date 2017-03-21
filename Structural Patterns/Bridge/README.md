# Bridge

![bridge](https://cloud.githubusercontent.com/assets/24522089/24169915/77a934ac-0e98-11e7-9902-d423f3a2a71f.png)

> Frequency of use: **Medium**

### The classes and objects participating in this pattern are:

**Abstraction**   (BusinessObject)
* defines the abstraction's interface.
* maintains a reference to an object of type Implementor.

**RefinedAbstraction**   (CustomersBusinessObject)
* extends the interface defined by Abstraction.

**Implementor**   (DataObject)
* defines the interface for implementation classes. This interface doesn't have to correspond exactly to Abstraction's interface; in fact the two interfaces can be quite different. Typically the Implementation interface provides only primitive operations, and Abstraction defines higher-level operations based on these primitives.

**ConcreteImplementor**   (CustomersDataObject)
* implements the Implementor interface and defines its concrete implementation.

-------------------------------------------------------------------------------------------------
> This project written on C# 6.0, .NET Framework 4.6 Visual Studio 2015 Comunity Edition
