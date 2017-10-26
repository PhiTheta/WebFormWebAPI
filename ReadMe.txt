WebForms based WebAPI 2.2 project in Visual Studio 2012

1. Go to File > New > Project
2. Select ASP.NET Empty Web Application
3. Once application is created go to the Project in Solution Explorer, Right click and Select Manage Nuget Packages
4. In the Manage NuGet packages window Search for WebAPI, select "Microsoft ASP.NET WEb API 2.2" and click install
5. After installation add a file named HelloApiController
6. Add Following lines to the class file
 using System.Web.Http;
 
 public class HelloApiController : ApiController
    {
        //Browse using : api/HelloApi/Get

        public string Get()
        {
            return "Hello";
        }
    }
	
7. Add a Global.asax file and in the Application_Start method write the below code
using System.Web.Http;

 GlobalConfiguration.Configure(config =>
            {
                config.MapHttpAttributeRoutes();

                config.Routes.MapHttpRoute(
                    name: "DefaultApi",
                    routeTemplate: "api/{controller}/{id}",
                    defaults: new { id = RouteParameter.Optional }
                );
            });

8. Compile it and browse : localhost:<port number>/api/HelloApi and you shall see Hello appear on the page.