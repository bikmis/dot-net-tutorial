C#

- Difference between value types and reference types
	Value type is created directly in memory. Each instance keeps a copy of data.
	int a = 5;
	int b = a; (value 5 is passed)

	Reference type shares a single piece of data. It points to a memory address on stack
	which points to a value on heap.
	var a = new student();
	var b = a; (var a and var b both point to the same reference that points to the same object) 

- Difference between interface and abstract class

- Is multiple inheritance allowed in C#?
	No

- Where is virtual used?

- What is generic?

- What is a sealed class?

- What is boxing and unboxing?

- What is polymorphism?

- Extension method
	You can add methods to existing types without creating a new derived type, recompiling, or otherwise
	modifying the original type.

- lambda, ananymous method and delegate
	