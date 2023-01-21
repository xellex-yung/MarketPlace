using MarketPlace.DO.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketPlace.DO.Data.Contexts.MarketPlaceDb.Configurations
{
    public class ServiceManagerConfiguration
	{
		public ServiceManagerConfiguration(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<ServiceManager>(entity =>
			{
				entity.HasKey(serviceManager => serviceManager.Id);
				entity
				.HasOne(serviceManager => serviceManager.Status)
				.WithOne()
				.HasForeignKey("StatusId");
				entity
				.HasMany(serviceManager => serviceManager.Employees)
				.WithOne()
				.HasForeignKey(employee => employee.UserId);

			});
		}
	}
}
