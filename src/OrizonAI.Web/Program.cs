using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using OrizonAI.Application.AI.Contracts;
using OrizonAI.Application.AI.Factories;
using OrizonAI.Infrastructure.Data;
using OrizonAI.Infrastructure.Identity;
using OrizonAI.Infrastructure.Options;
using OrizonAI.Infrastructure.Providers;
using OrizonAI.Infrastructure.Providers.OpenAI;
using OrizonAI.Infrastructure.Seed;
using OrizonAI.Application.Interfaces.Repositories;
using OrizonAI.Application.Interfaces.Services;
using OrizonAI.Infrastructure.Repositories;
using OrizonAI.Application.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services
    .AddIdentity<ApplicationUser, IdentityRole>(options =>
    {
        options.Password.RequireDigit = true;
        options.Password.RequiredLength = 6;
        options.Password.RequireUppercase = false;
        options.Password.RequireNonAlphanumeric = false;
    })
    .AddEntityFrameworkStores<AppDbContext>()
    .AddDefaultTokenProviders();

builder.Services.Configure<OpenAIOptions>(options =>
{
    builder.Configuration.GetSection(OpenAIOptions.SectionName).Bind(options);

    options.ApiKey = Environment.GetEnvironmentVariable("OPENAI_API_KEY")
                     ?? options.ApiKey;
});

builder.Services.AddHttpClient();

builder.Services.AddScoped<IAIProvider, OpenAIProvider>();
builder.Services.AddScoped<IProviderFactory, ProviderFactory>();
builder.Services.AddScoped<IPlanRepository, PlanRepository>();
builder.Services.AddScoped<IPlanService, PlanService>();
builder.Services.AddScoped<IAIProviderRepository, AIProviderRepository>();
builder.Services.AddScoped<IAIProviderService, AIProviderService>();
builder.Services.AddScoped<IAIModelRepository, AIModelRepository>();
builder.Services.AddScoped<IAIModelService, AIModelService>();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "areas",
    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

await IdentitySeeder.SeedAsync(app.Services);

app.Run();