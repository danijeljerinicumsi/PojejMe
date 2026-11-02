var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.MapGet("/", () => "New application update.");

app.Run();