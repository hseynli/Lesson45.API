using _04.Middleware.MiddlewareExtensions;

var builder = WebApplication.CreateBuilder();
var app = builder.Build();

app.UseToken();

app.Run(async (context) => await context.Response.WriteAsync("Hello, World!"));

app.Run();