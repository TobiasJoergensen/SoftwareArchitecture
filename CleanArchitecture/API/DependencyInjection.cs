using Azure.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;


namespace Presentation;

public static class DependencyInjection
{
    public static void AddWebServices(this IHostApplicationBuilder builder)
    {
        //builder.Services.AddDatabaseDeveloperPageExceptionFilter();

        builder.Services.AddHttpContextAccessor();
#if (!UseAspire)
        //builder.Services.AddHealthChecks()
        //    .AddDbContextCheck<ApplicationDbContext>();
#endif

#if (!UseApiOnly)
        builder.Services.AddRazorPages();
#endif

        // Customise default API behaviour
        builder.Services.Configure<ApiBehaviorOptions>(options =>
            options.SuppressModelStateInvalidFilter = true);

        builder.Services.AddEndpointsApiExplorer();
    }
}
