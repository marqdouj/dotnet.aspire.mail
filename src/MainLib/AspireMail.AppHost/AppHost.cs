var builder = DistributedApplication.CreateBuilder(args);

var maildev = builder.AddMailDev("maildev");

var apiService = builder.AddProject<Projects.AspireMail_ApiService>("apiservice")
    .WithHttpHealthCheck("/health")
    .WithReference(maildev);

builder.AddProject<Projects.AspireMail_WebApp>("webapp")
    .WithExternalHttpEndpoints()
    .WithHttpHealthCheck("/health")
    .WithReference(apiService)
    .WaitFor(apiService);

builder.Build().Run();
