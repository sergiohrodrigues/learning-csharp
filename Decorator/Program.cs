using Decorator.Data;
using Decorator.Services.ImplaSemDecorator;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();

// Registrando o repositorio
builder.Services.AddSingleton<ProdutoRepositorio>();

// 2. Serviço (Legado)
builder.Services.AddScoped<CalculadoraPrecoProdutoLegado>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapControllers();
app.Run();