using Emlak.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


namespace EstateAgent.Data.Extensions
{
    public static class DataLayerExtensions
    {
        public static IServiceCollection LoadDataLayerExtensions(this IServiceCollection services, IConfiguration config)
        {
          
            services.AddDbContext<AppDbContext>(Opt => Opt.UseSqlServer(config.GetConnectionString("DefaultConnection"))); // veritabanına bağlanmak için

            
            return services;
        }
    }
}
