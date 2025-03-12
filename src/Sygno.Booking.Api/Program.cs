using Microsoft.EntityFrameworkCore;
using Sygno.Booking.Api;
using Sygno.Booking.Application;
using Sygno.Booking.Application.DataBase;
using Sygno.Booking.Application.DataBase.User.Commands.CreateUser;
using Sygno.Booking.Application.DataBase.User.Commands.DeleteUser;
using Sygno.Booking.Application.DataBase.User.Commands.UpdateUser;
using Sygno.Booking.Application.DataBase.User.Commands.UpdateUserPassword;
using Sygno.Booking.Application.DataBase.User.Queries.GetAllUser;
using Sygno.Booking.Application.DataBase.User.Queries.GetUserById;
using Sygno.Booking.Application.DataBase.User.Queries.GetUserByUserNameAndPassword;
using Sygno.Booking.Common;
using Sygno.Booking.External;
using Sygno.Booking.Persistence;
using Sygno.Booking.Persistence.DataBase;

var builder = WebApplication.CreateBuilder(args);

builder.Services
	.AddWebApi()
	.AddCommon()
	.AddApplication()
	.AddExternal(builder.Configuration)
	.AddPersistence(builder.Configuration);

var app = builder.Build();

app.MapPost("/testService", async (IGetUserByUserNameAndPasswordQuery service) =>
{
	 return await service.Execute("user02", "luis0018*_2025");
});

app.Run();
