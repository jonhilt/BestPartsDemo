var builder = DistributedApplication.CreateBuilder(args);

var cache = builder.AddRedis("cache").WithRedisInsight();

builder.AddProject<Projects.BestPartsDemo>("bestpartsdemo")
    .WithReference(cache);

builder.Build().Run();
