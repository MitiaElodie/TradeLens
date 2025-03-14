using Microsoft.EntityFrameworkCore;
using TradeLens.Server.BusinessLogic;
using TradeLens.Server.Profiles;
using TradeLens.Server.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<TradeImportService>();
builder.Services.AddScoped<TradeBusinessLogic>();

// Register AutoMapper
builder.Services.AddAutoMapper(typeof(Program));

builder.Services.AddDbContext<TradeLensDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("TradeLensDb")));

var app = builder.Build();

app.UseDefaultFiles();
app.UseStaticFiles();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors(builder =>
    builder.AllowAnyOrigin()
           .AllowAnyMethod()
           .AllowAnyHeader());

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.MapFallbackToFile("/index.html");

app.Run();
