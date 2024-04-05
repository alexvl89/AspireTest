using Projects;

var builder = DistributedApplication.CreateBuilder(args);

//sampleApi - названия для проекта
builder.AddProject<dotnet8Aspire_WebApi>("sampleApi");

builder.Build().Run();
