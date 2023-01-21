using MarketPlace.DO.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketPlace.DO.Data.Contexts.MarketPlaceDb.Configurations
{
    public class DepartmentConfiguration
	{
		public DepartmentConfiguration(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Department>(entity =>
			{
				entity.HasKey(department => department.Id);
				entity
				.HasOne(department => department.Employee)
				.WithOne()
				.HasForeignKey("EmployeeId");		
			});
		}
	}
}
