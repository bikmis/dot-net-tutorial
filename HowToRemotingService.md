How to create a remoting service:
1. Right click on the solution and add a project of "Class Library" template. Name it IGreetingRemotingService.
2. Add an interface "IGreetingRemotingService" to this project.
3. Right click on the solution and add another project of "Class Library" template. Name it GreetingRemotingService.
4. Add a class "GreetingRemotingService" to this project.
5. There are two ways to make it remoteable (a) by decoraing the class with the "Serializable" attribute  or (b) by inheriting from MarshalByRefObject class
6. This class "GreetingRemotingService" needs to implement the interface "IGreetingRemotingService.IGreetingRemotingService". So you need to add a reference 
   to "IGreetingRemotingService" project to "GreetingRemotingService" project.
7. Create another project "RemotingServiceHost" of "console application" template.
8. Add references to "IGreetingRemotingService", "GreetingRemotingService" and "System.Runtime.Remoting" to the project "RemotingServiceHost".
9. Add the following using statements in the "RemotingServiceHost's Program class".
		using System.Runtime.Remoting;
		using System.Runtime.Remoting.Channels;
		using System.Runtime.Remoting.Channels.Tcp;

Remoting Service Client
1. Create a windows form project
2. Add a reference to System.Runtime.Remoting to the project.
3. Add a reference to the interface project "IGreetingRemotingService" to this client project.
4. Add the following using statements in Form1.cs:
    using System.Runtime.Remoting.Channels;
	using System.Runtime.Remoting.Channels.Tcp;
5. Run the RemotingServiceHost project and then client project by right clicking and clicking "Debug -> Start New Instance"
