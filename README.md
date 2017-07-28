## ASP.NET WebApi Remote Controllers
This project is a demo showing how to create an *ASP.NET WebAPI 2 RESTful JSON API* that dynamically loads external assemblies (DLLs) that contain APi Routes.

### What is included
The repo contains a single solution with three demo route projects and a single base empty WebAPI 2 project that loads the route group assemblies:

#### Project: API
> The API project is based on the Empty Web Project with added support for Web API. Make note that the project loads a custom JSON text formatter as well as a custom assembly loader.

> All of the following projects are route group assemblies that contain a Post-Build command to copy the project assembly DLL into a custom folder called "Controllers" in the bin directory of the API project. That is the location from where the API project dynamically finds and loads the route group assemblies.

#### Project: Utilities
> This project contains helper classes with methods and enumerators.  It contains a Post-Build Event to copy the project assembly into the API project's bin/Controllers project so that the assemblies coppied to that subfolder can find and access the DLL helper methods.

#### Project: DefaultController
> The DefaultController project is built as a simple Class Project with System.ASP.NET.WebAPI.Core added using NuGet. It references the Utilities Project directly via references. It contains no Model or View, but simply a Controller. 

#### Project: MathAPI
> This project is built as a simple Class Project with System.ASP.NET.WebAPI.Core added using NuGet. It references the Utilities Project directly via references. This demonstrates how to create more complex routes with a slightly different namespace to organize your API.

#### Project: SampleMvcAPI
> The SampleMvcAPI project is built as a simple Class Project with System.ASP.NET.WebAPI.Core added using NuGet. It references the Utilities Project directly via references. This is a demonstration of separating the code into a number of MVC concerns as well as classes to support data access called from the Model along with Entity classes to hold and pass data.

### How to use the solution
Rebuilding everything before launching the project.  This should open a browser window like chrome to view the output of the default controller. Changing the path to match the included route patterns for the SampleMvcAPI or the MathAPI should render the appropriate result.

I highly recommend getting the POSTMAN extension application for the Chrome Browser in order to test your APIs.

To add route groups to your library, either Copy and Paste a copy of the appropriate demo project and change the assembly name, or create a new Empty Web Project in Visual Studio 2015, adding a NuGet Reference to System.ASP.NET.WebAPI.Core as well as a direct reference to the Utilties Project.  Be sure that your class updates the RoutePrefix to point to another base route like "api/some-new-base-api" so that your code doesn't collide with other assemblied in the API bin/Controllers subfolder. Once you have Built your Assembly, copy it into the API's bin/Controllers subfolder (bin is where the API project likely lives.  You simply want to use the Controllers subfolder beneath the folder containing the API.DLL assembly.)

Two assemblies with matching namespaces and end points will not work. The resource will simply appear to not be found. 

Once you have your API in place, changing or adding assemblies in the Controllers subfolder requires that you restart the API IIS App in order to find those changed or new assemblies and load them into memory.
