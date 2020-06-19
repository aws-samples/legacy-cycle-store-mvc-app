## Modernize and Containerize Legacy MVC .NET application with Entity Framework to .NET Core with Entity Framework Core - Part 1

There are tens of thousands of .NET applications running across the world, many of which are ASP.NET web applications.  This number becomes interesting when you consider that the .NET framework, as we know it, will be changing significantly.  The current release schedule for .NET 5.0 is November 2020 and going forward there will be just one .NET and you will be able to use it to target multiple platform like Windows, Linux etc.  This is important because those .NET applications running in version 4.8 and lower cannot automatically upgrade to this new version of .NET.  This is because .NET 5.0 is based on .NET Core and thus has breaking changes when trying to upgrade from a “regular” version of .NET.  
This is an important step in the .NET ecosphere, as it enables .NET applications to move beyond the Windows world.  However, this also means that active applications will need to go through a refactoring before they can take advantage of this new definition.  One choice for this refactoring would be to wait until the new version of .NET is released and start the refactoring process at that time.  The second choice would be to get an early start and start converting your applications to .NET Core v3.1 so that the migration to .NET 5.0 will be smoother.  This is the purpose of this article, to demonstrate an approach of migrating an ASP.NET MVC Web Application using Entity Framework 6 to and ASP.NET Core with EF Core.

This post shows steps to modernize a legacy enterprise MVC ASP.NET web application using .net core along with converting Entity Framework to Entity Framework Core.

### Overview of solution
The first steps that we will take is to get an Asp.NET MVC application and it’s required database server up and working in your AWS environment.  We are taking this approach so that you can run the application locally to see how it works. 

## Security

See [CONTRIBUTING](CONTRIBUTING.md#security-issue-notifications) for more information.

## License

This library is licensed under the MIT-0 License. See the LICENSE file.

