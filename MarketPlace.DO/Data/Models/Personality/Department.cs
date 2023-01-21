using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketPlace.DO.Data.Models
{
    public class Department
    {
        [Key, Required]
        public Guid Id { get; set; }

        public string Name { get; set; }

        public Guid? EmployeeId { get; set; }


        public virtual Employee Employee { get; set; }
    }
}
