using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MarketPlace.DO.Data.Models
{
	public class DescriptionString
	{
		[Key, Required]
		public Guid Id { get; set; }

		public string? Value { get; set; }

		public decimal Cost { get; set; }

		public Guid? DescriptionId { get; set; }

		public Guid? UserId { get; set; }

		public DateTime CreatedAt { get; set; }

		public DateTime? UpdatedAt { get; set; }
		

		public virtual Description? Description{ get; set; }

		public virtual User User { get; set; }


	}
}
