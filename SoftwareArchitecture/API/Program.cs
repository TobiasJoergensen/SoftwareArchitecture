using Application;
using Infrastructure;
using Infrastructure.Data;
using Presentation.Infrastructure;

namespace Presentation
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.AddInfrastructureServices();
            builder.AddApplicationServices();
            builder.AddWebServices();


            builder.Services.AddControllers();
            // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
            builder.Services.AddOpenApi();
            builder.Services.AddAuthentication("DefaultScheme");
            builder.Services.AddAuthorization();

            var app = builder.Build();
            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.InitialiseDatabaseAsync();

                app.MapOpenApi();
            }

            /*
            var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

            builder.Services.AddCors(options =>
            {
                options.AddPolicy(name: MyAllowSpecificOrigins,
                                  policy =>
                                  {
                                      policy.WithOrigins("http://localhost:4200/",
                                                          "http://localhost:5017/",
                                         "http://localhost:5017/people").AllowAnyOrigin();
                                  });
            });

            app.UseCors(MyAllowSpecificOrigins);
            */
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseAuthorization();

            app.MapControllers().AllowAnonymous();
            app.MapEndpoints();

            app.Run();
        }
    }
}
