using MarketPlace.DO.Data.Contexts.MarketPlaceDb.Configurations;
using MarketPlace.DO.Data.Models;
using MarketPlace.DO.Data.Models.Personality;
using Microsoft.EntityFrameworkCore;

namespace MarketPlace.DO.Data.Contexts.MarketPlaceDb
{
	public partial class MarketPlaceDbContext : DbContext
	{
		public static MarketPlaceDbContext Instance { get; private set; }

		public MarketPlaceDbContext(DbContextOptions<MarketPlaceDbContext> options) : base(options)
		{
			Instance = this;
		}
		public virtual DbSet<Adress> Adress { get; set; }
		public virtual DbSet<Department> Department { get; set; }
		public virtual DbSet<Description> Description { get; set; }
		public virtual DbSet<DescriptionString> DescriptionString { get; set; }
		public virtual DbSet<Employee> Employee { get; set; }
		public virtual DbSet<GroupProduct> GroupProduct { get; set; }
		public virtual DbSet<Order> Order { get; set; }
		public virtual DbSet<OrderString> OrderString { get; set; }
		public virtual DbSet<Person> Person { get; set; }
		public virtual DbSet<Picture> Picture { get; set; }
		public virtual DbSet<Product> Product { get; set; }
		public virtual DbSet<Role> Role { get; set; }
		public virtual DbSet<ServiceManager> ServiceManager { get; set; }
		public virtual DbSet<Status> Status { get; set; }
		public virtual DbSet<Tenant> Tenant { get; set; }
		public virtual DbSet<User> User { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			new AdressConfiguration(modelBuilder);
			new DepartmentConfiguration(modelBuilder);
			new DescriptionConfiguration(modelBuilder);
			new DescriptionStringConfiguration(modelBuilder);
			new EmployeeConfiguration(modelBuilder);
			new GroupProductConfiguration(modelBuilder);
			new OrderConfiguration(modelBuilder);
			new OrderStringConfiguration(modelBuilder);
			new PersonConfiguration(modelBuilder);
			new PictureConfiguration(modelBuilder);
			new ProductConfiguration(modelBuilder);
			new RoleConfiguration(modelBuilder);
			new ServiceManagerConfiguration(modelBuilder);
			new StatusConfiguration(modelBuilder);
			new TenantConfiguration(modelBuilder);
			new UserConfiguration(modelBuilder);

			OnModelCreatingPartial(modelBuilder);
		}
	}
	public partial class MarketPlaceDbContext
	{
		partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
	}
}
