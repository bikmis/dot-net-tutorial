using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


public class Test : ITest
{

    public string SaySomething(string something)
    {
        return string.Format("You said: {0}", something);
    }
}
