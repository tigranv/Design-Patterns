# Facade

Provide a unified interface to a set of interfaces in a subsystem. Façade defines a higher-level interface that makes the subsystem easier to use.

![facade](https://cloud.githubusercontent.com/assets/24522089/24169959/9aa561d8-0e98-11e7-8d2a-2db364eb76e5.png)

> Frequency of use: **High**

### The classes and objects participating in this pattern are:

**Facade**   (MortgageApplication)
* knows which subsystem classes are responsible for a request.
* delegates client requests to appropriate subsystem objects.

**Subsystem classes**   (Bank, Credit, Loan)
* implement subsystem functionality.
* handle work assigned by the Facade object.
* have no knowledge of the facade and keep no reference to it.

-------------------------------------------------------------------------------------------------
> This project written on C# 6.0, .NET Framework 4.6 Visual Studio 2015 Comunity Edition
