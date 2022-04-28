
using Application.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Persistence.Contexts;
using Persistence.Repository;

namespace Persistence
{
    public static class ServiceExtensions
    {
        public static void AddPersistenceInfraestructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ArandasoftContext>(options => options.UseSqlServer(
                configuration.GetConnectionString("ArandaSoft"),
                b => b.MigrationsAssembly(typeof(ArandasoftContext).Assembly.FullName)
            ));

            #region Repositories

            services.AddTransient(typeof(IRepositoryAsync<>), typeof(MyRepositoryAsync<>));

            #endregion
        }
    }
}