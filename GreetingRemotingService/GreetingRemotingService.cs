using System;


namespace GreetingRemotingService
{
    public class GreetingRemotingService : MarshalByRefObject, IGreetingRemotingService.IGreetingRemotingService
    {
        public string Greet(string name)
        {
            return "Good Morning " + name;
        }
    }
}
