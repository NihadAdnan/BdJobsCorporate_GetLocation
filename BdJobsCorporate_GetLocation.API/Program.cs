using BdJobsCorporate_GetLocation.Repository.Data;
using BdJobsCorporate_GetLocation.Repository.Repository.Abstraction;
using BdJobsCorporate_GetLocation.Repository.Repository;
using BdJobsCorporate_GetLocation.AggregateRoot.Validation;
using BdJobsCorporate_GetLocation.DTO.DTOs;
using BdJobsCorporate_GetLocation.Handler.Abstraction;
using BdJobsCorporate_GetLocation.Handler.Service;
using FluentValidation;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddTransient<DapperDbContext>();

builder.Services.AddScoped<IGenericRepository, GenericRepository>();

builder.Services.AddScoped<IValidator<LocationRequestDTO>, LocationRequestDTOValidator>();
builder.Services.AddScoped<ILocationHandler, LocationHandler>();


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
