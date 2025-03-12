using Sygno.Booking.Api;
using Sygno.Booking.Application;
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

builder.Services.AddControllers();

var app = builder.Build();

app.MapControllers();
app.Run();
