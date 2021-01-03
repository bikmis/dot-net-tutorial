How to call a remoting service from a client application:
1. Add a Windows Forms App project.
2. Add the reference to IGreetingRemotingService project to this client.
3. Create the following client in Form1 class:
     IGreetingRemotingService.IGreetingRemotingService client;
4. Add the following using statements in Form1.cs file:
   using System.Runtime.Remoting.Channels;
   using System.Runtime.Remoting.Channels.Tcp;
5. Add the following in the Form1 constructor:
   TcpChannel channel = new TcpChannel();
   ChannelServices.RegisterChannel(channel, false);
   client = (IGreetingRemotingService.IGreetingRemotingService)Activator.GetObject(typeof(IGreetingRemotingService.IGreetingRemotingService), "tcp://localhost:8080/Greet");
6. Now you can use client variable to call Greet method of the service.