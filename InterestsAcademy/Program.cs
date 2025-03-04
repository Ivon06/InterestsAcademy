using CloudinaryDotNet;
using InterestsAcademy.Common;
using InterestsAcademy.Core.Hubs;
using InterestsAcademy.Data;
using InterestsAcademy.Data.Models;
using InterestsAcademy.Extensions;
using InterestsAcademy.Middlewares;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("ServerConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
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

//builder.Services.AddControllersWithViews();

builder.Services.ConfigureServices();

builder.Services.ConfigureApplicationCookie(options =>
{
    options.LoginPath = "/Account/Login";
    options.LogoutPath = "/Account/Logout";


});



var emailConfig = builder.Configuration
               .GetSection("EmailConfiguration")
               .Get<EmailConfig>();

builder.Services.AddSingleton(emailConfig);

builder.Services.AddCors(options =>
{
    options.AddPolicy("MyPolicy",
        builder =>
        {
            builder.WithOrigins("https://localhost:7102")
               .AllowAnyHeader()
               .WithMethods("GET", "POST", "PUT")
               .AllowCredentials();

        });
});

builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(10);
});


builder.Services
    .AddControllersWithViews(options =>
    {
        options.Filters.Add(new AutoValidateAntiforgeryTokenAttribute());
    });


builder.Services.AddResponseCaching();

builder.Services.AddSignalR();

var app = builder.Build();

app.MapHub<RequestHub>("/requestHub");

app.MapHub<ActivityHub>("/activityHub");

app.MapHub<DonationHub>("/donationHub");

app.MapHub<PrivateChatHub>("/privateChatHub");

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


app.UseCors("MyPolicy");
app.UseCors();

if (app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error500");

    app.UseStatusCodePagesWithRedirects("/Home/Error{0}");

    //app.UseDeveloperExceptionPage();
}
else
{
    app.UseExceptionHandler("/Home/Error500");

    app.UseStatusCodePagesWithRedirects("/Home/Error{0}");
}

app.UseSession();

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();

app.UseMiddleware<OnlineUserMiddleware>();


app.MapControllerRoute(
                   name: "Areas",
                   pattern: "/{area:exists}/{controller=Home}/{action=Index}/{id?}"
               );

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.UseAuthorization();

app.MapDefaultControllerRoute();
app.MapRazorPages();


//app.MapRazorPages();




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