## Types of Inheritance in C#

| **Type of Inheritance**      | **Description**                                                         | **Example**                    |
| ---------------------------- | ----------------------------------------------------------------------- | ------------------------------ |
| **Single Inheritance**       | One derived class inherits from a single base class                     | `Dog : Animal`                 |
| **Hierarchical Inheritance** | Multiple derived classes inherit from the same base class               | `Dog : Animal`, `Cat : Animal` |
| **Multilevel Inheritance**   | A chain of inheritance, with each class inheriting from the one above   | `Dog : Mammal : Animal`        |
| **Multiple Inheritance**     | Simulated with interfaces, where a class implements multiple interfaces | `Dog : IAnimal, IPet`          |

---

### Descriptions

- **`Single Inheritance`**: In this inheritance model, a class can inherit only from one base class. 
- **`Hierarchical Inheritance`**: One base class is inherited by multiple derived classes, providing a common structure while allowing specialized functionality.
- **`Multilevel Inheritance`**: Allows creating a chain of inheritance, where each class derives from the one above it.
- **`Multiple Inheritance`**: C# does not support multiple inheritance with classes directly. Instead, it uses interfaces to allow a class to implement multiple behaviors.

Each type of inheritance serves specific needs and promotes code reuse, flexibility, and a clear organizational structure.

## Polimorphism
Polymorphism is a core concept in object-oriented programming (OOP) that allows `objects of different classes` to be treated as objects of a `common superclass`. It provides a way to perform a single action in different forms, promoting flexibility, code reuse, and ease of maintenance.
1. **`Compile-Time Polymorphism (Static Polymorphism)`**: Method Overloading refers multiple methods in the same class have the same name but different parameters.
2. **`Run-Time Polymorphism (Dynamic Polymorphism)`**: Run-time polymorphism is achieved through method `overriding`. The base class method is declared as `virtual`, and the derived class uses the `override` keyword to implement its specific behavior.

## Abstraction
