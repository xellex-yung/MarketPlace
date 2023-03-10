using MarketPlace.DO.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketPlace.DO.Data.Contexts.MarketPlaceDb.Configurations
{
    public class PictureConfiguration
	{
		public PictureConfiguration(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Picture>(entity =>
			{
				entity.HasKey(picture => picture.Id);
			});
		}
	}
}
