How To Use Entity Framework:
1. DbContext class
2. DbSet property
3. Enum EntityState (Added, Modified, Deleted, Unchanged, Detached)
4. context.SaveChanges() saves the insert(Added state), update(Modified state), delete(Deleted state) operations in the database.
5. Three approaches: 
	(a)code first: Use this if no database exists. Write context class, entities (domain classes) and run migration commands to 
				   create the database. Code-first approach uses domain-driven design (DDD).
	(b)database/schema first: (use EDM wizard if a database already exists. You create an EDMX file.)
	(c)model first: You create entities, relationships, and inheritance hierarchies directly on the visual designer
					integrated in Visual Studio and then generate entities, the context class, and the database script from your visual model.
					You do this on the design surface of the EDMX file.
6. 
