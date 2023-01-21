using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketPlace.DO.Data.Models
{
	public class Product
	{
		[Key, Required]
		public Guid Id { get; set; }

		public Guid? GroupProductId { get; set; }

		public Guid? PictureId { get; set; }

		public Guid? DescriptionId { get; set; }

		public decimal? Cost { get; set; }

		public string? Name { get; set; }

		public decimal? Dimension { get; set; }

		public DateTime CreatedAt { get; set; }

		public DateTime? UpdatedAt { get; set; }


		public virtual Description? Description { get; set; }

		public virtual GroupProduct? GroupProduct { get; set; }

		public virtual Picture? Picture { get; set; }
	}
}
