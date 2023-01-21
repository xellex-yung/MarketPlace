using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketPlace.DO.Data.Models
{
    public class User
    {
        [Key, Required]
        public Guid Id { get; set; }

        public string Password { get; set; }

        public bool AgreeTerm { get; set; }

        public bool RememberMe { get; set; }

		public Guid? PictureId { get; set; }
		
		public Guid? PersonId { get; set; }

        public Guid Tenantld { get; set; }

        public Guid Roleld { get; set; }

        [NotMapped]
        public string Token { get; set; }

        [NotMapped]
        public string AppOriginUrl { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }


		public virtual Picture? Picture { get; set; }

		public virtual Person? Person { get; set; }

        public virtual Role? Role { get; set; }

        public virtual Tenant? Tenant { get; set; }
    }
}
