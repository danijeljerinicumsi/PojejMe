var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.MapGet("/", () => "App update as of Mon Nov 9.");

app.Run();