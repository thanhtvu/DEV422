var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.RenameLater>("renamelater");

builder.Build().Run();
