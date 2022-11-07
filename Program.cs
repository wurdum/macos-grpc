using learn_grpc.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddGrpc();
builder.Services.AddGrpcReflection();

var app = builder.Build();

app.MapGrpcReflectionService();
app.MapGrpcService<GreeterService>();

app.MapGet("/", () => "Hello from gRPC!");

app.Run();
