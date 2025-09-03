using Future_Finans.Components;
using FutureFinans.Data;
using FutureFinans.Services;
using Microsoft.AspNetCore.Localization;
using Microsoft.EntityFrameworkCore;
using MudBlazor.Services;
using System.Globalization;

namespace Future_Finans
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services
            builder.Services.AddRazorComponents()
                .AddInteractiveServerComponents();





            builder.Services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

            builder.Services.AddLocalization(options => options.ResourcesPath = "Resources");

            builder.Services.AddHttpContextAccessor();
            builder.Services.AddScoped<LoanService>();



            // MudBlazor Services
            builder.Services.AddMudServices();

            var app = builder.Build();

            // Localization
            var supportedCultures = new[] { new CultureInfo("en"), new CultureInfo("sv") };
            var localizationOptions = new RequestLocalizationOptions
            {
                DefaultRequestCulture = new RequestCulture("en"),
                SupportedCultures = supportedCultures,
                SupportedUICultures = supportedCultures
            };
            app.UseRequestLocalization(localizationOptions);

            // Configure middleware
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            // Optional: if you have authentication/authorization
            // app.UseAuthentication();
            // app.UseAuthorization();

            // Antiforgery
            app.UseAntiforgery();

            // Map Razor Components
            app.MapRazorComponents<App>()
               .AddInteractiveServerRenderMode();

            app.Run();
        }
    }
}
