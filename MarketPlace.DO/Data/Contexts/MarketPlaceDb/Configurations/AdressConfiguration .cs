using MarketPlace.DO.Data.Models.Personality;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketPlace.DO.Data.Contexts.MarketPlaceDb.Configurations
{
    public class AdressConfiguration
	{
		public AdressConfiguration(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Adress>(entity =>
			{
				entity.HasKey(adress => adress.Id);			
			});
		}
	}
}
