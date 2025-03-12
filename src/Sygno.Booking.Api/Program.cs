using Sygno.Booking.Api;
using Sygno.Booking.Application;
using Sygno.Booking.Application.DataBase.Customer.Commands.DeleteCustomer;
using Sygno.Booking.Application.DataBase.Customer.Queries.GetAllCustomers;
using Sygno.Booking.Application.DataBase.Customer.Queries.GetCustomerByDocumentNumber;
using Sygno.Booking.Application.DataBase.Customer.Queries.GetCustomerbyId;
using Sygno.Booking.Common;
using Sygno.Booking.External;
using Sygno.Booking.Persistence;

var builder = WebApplication.CreateBuilder(args);

builder.Services
	.AddWebApi()
	.AddCommon()
	.AddApplication()
	.AddExternal(builder.Configuration)
	.AddPersistence(builder.Configuration);

var app = builder.Build();

app.MapPost("/testService", async (IGetCustomerByDocumentNumberQuery service) =>
{

	return await service.Execute("11111111");
});

app.Run();
