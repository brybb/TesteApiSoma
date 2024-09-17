var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/sum", (string? a, string? b) =>
{
    if (!double.TryParse(a, out double numberA))
    {
        return Results.BadRequest(new { error = "O parâmetro 'a' não é um número válido." });
    }

    if (!double.TryParse(b, out double numberB))
    {
        return Results.BadRequest(new { error = "O parâmetro 'b' não é um número válido." });
    }

    var result = numberA + numberB;

    return Results.Ok(new { result });
});

app.Run();
