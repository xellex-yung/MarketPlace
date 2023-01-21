using MarketPlace.DO.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketPlace.DO.Data.Contexts.MarketPlaceDb.Configurations
{
    public class EmployeeConfiguration
	{
		public EmployeeConfiguration(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Employee>(entity =>
			{
				entity.HasKey(employee => employee.Id);
				entity
				.HasOne(employee => employee.User)
				.WithOne()
				.HasForeignKey("UserId");
				entity
				.HasOne(employee => employee.Department)
				.WithOne()
				.HasForeignKey("DepartmentId");
			});
		}
	}
}
