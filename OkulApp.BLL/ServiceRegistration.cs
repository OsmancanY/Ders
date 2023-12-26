using DAL.Repositories.OgrenciWriteRepository;
using DAL.Repositories.OgretmenRepository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using OkulApp.BLL.Contexts;
using OkulApp.BLL.Repositories.OgrenciRepository;
using OkulApp.BLL.Repositories.OgretmenRepositories;

namespace OkulApp.BLL
{
    public static class ServiceRegistration
    {
        public static void AddServiceRegistration(this IServiceCollection services)
        {
            services.AddDbContext<AppDBContext>(options => options.UseNpgsql("User ID=postgres;Password=postgres;Host=localhost;Port=5432;Database=okul;Pooling=true;Min Pool Size=0;Max Pool Size=100;Connection Lifetime=0;"));
            services.AddScoped<IOgretmenWriteRepository, OgretmenWriteRepository>();
            services.AddScoped<IOgrenciWriteRepository, OgrenciWriteRepository>();
        }
    }
}
