How To Use Entity Framework:
1. Create a project(class library .net framework).
2. Add EntityFramework package from Nuget.
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
					You do this on the design surface of the EDMX file. Right-click on the project (class library .net framework) and add new item
					and select ADO.NET Entity Data Model template.

 
6. (a) Go to Tools -> NuGet Package Manager -> Package Manager Console (b) PM>enable-migrations - it will create Migrations folder 
	   with Configuratin.cs file (c)add-migration name will add a new migration file to Migrations folder. (d) update-database -> this will fire migration code in the database.
7. Add the following variable:
   static string connectionString = "Data Source=localhost;Initial Catalog=SchoolDb;Integrated Security=SSPI;";
