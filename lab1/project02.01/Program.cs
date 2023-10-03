WebApplicationOptions options = new() { Args = args };
WebApplicationBuilder builder = WebApplication.CreateBuilder(options);

var app = builder.Build();

app.MapGet("/", () => "Good game!");

app.Run();

