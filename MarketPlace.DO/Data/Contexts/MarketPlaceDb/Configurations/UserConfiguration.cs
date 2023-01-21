using MarketPlace.DO.Data.Models;
using MarketPlace.DO.Data.Models.Personality;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketPlace.DO.Data.Contexts.MarketPlaceDb.Configurations
{
    public class UserConfiguration
	{
		public UserConfiguration(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<User>(entity =>
			{
				entity.HasKey(user => user.Id);
				entity
				.HasOne(user => user.Picture)
				.WithOne()
				.HasForeignKey("PictureId");
				entity
				.HasOne(user => user.Person)
				.WithOne()
				.HasForeignKey("PersonId");
				entity
				.HasOne(user => user.Role)
				.WithOne()
				.HasForeignKey("RoleId");
				entity
				.HasOne(user => user.Tenant)
				.WithOne()
				.HasForeignKey("TenantId");

			});
		}
	}

}

