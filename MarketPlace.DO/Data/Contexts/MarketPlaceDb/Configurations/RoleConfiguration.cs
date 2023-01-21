using MarketPlace.DO.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketPlace.DO.Data.Contexts.MarketPlaceDb.Configurations
{
    public class RoleConfiguration
	{
		public RoleConfiguration(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Role>(entity =>
			{
				entity.HasKey(role => role.Id);			
			});
		}
	}
}
