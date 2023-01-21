using MarketPlace.DO.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketPlace.DO.Data.Contexts.MarketPlaceDb.Configurations
{
    public class StatusConfiguration
	{
		public StatusConfiguration(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Status>(entity =>
			{
				entity.HasKey(status => status.Id);			
			});
		}
	}
}
