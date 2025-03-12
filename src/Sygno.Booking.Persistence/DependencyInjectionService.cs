using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Sygno.Booking.Application.DataBase;
using Sygno.Booking.Persistence.DataBase;

namespace Sygno.Booking.Persistence
{
	public static class DependencyInjectionService
	{
		public static IServiceCollection AddPersistence(this IServiceCollection services,
			IConfiguration configuration)
		{
			services.AddDbContext<DataBaseService>(options =>
			options.UseSqlServer(configuration["SQLConnectionString"]));

			services.AddScoped<IDataBaseService, DataBaseService>();

			return services;
		}
	}
}
