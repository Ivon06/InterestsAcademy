using CloudinaryDotNet;
using InterestsAcademy.Data;
using InterestsAcademy.Data.Models;
using InterestsAcademy.Extensions;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("InterestsAcademyDbContextConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
builder.Services.AddDbContext<InterestsAcademyDbContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

ConfigureCloudinaryService(builder.Services, builder.Configuration);

builder.Services.AddDefaultIdentity<User>(options =>
{

    options.SignIn.RequireConfirmedAccount = false;
    options.Password.RequireDigit = false;
    options.Password.RequireLowercase = false;
    options.Password.RequireUppercase = false;
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequiredLength = 6;

    options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(15);
    options.Lockout.MaxFailedAccessAttempts = 5;
})
                .AddRoles<IdentityRole>()
                .AddEntityFrameworkStores<InterestsAcademyDbContext>();
              
builder.Services.AddControllersWithViews();

builder.Services.ConfigureServices();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
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
app.MapRazorPages();

app.Run();


static void ConfigureCloudinaryService(IServiceCollection services, IConfiguration configuration)
{

	var cloudName = configuration.GetValue<string>("AccountSettings:CloudName");
	var apiKey = configuration.GetValue<string>("AccountSettings:ApiKey");
	var apiSecret = configuration.GetValue<string>("AccountSettings:ApiSecret");

	if (new[] { cloudName, apiKey, apiSecret }.Any(string.IsNullOrWhiteSpace))
	{
		throw new ArgumentException("Please specify your Cloudinary account Information");
	}

	services.AddSingleton(new Cloudinary(new Account(cloudName, apiKey, apiSecret)));
}