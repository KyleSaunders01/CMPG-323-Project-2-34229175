# CMPG 323 Project 2 34229175
This is my Project 2 API - https://project-2-34229175.azurewebsites.net/
I will be giving a short guide on how to use and test the api with swagger. Note that the response will have $ values in that is from using json serialization so that id's don't get confused as we're not using GUID's but simple int values
These are the formats you should use when testing the API

GET: The get methods are fairly simple, you can do all or you can get specific values using id's
POST: Customer - {
                   "customerId": 0,
                   "customerTitle": "string",
                   "customerName": "string",
                   "customerSurname": "string",
                   "cellPhone": "string"
                  } 
       Order -    {
                    "orderId": 0,
                    "orderDate": "2023-08-31T06:31:06.666Z",
                    "customerId": 0,
                    "deliveryAddress": "string"
                   }
       Product -   {
                    "productId": 0,
                    "productName": "string",
                    "productDescription": "string",
                    "unitsInStock": 0
                    }
                    
PATCH: You can just modify the field you want to change.
DELETE: Just enter the ID of the field you want to delete.


References: 

-Rakesh KumarRakesh Kumar&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; 2, Jason PanJason Pan&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; 15.2k11 gold badge1414 silver badges2929 bronze badges and L DVL DV&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; 111 bronze badge (1969) Getting HTTP error 500.0 - internal server error after deploying .NET 7 web API to Azure App Service, Stack Overflow. Available at: https://stackoverflow.com/questions/76366069/getting-http-error-500-0-internal-server-error-after-deploying-net-7-web-api (Accessed: 31 August 2023). 

-Omer et al. (1969) Could not load file or assembly ‘system.runtime, version=7.0.0.0...’ - after installing .NET core 7 ‘dotnet Watch run’ not working, Stack Overflow. Available at: https://stackoverflow.com/questions/74367760/could-not-load-file-or-assembly-system-runtime-version-7-0-0-0-after-ins (Accessed: 31 August 2023). 

-Amateur_coder, Amateur_coderAmateur_coder&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; 8199 bronze badges and HarshithaHarshitha&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; 3 (1969) Be sure that the startup.cs for your application is calling Addswaggergen from within configureservices in order to generate Swagger File, Stack Overflow. Available at: https://stackoverflow.com/questions/74064821/be-sure-that-the-startup-cs-for-your-application-is-calling-addswaggergen-from-w/74093408#74093408 (Accessed: 31 August 2023). 

-Zuckerthoben (no date) Get started with Swashbuckle and asp.net core, Microsoft Learn. Available at: https://learn.microsoft.com/en-us/aspnet/core/tutorials/getting-started-with-swashbuckle?view=aspnetcore-3.1&amp;tabs=visual-studio (Accessed: 31 August 2023). 

-Daniel JacksonDaniel Jackson&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; 1 et al. (1963) Services.addswaggergen() giving error, Stack Overflow. Available at: https://stackoverflow.com/questions/43707733/services-addswaggergen-giving-error (Accessed: 31 August 2023). 

-VKiq (no date) Publishing to azure from VS2019 failed due to not seeing Addswaggergen., Microsoft Q&amp;A. Available at: https://learn.microsoft.com/en-us/answers/questions/731287/publishing-to-azure-from-vs2019-failed-due-to-not (Accessed: 31 August 2023). 

-BillWagner (no date) Using exceptions, Using Exceptions | Microsoft Learn. Available at: https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/exceptions/using-exceptions (Accessed: 31 August 2023). 

-BillWagner (no date a) Exceptions and exception handling, Microsoft Learn. Available at: https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/exceptions/ (Accessed: 31 August 2023). 

-Reeves62 et al. (1967) Web app HTTP 404 error in azure but runs locally, Stack Overflow. Available at: https://stackoverflow.com/questions/64159984/web-app-http-404-error-in-azure-but-runs-locally (Accessed: 31 August 2023). 

-Orchard Dojo (no date) C# best practices - Coding best practices | Orchard Dojo. Available at: https://orcharddojo.net/orchard-resources/Library/DevelopmentGuidelines/BestPractices/CSharp#:~:text=When%20checking%20if%20an%20IEnumerable,Count()%20%3D%3D%200%20. (Accessed: 31 August 2023). 

-VKiq (no date) Publishing to azure from VS2019 failed due to not seeing Addswaggergen., Microsoft Q&amp;A. Available at: https://learn.microsoft.com/en-us/answers/questions/731287/publishing-to-azure-from-vs2019-failed-due-to-not (Accessed: 31 August 2023). 

-Difference between put and Patch Request (2023) GeeksforGeeks. Available at: https://www.geeksforgeeks.org/difference-between-put-and-patch-request/ (Accessed: 31 August 2023). 

