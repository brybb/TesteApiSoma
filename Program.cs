var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/sum", (string? a, string? b) =>
{
    if (!double.TryParse(a, out double numberA))
    {
        return Results.BadRequest(new { error = "O par�metro 'a' n�o � um n�mero v�lido." });
    }

    if (!double.TryParse(b, out double numberB))
    {
        return Results.BadRequest(new { error = "O par�metro 'b' n�o � um n�mero v�lido." });
    }

    var result = numberA + numberB;

    return Results.Ok(new { result });
});

app.Run();
