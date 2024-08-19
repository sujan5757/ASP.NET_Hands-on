var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// app.MapGet("/", () => "Hello World!");
app.Use(async (context,next) =>
{
await context.Response.WriteAsync("welcome to everi");
    await next(context);

});



app.Run(async (context) =>
{
    await context.Response.WriteAsync("Sujan P S");

});

app.Run();
