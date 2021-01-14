C#

- Four principles of OOPS are:
	Abstraction: Creating an abstract class / base class putting all the common methods and properties.
	Encapsulation: Putting data members and methods in one class.
	Inheritance: Deriving properties from another class
	Polymorphism: one name many forms. Many forms of a single object. e.g. a mobile phone functions as a phone,
				  a camera, mp3 player, radio

- Difference between value types and reference types
	Value type is created directly in memory. Each instance keeps a copy of data.
	int a = 5;
	int b = a; (value 5 is passed)

	Reference type shares a single piece of data. It points to a memory address on stack
	which points to a value on heap.
	var a = new student();
	var b = a; (var a and var b both point to the same reference that points to the same object) 

- Difference between interface and abstract class
	An interface has a declaration only, but an abstract class can have both declarations and definition/concretion.
	A class can implement multiple interfaces, but inherit from only one class.
	An interface can only contain methods, but an abstract class can contain methods, fields, constants etc.

- Is multiple inheritance allowed in C#?
	No

- Where is virtual used?
	A virtual method or property is created in a base class which can be overridden in a derived class.

- What is generic?
	A general form, not specific to a particular data type. Generic classes are defined a type parameter
	in angle brackets after the class name.

- What is a sealed class?
	A sealed class cannot be derived from.

- What is boxing and unboxing?
	Boxing is the process of converting a value type to the type object. Unboxing extracts the value
	from the object or converts an object into a value type.

- What is polymorphism?

- Extension method
	You can add methods to existing types without creating a new derived type, recompiling, or otherwise
	modifying the original type.

- lambda, ananymous method and delegate
	