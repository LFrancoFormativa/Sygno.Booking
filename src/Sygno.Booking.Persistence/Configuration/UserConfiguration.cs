using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sygno.Booking.Domain.Entities.User;

namespace Sygno.Booking.Persistence.Configuration
{
    public class UserConfiguration
    {
        public UserConfiguration(EntityTypeBuilder<UserEntity> entitybuilder)
        {
            entitybuilder.HasKey(x => x.UserId);
			entitybuilder.Property(x => x.FirstName).IsRequired();
			entitybuilder.Property(x => x.LastName).IsRequired();
			entitybuilder.Property(x => x.UserName).IsRequired();
			entitybuilder.Property(x => x.Password).IsRequired();

            entitybuilder.HasMany(x => x.Bookings)
                .WithOne(x => x.User)
                .HasForeignKey(x => x.UserId);
		}
    }
}
