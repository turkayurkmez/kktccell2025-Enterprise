using Catalog.Application.Contracts;
using Catalog.Application.Features.Products.Commands.DiscountPrice;
using Catalog.Application.Services;
using Catalog.Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<IProductRepository, FakeProductRepository>();
builder.Services.AddMediatR(config => {
    config.RegisterServicesFromAssemblyContaining<DiscountPriceRequest>();
});

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
