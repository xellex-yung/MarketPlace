﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MarketPlace.DO.Data.Models
{
    public class Employee
    {
        [Key, Required]
        public Guid Id { get; set; }

        public Guid? UserId { get; set; }

        public Guid? DepartmentId { get; set; }


        public virtual User? User { get; set; }

        public virtual Department? Department { get; set; }






    }
}
