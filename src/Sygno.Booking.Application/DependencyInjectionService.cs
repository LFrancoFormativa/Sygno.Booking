using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using Sygno.Booking.Application.Configuration;
using Sygno.Booking.Application.DataBase.Booking.Commands.CreateBooking;
using Sygno.Booking.Application.DataBase.Booking.Queries.GetAllBookings;
using Sygno.Booking.Application.DataBase.Booking.Queries.GetBookingsByDocumentNumber;
using Sygno.Booking.Application.DataBase.Booking.Queries.GetBookingsByType;
using Sygno.Booking.Application.DataBase.Customer.Commands.CreateCustomer;
using Sygno.Booking.Application.DataBase.Customer.Commands.DeleteCustomer;
using Sygno.Booking.Application.DataBase.Customer.Commands.UpdateCustomer;
using Sygno.Booking.Application.DataBase.Customer.Queries.GetAllCustomers;
using Sygno.Booking.Application.DataBase.Customer.Queries.GetCustomerByDocumentNumber;
using Sygno.Booking.Application.DataBase.Customer.Queries.GetCustomerbyId;
using Sygno.Booking.Application.DataBase.User.Commands.CreateUser;
using Sygno.Booking.Application.DataBase.User.Commands.DeleteUser;
using Sygno.Booking.Application.DataBase.User.Commands.UpdateUser;
using Sygno.Booking.Application.DataBase.User.Commands.UpdateUserPassword;
using Sygno.Booking.Application.DataBase.User.Queries.GetAllUser;
using Sygno.Booking.Application.DataBase.User.Queries.GetUserById;
using Sygno.Booking.Application.DataBase.User.Queries.GetUserByUserNameAndPassword;

namespace Sygno.Booking.Application
{
	public static class DependencyInjectionService
	{
		public static IServiceCollection AddApplication(this IServiceCollection services)
		{
			var mapper = new MapperConfiguration(config =>
			{
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
			services.AddTransient<IDeleteCustomerCommand, DeleteCustomerCommand>();
			services.AddTransient<IGetAllCustomerQuery, GetAllCustomerQuery>();
			services.AddTransient<IGetCustomerbyIdQuery, GetCustomerbyIdQuery>();
			services.AddTransient<IGetCustomerByDocumentNumberQuery, GetCustomerByDocumentNumberQuery>();
			#endregion

			#region 
			services.AddTransient<ICreateBookingCommand, CreateBookingCommand>();
			services.AddTransient<IGetAllBookingsQuery, GetAllBookingsQuery>();
			services.AddTransient<IGetBookingsByDocumentNumberQuery, GetBookingsByDocumentNumberQuery>();
			services.AddTransient<IGetBookingsByTypeQuery, GetBookingsByTypeQuery>();
			#endregion

			return services;
		}
	}
}
