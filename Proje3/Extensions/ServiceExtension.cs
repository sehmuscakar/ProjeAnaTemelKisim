using Repository.Interfaces;
using Repository.Repositories;
using Services.Interfaces;
using Services.Services;

namespace Proje3.Extensions
{
	public  static class ServiceExtension
	{
		public static void MyconfigureServices(this IServiceCollection services)
		{
            services.AddScoped<ITanıtımService, TanıtımService>();
            services.AddScoped<ITanıtımRepository, TanıtımRepository>();

            services.AddScoped<INotlarService, NotlarService>();
            services.AddScoped<INotlarRepository, NotlarRepository>();
        }
	}
}
