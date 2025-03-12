using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using Sygno.Booking.Application.Configuration;
using Sygno.Booking.Application.DataBase.Customer.Commands.CreateCustomer;
using Sygno.Booking.Application.DataBase.Customer.Commands.UpdateCustomer;
using Sygno.Booking.Application.DataBase.User.Commands.CreateUser;
using Sygno.Booking.Application.DataBase.User.Commands.DeleteUser;
using Sygno.Booking.Application.DataBase.User.Commands.UpdateUser;
using Sygno.Booking.Application.DataBase.User.Commands.UpdateUserPassword;
using Sygno.Booking.Application.DataBase.User.Queries.GetAllUser;
using Sygno.Booking.Application.DataBase.User.Queries.GetUserById;
using Sygno.Booking.Application.DataBase.User.Queries.GetUserByUserNameAndPassword;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sygno.Booking.Application
{
	public static class DependencyInjectionService
	{
		public static IServiceCollection AddApplication(this IServiceCollection services)
		{
			var mapper = new MapperConfiguration(config =>{
				config.AddProfile(new MapperProfile());
			});

			services.AddSingleton(mapper.CreateMapper());
			#region User
			services.AddTransient<ICreateUserCommand, CreateUserCommand>();
			services.AddTransient<IUpdateUserCommand, UpdateUserCommand>();
			services.AddTransient<IDeleteUserCommand, DeleteUserCommand>();
			services.AddTransient<IUpdateUserPasswordCommand, UpdateUserPasswordCommand>();
			services.AddTransient<IGetAllUserQuery, GetAllUserQuery>();
			services.AddTransient<IGetUserByIdQuery, GetUserByIdQuery>();
			services.AddTransient<IGetUserByUserNameAndPasswordQuery, GetUserByUserNameAndPasswordQuery>();
			#endregion

			#region Customer
			services.AddTransient<ICreateCustomerCommand, CreateCustomerCommand>();
			services.AddTransient<IUpdateCustomerCommand, UpdateCustomerCommand>();
			#endregion

			return services;
		}
	}
}
