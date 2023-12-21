var builder = WebApplication.CreateBuilder();

var app = builder.Build();

app.Run(HandleRequst);
app.Run();

async Task HandleRequst(HttpContext context)
{
    await context.Response.WriteAsync("DOTA 2, IMORTAL");
}
