using CogesTest.Blazor.Infrastructure;
using CogesTest.Blazor.Services;
using CogesTest.DataAccess;
using CogesTest.DataAccess.Services;
using CogesTest.Domain.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;

namespace CogesTest.Blazor;

public class Startup
{
    public Startup(IConfiguration configuration) => Configuration = configuration;


    public IConfiguration Configuration { get; }


    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }
        else
        {
            app.UseExceptionHandler("/Error");

            // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            app.UseHsts();
        }

        app.UseHttpsRedirection();
        app.UseStaticFiles();

        app.UseRouting();

        app.UseEndpoints(endpoints => {
            endpoints.MapBlazorHub();
            endpoints.MapFallbackToPage("/_Host");
        });
    }


    public void ConfigureServices(IServiceCollection services)
    {
        services.AddRazorPages();
        services.AddServerSideBlazor();
        services.Configure<CosmosDbSettings>(Configuration.GetSection(nameof(CosmosDbSettings)));

        services.AddDbContextFactory<QuizDbContext>((sp, opts) => {
            var cosmosSettings = sp.GetRequiredService<IOptions<CosmosDbSettings>>().Value;

            var env = sp.GetRequiredService<IHostEnvironment>();
            if (env.IsDevelopment())
            {
                opts.EnableSensitiveDataLogging(env.IsDevelopment());
                opts.EnableDetailedErrors();
            }

            opts.UseCosmos(cosmosSettings.EndPoint, cosmosSettings.AccessKey, "CogesQuizzes");
        });

        services.AddScoped<TitleService>();
        services.AddScoped<IQuizDefinitionService, QuizDefinitionService>();
        services.AddScoped<IQuizRunService, QuizRunService>();
    }
}
