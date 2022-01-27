using PhoenixTheatre.DataInfrastructure;
using PhoenixTheatreAPI.Services;

var PTSpecificOrigins = "_PTSpecificOrigins";

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: PTSpecificOrigins,
                      builder =>
                      {
                          builder.WithOrigins("http://phoenixtheatre.azurewebsites.net",
                                               "https://phoenixtheatre.azurewebsites.net")
                                               .AllowAnyHeader();
                      });
});

string connectionString = builder.Configuration.GetConnectionString("ConnectionStringPTDB");

builder.Services.AddSqlServer<Team_A_P2Context>(connectionString);

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

app.UseCors(PTSpecificOrigins);

app.UseAuthorization();

app.MapControllers();

app.Run();
