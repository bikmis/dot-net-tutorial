How To Use Entity Framework:
- Create a project(class library .net framework).
- Add EntityFramework (version 6.4.4) package from Manage NuGet Packages... by right-clicking on References. (There is no version 7, but EntityFrameworkCore after version 6).
- Create a SchoolContext class that derives from DbContext class.
- Create a SchoolContextFactory implementing IDbContextFactory<SchoolContext>
- Create entity classes and add DbSet property on those entities in the SchoolContext class.
- There are five entity states (Added, Modified, Deleted, Unchanged, Detached).
- context.SaveChanges() saves the insert(Added state), update(Modified state), delete(Deleted state) operations in the database.
- Three approaches: 
	(a)code first: Use this if no database exists. Write context class, entities (domain classes) and run migration commands to 
				   create the database. Code-first approach uses domain-driven design (DDD).
	(b)database/schema first: (use EDM wizard if a database already exists. You create an EDMX file.)
	(c)model first: You create entities, relationships, and inheritance hierarchies directly on the visual designer
					integrated in Visual Studio and then generate entities, the context class, and the database script from your visual model.
					You do this on the design surface of the EDMX file. Right-click on the project (class library .net framework) and add new item
					and select ADO.NET Entity Data Model template.

 
- (a) Go to Tools -> NuGet Package Manager -> Package Manager Console (b) PM>enable-migrations -> it will create Migrations folder 
	   with Configuratin.cs file (c)PM>add-migration "name" -> this will add a new migration file to Migrations folder. (d) PM>update-database -> this will fire migration code in the database.
- Add a reference to System.Configuration to use ConfigurationManager to access configuration string from web.config or app.config.
- SchoolDb should be added to ConfigurationStrings element in the web.config of the mvc client project and the app.config of this project.
- Set this project as the Startup Project for running update-database using the configuraion string in the app.config of this project.
- Set the calling MVC project as the startup Project to run using the client's configuration string.
- The following is the configuration string to be added to the app.config and web.config files.
      <connectionStrings>
         <add name="SchoolDb"
              connectionString="Data Source=localhost; Initial Catalog=SchoolDb; Integrated Security=True;"
                     providerName="System.Data.SqlClient" />
      </connectionStrings>
