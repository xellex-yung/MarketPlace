using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketPlace.DO.Data.Models
{
	public class GroupProduct
	{
		[Key, Required]
		public Guid Id { get; set; }

		public string? Name { get; set; }

		public Guid? PictureId { get; set; }

		public Guid? DescriptionId { get; set; }


		public virtual Description? Description { get; set; }

		public virtual Picture? Picture { get; set; }
	}
}
