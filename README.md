=================================================================================
<h2 align="center">ASP.NET HANDS-ON</h2>
=================================================================================

1. .NET basics 
2. differences between .NET framework and .NET core framework 
3. diff between ASP. Net and Asp .NET Core Framework


4. MVC with ASP.NET
	- Model (Business Entities)
	- View (Presentation Logic)
	- Controller (Business logic)

5. Creating ASP.NET Project 
6. Directory Structure and Workflow of VS Code and ASP.NET


7. Middleware's
8. Built in Middleware's
	- Redirection
	- Static files
	- Routing
	- Authorization
	- Authentication
	- CORS
	- Exception Handler 
	- Run() -> program will not execute in program.Cs file after writing this run() function
	- use() -> it will need two parameter and we can use this function for after writing any function also by using next method
 

9. Routing 
10. Routing =URL+HTTP Methods
		
		HTTP Methods:
			- GET
			- POST
			- PUT
			- DELETE
11. Routing Types :
	- Convention routing 
		inside the program.cs
	- Attribute Routing 
		inside the controller by using [Route("home")]
12. Tokens 
	we can give different names inside the [Route(controller)] attribute 
13. Methods in Routing 
		- Map Get
		- Map Post
		- Map Put
		- Map Delete 

14. Controllers in ASP.NET


15. Action Methods 
	- IAction Result
	- Action Result
	we can do all the task mentioned below by using these two action methods 
	- Content Result
	- Empty Result
	- JSON Result
	- Particular View Result (Inner Result)
	- View Result
	- View Component Result


16. Views 
17. Razor - to insert the C# code inside the html file we use Razor 
18. Razor View Engine - to convert the C# code into Html Code in Webpages we use the Razor View Engine. 

19. Layout View 
20. View Start file - to remove dry principle 



21. Passing data from controller to View 
	- View Data
		->need typecasting 
		->work only in one page 
	- View Bag
		-> no need of type casting
		-> work in only one page
	- Temp Data
		-> need typecasting
		->work in only one page like a temporary data
		->if u want to work in different pages also write TempData.Keep() function we can get in any function also


22. Models
23. Repository pattern
24. strongly typed view


25. Installing Bootstrap , Tailwind , Jquery in ASP.NET core
26. _viewImports.cshtml


27. Directives
	@Taghelper
	@Taghelperprefix
	@remove tag helper
	@namespace
	@inject
	@model
	@using


28. Tag helper
	- anchor tag helper 
		* asp-controller=""
		* asp-action =""
	- image tag helper
		* asp-append-version
	- forms using tag helper
		* asp-for
	
Tag helpers
	- form tag helper
	- for action tag helper
	- input tag helper
	- text area tag helper
	- label tag helper
	- validation tag helper
	- select tag helper
 
Drop Down list
	- asp-for
	- asp-items="Html.GetEnumSelectList<>()
 Radio patterns
	- asp -for
 text area
	- asp-for

	
29.Model Binding

30.Model Validation
	[Required]
	[Stringlength]
	[emailaddres]
	[Range]
	[Compare]
	[Phone]
	[Url]
	[Regular EXpression]
 
31.Model state

32.model state clear


33.Entity Framework core

34. Code first Approach of Entity framework
35. CRUD Operation using Code first Approach
36. Database First Approach 
37. CRUD operation using Database first Approach

38. Session
