using api_cadastro_backend.Model;
using api_cadastro_backend.Model.DTOs.Usuario;
using api_cadastro_backend.Repository;
using api_cadastro_backend.Repository.Interfaces;
using api_cadastro_backend.Services;
using api_cadastro_backend.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();

builder.Services.AddScoped<IUsuarioServices, UsuarioServices>();
builder.Services.AddScoped<IUsuarioRepository, UsuarioRepository>();


builder.Services.AddDbContext<Context>(options =>
{
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection"));
});


var app = builder.Build();
app.MapControllers();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseRouting();
app.UseEndpoints(endpoint => { endpoint.MapControllers(); });
app.Run();