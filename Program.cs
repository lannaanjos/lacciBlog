using LacciAPI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlite("Data Source=PostagensAPI.db"));

var app = builder.Build();

app.MapGet("/usuarios", () =>
{
    List<String> nomes = new List<String>
    {
        "Sophie",
        "Bela",
        "Smi"
    };

    return nomes;
});

// app.MapPost("/usuarios", (string nome) =>
// {
//     return Results.Ok($"Usuário {nome} adicionado com sucesso!");
// });

// app.MapPut("/usuarios", (int id, string novoNome) =>
// {
//     return Results.Ok($"usuário {novoNome} atualizado com sucesso!");
// });

// app.MapPatch("/usuarios", (int id, string campo, string valor) =>
// {
//     return Results.Ok($"Usuário {id} teve o campo {campo} atualizado para {valor}");
// });

// app.MapDelete("/usuarios", (int id) =>
// {
//     return Results.Ok($"Usuário {id} deletado com sucesso!");
// });

app.Run();
