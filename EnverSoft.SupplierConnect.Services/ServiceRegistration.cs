using Microsoft.Extensions.DependencyInjection;
using EnverSoft.SupplierConnect.Data.Repositories.Abstracts;
using EnverSoft.SupplierConnect.Data.Repositories.Concretes;
using EnverSoft.SupplierConnect.Services.Abstracts;
using EnverSoft.SupplierConnect.Services.Concretes;
using EnverSoft.SupplierConnect.Data.Contexts;
using EnverSoft.SupplierConnect.MappingProfiles.MappingProfiles;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace EnverSoft.SupplierConnect.Services
{
    public static class ServiceRegistration
    {
        public static IServiceCollection RegisterServices(this IServiceCollection services, IConfiguration configuration)
        {
            // Read connection string from appsettings.json
            string? connectionString = configuration.GetConnectionString("SupplierConnectDB");

            // Register DbContext
            services.AddDbContext<ApplicationDBContext>(options =>
                options.UseSqlServer(connectionString));

            // Register repositories
            services.AddScoped<ISupplierRepository, SupplierRepository>();

            // Register services
            services.AddScoped<ISupplierService, SupplierService>();

            // Add AutoMapper and the mapping profiles using the factory
            services.AddAutoMapper(MappingProfileFactory.ConfigureProfiles);

            return services;
        }
    }
}

