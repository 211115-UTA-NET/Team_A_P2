using Microsoft.EntityFrameworkCore;
using PhoenixTheatre.DataInfrastructure;
using PhoenixTheatreAPI.Services;

var builder = WebApplication.CreateBuilder(args);

string connectionString = builder.Configuration.GetConnectionString("ConnectionStringPTDB");

bool prettyPrintJson = builder.Configuration.GetValue<string>("PrettyPrintJsonOutput") == "true";

builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(builder =>
        builder
            .WithOrigins("http://phoenixtheatre.azurewebsites.net",
                         "https://phoenixtheatre.azurewebsites.net",
                         "http://68.15.247.30",
                         "http://localhost:4200")
            .AllowAnyMethod()
            .AllowAnyHeader()
            .AllowCredentials());
});

builder.Services.AddDbContext<Team_A_P2Context>(options =>
{

    options.UseSqlServer(connectionString);
});

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<PhoenixTheatreService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors();

app.UseAuthorization();

app.MapControllers();

app.Run();