-LightToTheEndLightToTheEnd&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; 1 et al. (1963) ‘build failed’ on database first scaffold-dbcontext, Stack Overflow. Available at: https://stackoverflow.com/questions/38961115/build-failed-on-database-first-scaffold-dbcontext (Accessed: 31 August 2023). 

-Lakkoju, S. (no date) I want to scaffold dbcontext efcore in .NET 6 web API from Azure SQL Database, Microsoft Q&amp;A. Available at: https://learn.microsoft.com/en-us/answers/questions/1109311/i-want-to-scaffold-dbcontext-efcore-in-net-6-web-a (Accessed: 31 August 2023). 

-Alexwolfmsft (no date) Connect to and query azure SQL database using .NET and the Microsoft.data.SqlClient Library - Azure SQL database, Azure SQL Database | Microsoft Learn. Available at: https://learn.microsoft.com/en-gb/azure/azure-sql/database/azure-sql-dotnet-quickstart?view=azuresql&amp;tabs=visual-studio%2Cpasswordless%2Cservice-connector%2Cportal (Accessed: 31 August 2023). 

-Code Maze (2020) ASP.NET core web API with EF Core DB-first approach, Code Maze. Available at: https://code-maze.com/asp-net-core-web-api-with-ef-core-db-first-approach/ (Accessed: 31 August 2023). 

-Bricelam (no date) Reverse Engineering - EF Core, Reverse Engineering - EF Core | Microsoft Learn. Available at: https://learn.microsoft.com/en-gb/ef/core/managing-schemas/scaffolding/?tabs=vs (Accessed: 31 August 2023). 

-Owlypixel (no date) Scaffolding an application from existing database with EF Core on asp.net core, Your Sites RSS. Available at: https://owlypixel.com/scaffolding-application-existing-database-ef-core-asp-net-core/ (Accessed: 31 August 2023). 

-Creating a model for an existing database in entity Framework Core (no date) Entity Framework Tutorial. Available at: https://www.entityframeworktutorial.net/efcore/create-model-for-existing-database-in-ef-core.aspx (Accessed: 31 August 2023). 

-WilliamDAssafMSFT (no date) Delete a database - SQL server, SQL Server | Microsoft Learn. Available at: https://learn.microsoft.com/en-us/sql/relational-databases/databases/delete-a-database?view=sql-server-ver16 (Accessed: 31 August 2023). 

-MS SQL Server - Drop Database (no date) Tutorialspoint. Available at: https://www.tutorialspoint.com/ms_sql_server/ms_sql_server_drop_database.htm#:~:text=Connect%20to%20SQL%20Server%20and,screen)%20from%20MS%20SQL%20Server. (Accessed: 31 August 2023). 

-MS SQL Server - creating backups (no date) Tutorialspoint. Available at: https://www.tutorialspoint.com/ms_sql_server/ms_sql_server_creating_backups.htm (Accessed: 31 August 2023). 

-Author: Jacqui MullerFeel free to reach out or browse through:LinkedInGitHubThe JPanda – Automation et al. blogs et al. (2022) Join two entities in .NET core, using Lambda and entity Framework Core, JD Bots. Available at: https://jd-bots.com/2022/01/24/join-two-entities-in-net-core-using-lambda-and-entity-framework-core/ (Accessed: 31 August 2023). 

-Sanjay (2021) Entity framework core in ASP.NET CORE 3.1 - Getting started, Pro Code Guide. Available at: https://procodeguide.com/programming/entity-framework-core-in-asp-net-core/ (Accessed: 31 August 2023). 

-Nishanil (no date) Create microservices with .NET and ASP.NET Core - training, Training | Microsoft Learn. Available at: https://learn.microsoft.com/en-us/training/paths/create-microservices-with-dotnet/ (Accessed: 31 August 2023). 

-RicoSuter (no date) ASP.NET core web API documentation with swagger / openapi, Microsoft Learn. Available at: https://learn.microsoft.com/en-us/aspnet/core/tutorials/web-api-help-pages-using-swagger?view=aspnetcore-3.1 (Accessed: 31 August 2023). 

-Jongalloway (no date) Rest in ASP.NET Core - training, Training | Microsoft Learn. Available at: https://learn.microsoft.com/en-us/training/modules/build-web-api-aspnet-core/2-what-is-rest-in-aspnet?source=learn (Accessed: 31 August 2023). 

-Jongalloway (no date a) Exercise - create a web API project - training, Training | Microsoft Learn. Available at: https://learn.microsoft.com/en-us/training/modules/build-web-api-aspnet-core/3-exercise-create-web-api (Accessed: 31 August 2023). 

-Jongalloway (no date a) Exercise - add a Controller - training, Training | Microsoft Learn. Available at: https://learn.microsoft.com/en-us/training/modules/build-web-api-aspnet-core/6-exercise-add-controller (Accessed: 31 August 2023). 
