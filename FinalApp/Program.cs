var builder = WebApplication.CreateBuilder(args);

builder.WebHost.UseUrls("http://0.0.0.0:5153");
builder.Services.AddControllers();
var app = builder.Build();

app.MapControllers();

app.Run();
