using API.Data;
using API.Helpers;
using API.Interfaces;
using API.Services;
using Microsoft.EntityFrameworkCore;

using AutoMapper;

namespace API.Extensions;

public static class ApplicationServiceExtensions
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration config)
    {
        services.AddControllers();
        services.AddDbContext<DataContext>(options =>
        {
            options.UseSqlite(config.GetConnectionString("DefaultConnection"));
        });

        // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
        services.AddOpenApi();

        services.AddCors(options =>
        {
            options.AddPolicy("CorsPolicy",
                builder => builder.AllowAnyOrigin()
                                  .AllowAnyMethod()
                                  .AllowAnyHeader()
                                  .WithOrigins("http://localhost:4200", "https://localhost:4200"));
        });

        services.AddScoped<ITokenService, TokenService>();
        services.AddScoped<IUserRepository, UserRepository>();
        services.AddScoped<IPhotoService, PhotoService>();
        services.AddScoped<LogUserActivity>();
        services.AddScoped<ILikesRepository, LikesRepository>();

        // services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
        var assemblies = AppDomain.CurrentDomain.GetAssemblies();
        services.AddAutoMapper(cfg =>
        {
            // Optional: you can configure mapping profiles here if needed
        }, assemblies);

        services.Configure<CloudinarySettings>(config.GetSection("CloudinarySettings"));

        return services;
    }

}
