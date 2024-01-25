# C# Drawing Program

## Overview
This console application demonstrates the concept of class inheritance in C#. The program includes the following classes:
- `DrawObject`: Base class with a virtual method `Draw()`.
- `ClassLine`: Derived class from `DrawObject` with an overridden `Draw()` method for drawing a line.
- `Circle`: Derived class from `DrawObject` with an overridden `Draw()` method for drawing a circle.
- `Square`: Derived class from `DrawObject` with an overridden `Draw()` method for drawing a square.
- `DemoForDrawing`: Main application class with a menu to demonstrate drawing objects.

## Code Structure
1. **DrawObject Class**
    - Base class with a virtual method `Draw()` that prints "I am a base drawing object."

2. **ClassLine Class**
    - Derived class from `DrawObject` with an overridden `Draw()` method that prints a line.

3. **Circle Class**
    - Derived class from `DrawObject` with an overridden `Draw()` method that prints a circle.

4. **Square Class**
    - Derived class from `DrawObject` with an overridden `Draw()` method that prints a square.

5. **DemoForDrawing Class**
    - Main class with a method `MainMeny()` that provides a menu for drawing different objects.

## Usage
1. Run the application.
2. Choose an option from the menu:
   - Option 1: Draw a line.
   - Option 2: Draw a circle.
   - Option 3: Draw a square.
   - Option 4: Exit.

## Getting Started
To run the application:
1. Open the solution in a C# IDE (Integrated Development Environment) such as Visual Studio.
2. Build and run the project.
