using MarketPlace.DO.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketPlace.DO.Data.Contexts.MarketPlaceDb.Configurations
{
    public class DescriptionStringConfiguration
	{
		public DescriptionStringConfiguration(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<DescriptionString>(entity =>
			{
				entity.HasKey(descriptionString => descriptionString.Id);
				entity
				.HasOne(descriptionString => descriptionString.Description)
				.WithMany(description => description.DescriptionStrings)
				.HasForeignKey("DescriptionId");
			});
		}
	}
}
