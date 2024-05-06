using _03.Middleware.Middlewares;

var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.UseMiddleware<TokenMiddleware>();

app.Run(async (context) => await context.Response.WriteAsync("Hello, World!"));

app.Run();
