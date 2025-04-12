# Visitor Design Pattern in C#

## Key Components

### 1. **Interfaces**
- **`IVisitor`**: Represents the visitor interface with a `Visit` method that operates on `IElement` objects.
- **`IElement`**: Represents the element interface with an `Accept` method that accepts a visitor.

### 2. **Concrete Visitor Classes**
- **`Salesman`**: Implements the `IVisitor` interface. Defines behavior for visiting an `IElement` (specifically, a `Kid` object).
- **`Doctor`**: Another implementation of `IVisitor`, defining a different behavior for visiting a `Kid`.

### 3. **Concrete Element Class**
- **`Kid`**: Implements the `IElement` interface. Represents an object that can be visited by a visitor.

### 4. **Object Structure**
- **`School`**: Contains a collection of `IElement` objects (e.g., `Kid` instances) and allows visitors to visit each element.

---

## How the Code Works

### 1. **Visitor Implementation (`Salesman` and `Doctor`)**
- Both `Salesman` and `Doctor` implement the `Visit` method from the `IVisitor` interface.
- In the `Visit` method, they check if the `IElement` passed is a `Kid` object using the `is` keyword:
   ```csharp
   if (element is Kid kid)
   {
       Console.WriteLine($"Salesman: {Name} gave a school bag to the child: {kid.KidName}");
   }
   ```

- **`Salesman`**: Prints a message about giving a school bag to the child.  
- **`Doctor`**: Prints a message about performing a health checkup on the child.

### 2. **Element Implementation (`Kid`)**
- The `Kid` class implements the `IElement` interface.
- It contains a `KidName` property and an `Accept` method:
   ```csharp
   public void Accept(IVisitor visitor)
   {
       visitor.Visit(this);
   }
   ```

### 3. **Object Structure (`School`)**
- The `School` class contains a collection of `IElement` objects (e.g., `Kid` instances).
- It provides a method to allow a visitor to visit all elements in the collection:
   ```csharp
   public void PerformOperation(IVisitor visitor)
   {
       foreach (var element in _elements)
       {
           element.Accept(visitor);
       }
   }
   ```

### 4. **Program Execution**
- A `School` object is created, and `Kid` objects are added to it.
- Visitors (`Salesman` and `Doctor`) are instantiated and passed to the `School`'s `PerformOperation` method:
   ```csharp
   var school = new School();
   school.AddElement(new Kid("John"));
   school.AddElement(new Kid("Alice"));

   var salesman = new Salesman("Tom");
   var doctor = new Doctor("Dr. Smith");

   school.PerformOperation(salesman);
   school.PerformOperation(doctor);
   ```

---

## Flow of Execution

1. A `School` object is created, and `Kid` objects are added to it.
2. A `Salesman` and a `Doctor` are instantiated.
3. The `PerformOperation` method of `School` is called with each visitor.
4. Each visitor visits all the `Kid` objects in the school, performing their respective actions.

---

## Purpose of the Design

The Visitor Design Pattern allows adding new operations (e.g., `Salesman` and `Doctor`) without modifying the `Kid` class or other elements. This promotes the **Open/Closed Principle**, making the code more maintainable and extensible.

---
