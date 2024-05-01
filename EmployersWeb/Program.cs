using EmployeesStore.App.Validators;
using EmployeesStore.Core.Abstractions;
using EmployeesWeb.Api;
using EmployersWeb.Api;



var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<ValidationResult>();
builder.Services.AddControllers();
builder.Services.AddTransient<DapperDbContext>();
builder.Services.AddTransient<IEmployeesRepository, EmployeesRepository>();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
