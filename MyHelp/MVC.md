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
	- 
