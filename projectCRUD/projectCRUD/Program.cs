using FluentValidation;
using MediatR;
using Microsoft.EntityFrameworkCore;
using projectCRUD.Models;
using projectCRUD.Models.PipeLineBehaviours;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// add DBconntectivity.
builder.Services.AddDbContext<StudDetailsContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));


//Add Mediatr
builder.Services.AddMediatR(typeof(Program));


//Add pipelinevalidators
builder.Services.AddValidatorsFromAssembly(typeof(Program).Assembly);
builder.Services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehaviour<,>));


//Add Logger 
var _logger = new LoggerConfiguration().ReadFrom.Configuration(builder.Configuration).Enrich.FromLogContext().CreateLogger();
builder.Logging.AddSerilog(_logger);


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
