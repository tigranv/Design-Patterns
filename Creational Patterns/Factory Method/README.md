# Factory Method

![factorymethod](https://cloud.githubusercontent.com/assets/24522089/24106709/27b40bc6-0da2-11e7-8c0b-fd24d7765d19.png)


### The classes and objects participating in this pattern are:

**Product**  (Page)
* defines the interface of objects the factory method creates

**ConcreteProduct ** (SkillsPage, EducationPage, ExperiencePage)
* implements the Product interface

**Creator**  (Document)
* declares the factory method, which returns an object of type Product. Creator may also define a default implementation of the factory method that returns a default ConcreteProduct object.
* may call the factory method to create a Product object.

**ConcreteCreator**  (Report, Resume)
* overrides the factory method to return an instance of a ConcreteProduct.


-------------------------------------------------------------------------------------------------
> This project written on C# 6.0, .NET Framework 4.6 Visual Studio 2015 Comunity Edition
