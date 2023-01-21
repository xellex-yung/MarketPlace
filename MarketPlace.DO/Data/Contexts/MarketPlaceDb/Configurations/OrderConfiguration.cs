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
    public class OrderConfiguration
	{
		public OrderConfiguration(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Order>(entity =>
			{
				entity.HasKey(order => order.Id);
				entity
				.HasOne(order => order.Adress)
				.WithOne()
				.HasForeignKey("AdressId");		
				entity
				.HasOne(order => order.User)
				.WithOne()
				.HasForeignKey("UserId");
				entity
				.HasOne(order => order.ServiceManager)
				.WithOne()
				.HasForeignKey("ServiceManagerId");
				entity
				.HasMany(order => order.OrderStrings)
				.WithOne()
				.HasForeignKey(orderStrings => orderStrings.OrderId);				
			});
		}
	}
}
