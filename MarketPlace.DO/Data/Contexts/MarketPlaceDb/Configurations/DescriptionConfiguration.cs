using MarketPlace.DO.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketPlace.DO.Data.Contexts.MarketPlaceDb.Configurations
{
    public class DescriptionConfiguration
	{
		public DescriptionConfiguration(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Description>(entity =>
			{
				entity.HasKey(description => description.Id);		
				entity
				.HasMany(description => description.DescriptionStrings)
				.WithOne()
				.HasForeignKey(descriptionStrings => descriptionStrings.DescriptionId);
			});
		}
	}
}
