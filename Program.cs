using dotnet_backend_template_unicomTic.ApplicationDbContext;
using dotnet_backend_template_unicomTic.Interface.IRepositpory;
using dotnet_backend_template_unicomTic.Interface.IService;
using dotnet_backend_template_unicomTic.Repository;
using dotnet_backend_template_unicomTic.Service;
using dotnet_backend_template_unicomTic.Interface;
using dotnet_backend_template_unicomTic.Repository;
using dotnet_backend_template_unicomTic.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddCors(options =>
{
  options.AddPolicy("AllowAllOrigins", builder =>
      builder.AllowAnyOrigin()
             .AllowAnyHeader()
             .AllowAnyMethod());
});
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<AppDbContext>(option =>
{
  option.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});



builder.Services.AddScoped<IStudentRepository, StudentRepository>();
builder.Services.AddScoped<IStudentService, StudentService>();

builder.Services.AddScoped<ICourseRepository, CourseRepository>();
builder.Services.AddScoped<ICourseServices, CourseServices>();

var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
  app.UseSwagger();
  app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors("AllowAllOrigins");

app.UseAuthorization();

app.MapControllers();

app.Run();
