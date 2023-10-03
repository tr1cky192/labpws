var builder = WebApplication.CreateBuilder();
var app = builder.Build();

app.Run(async (context) => {
    var response = context.Response;
    response.Headers.ContentLanguage = "en-US";
    response.Headers.ContentType = "text/plain; charset=utf-8";
    response.Headers.Append("secret-id", "256");
    await response.WriteAsync("Hello World!");
});

app.Run();