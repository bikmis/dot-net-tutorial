using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.


public class NameService : IName
{
	public string GetName(string name)
	{
		return string.Format("You entered: {0}", name);
	}

	public FullName GetFullName(string firstName, string lastName)
	{
		FullName fullName = new FullName() { FirstName = firstName, LastName = lastName };
		return fullName;
	}
}
