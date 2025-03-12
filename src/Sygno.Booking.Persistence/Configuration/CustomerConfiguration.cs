using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sygno.Booking.Domain.Entities.Customer;
using Sygno.Booking.Domain.Entities.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sygno.Booking.Persistence.Configuration
{
    public class CustomerConfiguration
    {
		public CustomerConfiguration(EntityTypeBuilder<CustomerEntity> entitybuilder)
		{
			entitybuilder.HasKey(x => x.CustomerId);
			entitybuilder.Property(x => x.FullName).IsRequired();
			entitybuilder.Property(x => x.DocumentNumber).IsRequired();

			entitybuilder.HasMany(x => x.Bookings)
				.WithOne(x => x.Customers)
				.HasForeignKey(x => x.CustomerId);
		}
	}
}
