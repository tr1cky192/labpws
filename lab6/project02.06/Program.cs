var builder = WebApplication.CreateBuilder();

var app = builder.Build();

int x = 2;
app.Run(async (context) =>
{
    x = x * 2;  //  2 * 2 = 4
    await context.Response.WriteAsync($"Result: {x}");
});
app.Run();
