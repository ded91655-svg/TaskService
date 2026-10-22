var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/tasks", () => new[]
{
    new { Id = 1, Title = "Сделать КТ", Done = false },
    new { Id = 2, Title = "Сдать Docker", Done = true }
});

app.MapGet("/health", () => "OK");

app.Run();