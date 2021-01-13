Design Pattern & Principles

Four principles of OOPS are:
	Abstraction: Creating an abstract class / base class putting all the common methods and properties.
	Encapsulation: Putting data members and methods in one class.
	Inheritance: Deriving properties from another class
	Polymorphism: one name many forms. Many forms of a single object. e.g. a mobile phone functions as a phone,
				  a camera, mp3 player, radio

SOLID principls
	S -> Single Responsibility: A class should have only one functionality
	O -> Open Closed: A class should be open for extension and closed for modification
	L -> Liskov Substitution: derived classes must be substitutable for their base classes. If type D (derived class) 
							  derives from type B (base class), then objects of B may be replaced (or substituted) with
							  ojbects of type D.							  
	I -> Interface Segregation: client specific interfaces. Don't put all methods / properties in one interface.
								Create an interface for each functionality and clients will implement multiple
								interfaces.
	D -> Dependency Inversion: A class should depend on abstraction not on concrete implementations. Class A should depend on
							   an interface but not on a class B. Class B or C or D will implement the interface.

MVC
	Model
	View
	Controller

Singleton
	Singleton is a creational design patter, which ensures that only one object of its kind exists and provides a single point
	access to it for any other code.

Repository


