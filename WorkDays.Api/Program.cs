using Microsoft.EntityFrameworkCore;
using WorkDays.Application.Profiles;
using WorkDays.Core.Services;
using WorkDays.Core.Services.Interfaces;
using WorkDays.Infra;
using WorkDays.Infra.SQLServer.Repositories;
using WorkDays.Infra.SQLServer.Repositories.Interfaces;
using AutoMapper;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSwaggerGen();

string connectionString = builder.Configuration.GetConnectionString("Sql");
builder.Services.AddDbContext<WorkDaysDbContext>(options => options.UseSqlServer(connectionString));

builder.Services.AddScoped<ICompanyService, CompanyService>();
builder.Services.AddScoped<ICompanyRepository, CompanyRepository>();
builder.Services.AddScoped<IProjectService, ProjectService>();
builder.Services.AddScoped<IProjectRepository, ProjectRepository>();
builder.Services.AddScoped<IWorkDayService, WorkDayService>();
builder.Services.AddScoped<IWorkDayRepository, WorkDayRepository>();

var mappingConfig = new MapperConfiguration(mc =>
{
    mc.AddProfile(new MappingProfile());
});

IMapper mapper = mappingConfig.CreateMapper();
builder.Services.AddSingleton(mapper);



//builder.Services.AddHangfire(x => x.UseSqlServerStorage(connectionString));

//builder.Services.AddHangfireServer();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseRouting();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Company}/{action=Index}/{id?}");


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
