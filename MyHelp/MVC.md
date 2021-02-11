MVC

-Lifecycle: 
	Http request -> Routing module -> controller creation -> 
	Authentication and Authorization module is invoked -> Model binding happens -> 
	Action Method is invoked -> Result execution (View)

- Model

- View

- Controller

- Action

- asp tag helpers: 
	- asp-action
	- asp-controller
	- asp-route-{value} e.g. asp-route-id
	- asp-for
		The asp-for attribute value is a ModelExpression and the right hand side of a lambda expression. 
		Therefore, asp-for="Property1" becomes m => m.Property1 in the generated code which is why you don't 
		need to prefix with Model. You can use the "@" character to start an inline expression and move before the m.
	- asp-validation-for
	- asp-route  (takes a route name)
	- asp-route-returnurl
	- asp-area
	- asp-page-handler
	- asp-all-route-data
	- asp-fragment
	- asp-page
	
- @inject directive
	- ASP.NET Core supports dependency injection into views. appsettings.json values can be directly injected into a view.
	appsettings.json contains the following:
	{
		"root": {
			"parent": {
				"child": "myvalue"
			}
		}
	}

	In cshtml
	@using Microsoft.Extensions.Configuration
	@inject IConfiguration Configuration

	@{
	   string myValue = Configuration["root:parent:child"];
	   ...
	}

	We can inject services aslo into a view.
	public void ConfigureServices(IServiceCollection services)
	{
	    services.AddTransient<StatisticsService>();
	}

	in cshtml
	@inject StatisticsService StatsService
	<p>@StatsService.GetAverageAge</p>

- @model... 

- @using.... 

- view model for dropdown list (type: SelectList, SelectListItem), radio button, input, display

- ModelState (IsValid, Clear(), AddModelError("", "Enter more than 5"))

- _Layout.cshtml: you may have to inject services or use libraries:
	@using Microsoft.AspNetCore.Identity   //library dependency
	@using MyEfCore.Data
	@inject SignInManager<Employer> SignInManager   //service dependency
	@inject UserManager<Employee> UserManager
	<!DOCTYPE html>
	<html lang="en">
	....

- Dynamic title: in the _Layout.cshtml put the following:
	<head> ViewData["Title"] </head>
  
	on the list of employee page, put the following code: 
	@{  
	    ViewData["Title"] = "List of Employees" 
	}


