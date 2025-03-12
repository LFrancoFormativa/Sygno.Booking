using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sygno.Booking.Domain.Entities.Booking;
using Sygno.Booking.Domain.Entities.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sygno.Booking.Persistence.Configuration
{
    public class BookingConfiguration
    {
		public BookingConfiguration(EntityTypeBuilder<BookingEntity> entitybuilder)
		{
			entitybuilder.HasKey(x => x.BookingId);
			entitybuilder.Property(x => x.RegisterDate).IsRequired();
			entitybuilder.Property(x => x.Code).IsRequired();
			entitybuilder.Property(x => x.Type).IsRequired();
			entitybuilder.Property(x => x.UserId).IsRequired();
			entitybuilder.Property(x => x.CustomerId).IsRequired();

			entitybuilder.HasOne(x => x.User)
				.WithMany(x => x.Bookings)
				.HasForeignKey(x => x.UserId);

			entitybuilder.HasOne(x => x.Customers)
				.WithMany(x => x.Bookings)
				.HasForeignKey(x => x.CustomerId);
		}
	}
}
