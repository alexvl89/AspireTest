using Projects;

var builder = DistributedApplication.CreateBuilder(args);

//sampleApi - �������� ��� �������
builder.AddProject<dotnet8Aspire_WebApi>("sampleApi");

builder.Build().Run();
