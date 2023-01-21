using MarketPlace.DO.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketPlace.DO.Data.Contexts.MarketPlaceDb.Configurations
{
    public class ProductConfiguration
	{
		public ProductConfiguration(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Product>(entity =>
			{
				entity.HasKey(product => product.Id);
				entity
				.HasOne(product => product.Description)
				.WithOne()
				.HasForeignKey("DescriptionId");
				entity
				.HasOne(product => product.GroupProduct)
				.WithOne().HasForeignKey("GroupProductId");
				entity
				.HasOne(product => product.Picture)
				.WithOne()
				.HasForeignKey("PictureId");				
			});
		}
	}
}
