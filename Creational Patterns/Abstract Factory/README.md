# Abstract Factory

The classes and objects participating in this pattern are:

> **AbstractFactory** (ContinentFactory)
* declares an interface for operations that create abstract products 

> **ConcreteFactory** (AfricaFactory, AmericaFactory)
* implements the operations to create concrete product objects 

> **AbstractProduct** (Herbivore, Carnivore)
* declares an interface for a type of product object 

> **Product** (Wildebeest, Lion, Bison, Wolf)
* defines a product object to be created by the corresponding concrete factory  
* implements the AbstractProduct interface

> **Client**  (AnimalWorld)
* uses interfaces declared by AbstractFactory and AbstractProduct classes

![abstract factory](https://cloud.githubusercontent.com/assets/24522089/24084888/bfb02d8e-0d0b-11e7-9e10-4788a5731225.png)
