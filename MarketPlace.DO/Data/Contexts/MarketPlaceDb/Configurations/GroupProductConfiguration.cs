using MarketPlace.DO.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketPlace.DO.Data.Contexts.MarketPlaceDb.Configurations
{
    public class GroupProductConfiguration
	{
		public GroupProductConfiguration(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<GroupProduct>(entity =>
			{
				entity.HasKey(groupProduct => groupProduct.Id);
				entity
				.HasOne(groupProduct => groupProduct.Description)
				.WithOne()
				.HasForeignKey("DescriptionId");
				entity.HasOne(groupProduct => groupProduct.Picture)
				.WithOne()
				.HasForeignKey("PictureId");
			});
		}
	}
}
