var builder = WebApplication.CreateBuilder();

var app = builder.Build();

int x = 16;
app.Run(async (context) =>
{
    x = x / 4; 
    await context.Response.WriteAsync($"Result: {x}");
});
app.Run();
