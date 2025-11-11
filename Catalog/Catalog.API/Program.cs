using Catalog.Application.Contracts;
using Catalog.Application.Features.Products.Commands.DiscountPrice;
using Catalog.Application.Services;
using Catalog.Infrastructure.Data;
using Catalog.Infrastructure.EventHandlers;
using Catalog.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<IProductRepository, EFProductRepository>();
builder.Services.AddMediatR(config => {
    config.RegisterServicesFromAssemblyContaining<DiscountPriceRequest>();
    config.RegisterServicesFromAssemblyContaining<ProductPriceChangedEventHandler>();
   
});

var connectionString = builder.Configuration.GetConnectionString("db");
builder.Services.AddDbContext<CatalogDbContext>(option => option.UseSqlServer(connectionString));



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
