# StrategyExample

**Definition** 
Define a family of algorithms, encapsulate each one, and make them interchangeable. Strategy lets the algorithm vary independently from clients that use it.

**Applicability**
This pattern is best used when:

 - many related classes differ only in their behavior. Strategies provide a way to configure a class with one of many behaviors.  
 - you need different variants of an algorithm. For example, you might define algorithms reflecting different space/time trade-offs. Strategies can be used when these variants are implemented as a class hierarchy of algorithms.  
 - an algorithm uses data that clients shouldn't know about. Use the Strategy pattern to avoid exposing complex, algorithm-specific data structures.  
 - a class defines many behaviors, and these appear as multiple conditional statements in its operations. Instead of many conditionals, move related conditional branches into their own Strategy class. 

**Consequences**

- Families of related algorithms
- An alternative to subclassing
- Strategies eliminate conditional statements
- A choice of implementations
- Clients must be aware of different Strategies
- Communication overhead between Strategy and Context
- Increased number of objects

**Related Patterns**

- Flyweight