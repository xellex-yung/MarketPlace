using MarketPlace.DO.Data.Models.Personality;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MarketPlace.DO.Data.Models
{
    public class Order
    {
        [Key, Required]
        public Guid Id { get; set; }

        public string? NumberName { get; set; }

        public decimal? Sum { get; set; }

        public virtual Guid UserId { get; set; }

		public Guid AdressId { get; set; }

		public virtual Guid? ServiceId { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }



		public virtual Adress Adress { get; set; }

		public virtual User? User { get; set; }

        public virtual ServiceManager? ServiceManager { get; set; }

        public virtual List<OrderString>? OrderStrings { get; set; }

    }
}
