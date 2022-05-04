var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.

// 重導向至 Https
// app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
