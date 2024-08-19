var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();


app.UseRouting();

app.UseEndpoints(endpoints =>
{
    endpoints.MapGet("/Home", async (context) =>
    {
      await  context.Response.WriteAsync("This is home page");
    });

    //post
    //put
    //delete 

    //this is for sapecfic url and specific login inside the function
});

//app.MapGet("/", () => "Hello World! - GET");//deligator

//app.MapPost("/", () => "Hello World! - Post");

//app.MapPut("/", () => "Hello World! - Put");

//app.MapDelete("/", () => "Hello World! - Delete");

//app.Map("/Home", () => "Hello World!");//kt will work with all the methods 


app.Run();
