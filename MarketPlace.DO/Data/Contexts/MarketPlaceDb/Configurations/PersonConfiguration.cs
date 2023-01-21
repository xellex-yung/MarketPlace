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
    public class PersonConfiguration
	{
		public PersonConfiguration(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Person>(entity =>
			{
				entity.HasKey(person => person.Id);			
			});
		}
	}
}
