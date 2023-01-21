using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MarketPlace.DO.Data.Models
{
    public class ServiceManager
    {
        [Key, Required]
        public Guid Id { get; set; }    

        public DateTime CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }

		public Guid? StatusId { get; set; }

		public virtual Employee? Employee
        {
            get
            {
                if (Employees.Count != 0)
                {
                    return Employees.LastOrDefault();
                }
                else
                {
                    return null;
                }
            }
            set { }
        }
		public virtual Status? Status { get; set; }
		public virtual List<Employee>? Employees { get; set; }
    }
}
