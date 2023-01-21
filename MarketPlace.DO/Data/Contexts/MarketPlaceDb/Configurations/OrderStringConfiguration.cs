using MarketPlace.DO.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketPlace.DO.Data.Contexts.MarketPlaceDb.Configurations
{
    public class OrderStringConfiguration
	{
		public OrderStringConfiguration(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<OrderString>(entity =>
			{
				entity.HasKey(orderStrings => orderStrings.Id);
				entity
				.HasOne(orderStrings => orderStrings.Product)
				.WithOne()
				.HasForeignKey("ProductId");
				entity
				.HasOne(orderStrings => orderStrings.Order)
				.WithOne()
				.HasForeignKey("OrderId");
			});
		}
	}
}
