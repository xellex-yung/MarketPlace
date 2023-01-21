using MarketPlace.DO.Data.Models.Personality;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketPlace.DO.Data.Models
{
    public class OrderString
    {
        [Key, Required]
        public Guid Id { get; set; }

        public int Count { get; set; }

        public decimal Cost { get; set; }

		public Guid ProductId { get; set; }

		public Guid OrderId { get; set; }

		public DateTime CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }

		
		public virtual Product Product { get; set; }

        public virtual Order Order { get; set; }

    }
}
