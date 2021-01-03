using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;


namespace RemotingServiceHost
{
    class Program
    {
        static void Main(string[] args)
        {
            GreetingRemotingService.GreetingRemotingService remotingService = new GreetingRemotingService.GreetingRemotingService();
            int port = 8080;
            string serviceName = "Greet";
            TcpChannel channel = new TcpChannel(port);
            ChannelServices.RegisterChannel(channel, false);
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(GreetingRemotingService.GreetingRemotingService), serviceName, WellKnownObjectMode.Singleton);
            Console.WriteLine(string.Format("{0} Remoting Service started at port {1} at {2}", serviceName, port, DateTime.Now));
            Console.ReadLine();
        }
    }
}
