using Backend.BusinessLogic.Data;
using Backend.BusinessLogic.Interfaces;
using Backend.Context;
using Backend.Repositories.Data;
using Backend.Repositories.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// aktifkan Dapper 
builder.Services.AddTransient<DapperDBConteks>();
// Register the IAssetLogic and its implementation , SCope nya Repos dan logic
builder.Services.AddScoped<IAssetRepository, AssetRepository>();
builder.Services.AddScoped<IAssetLogic, AssetLogic>();


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
