using GenericRepoPractice.Domain.Repositories;
using GenericRepositoryPractice.DataAccessLayer.Context;
using GenericRepositoryPractice.DataAccessLayer.Implementation;
using Microsoft.EntityFrameworkCore;

namespace GenericRepoPractice
{
    public static class RegisterServices
    {
        public static void Register(this IServiceCollection services, IConfiguration config)
        {
            services.AddControllers();
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();
            services.AddDbContext<AppDbContext>(opt =>
            {
                opt.UseSqlServer(config.GetConnectionString("DefaultConnection"));
            });
            services.AddScoped<IUnitOfWork, UnitOfWork>();
        }
    }
}
