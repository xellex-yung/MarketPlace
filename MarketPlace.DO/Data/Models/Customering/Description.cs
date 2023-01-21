using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketPlace.DO.Data.Models
{
    public class Description
    {
        [Key, Required]
        public Guid Id { get; set; }

        public string? Value { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }


        public virtual List<DescriptionString>? DescriptionStrings { get; set; }


    }
}
