﻿using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Sygno.Booking.External
{
	public static class DependencyInjectionService
	{
		public static IServiceCollection AddExternal(this IServiceCollection services,
			IConfiguration configuration)
		{
			return services;
		}
	}
}
