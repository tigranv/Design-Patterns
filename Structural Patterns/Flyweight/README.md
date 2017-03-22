# Flyweight

![flyweight](https://cloud.githubusercontent.com/assets/24522089/24169971/a5b05d1c-0e98-11e7-919c-f94a8e85a90f.png)


> Frequency of use: **Low**

### The classes and objects participating in this pattern are:

**Flyweight**   (Character)
* declares an interface through which flyweights can receive and act on extrinsic state.

**ConcreteFlyweight**   (CharacterA, CharacterB, ..., CharacterZ)
* implements the Flyweight interface and adds storage for intrinsic state, if any. A ConcreteFlyweight object must be sharable. Any state it stores must be intrinsic, that is, it must be independent of the ConcreteFlyweight object's context.

**UnsharedConcreteFlyweight**   ( not used )
* not all Flyweight subclasses need to be shared. The Flyweight interface enables sharing, but it doesn't enforce it. It is common for UnsharedConcreteFlyweight objects to have ConcreteFlyweight objects as children at some level in the flyweight object structure (as the Row and Column classes have).

**FlyweightFactory**   (CharacterFactory)
* creates and manages flyweight objects
* ensures that flyweight are shared properly. When a client requests a flyweight, the FlyweightFactory objects assets an existing instance or creates one, if none exists.

**Client**   (FlyweightApp)
* maintains a reference to flyweight(s).
* computes or stores the extrinsic state of flyweight(s).

-------------------------------------------------------------------------------------------------
> This project written on C# 6.0, .NET Framework 4.6 Visual Studio 2015 Comunity Edition
