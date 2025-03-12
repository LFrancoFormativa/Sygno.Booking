using Microsoft.EntityFrameworkCore;
using Sygno.Booking.Domain.Entities.Booking;
using Sygno.Booking.Domain.Entities.Customer;
using Sygno.Booking.Domain.Entities.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sygno.Booking.Application.DataBase
{
    public interface IDataBaseService
    {
        DbSet<UserEntity> User { get; set; }
		DbSet<CustomerEntity> Customer { get; set; }
		DbSet<BookingEntity> Booking { get; set; }

		Task<bool> SaveAsync();
	}
}
