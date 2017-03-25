# Adapter

![adapter](https://cloud.githubusercontent.com/assets/24522089/24169707/e8bd2208-0e97-11e7-8975-43e02618fb94.png)

> Frequency of use: **Medium high**


### The classes and objects participating in this pattern are:

**Target**  (ChemicalCompound)
* defines the domain-specific interface that Client uses.

**Adapter**   (Compound)
* adapts the interface Adaptee to the Target interface.

**Adaptee**   (ChemicalDatabank)
* defines an existing interface that needs adapting.

**Client**   (AdapterApp)
* collaborates with objects conforming to the Target interface.



-------------------------------------------------------------------------------------------------
> This project written on C# 6.0, .NET Framework 4.6 Visual Studio 2015 Comunity Edition
