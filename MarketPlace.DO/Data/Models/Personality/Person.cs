using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketPlace.DO.Data.Models
{
    public class Person
    {
        [Key, Required]
        public Guid Id { get; set; }

        public string? FullName
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                sb.Append(FirstName);

                if (MiddleName != null || MiddleName == string.Empty)
                {
                    sb.Append(' ');
                    sb.Append(MiddleName);

                }
                if (LastName != null || LastName == string.Empty)
                {
                    sb.Append(' ');
                    sb.Append(LastName);
                }
                return sb.ToString();
            }
            set { }
        }

        public string? ShortName
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                var firstSymbFirstName = FirstName.ToCharArray()[0];
                sb.Append(firstSymbFirstName);
                sb.Append('.');

                if (MiddleName != null || MiddleName == string.Empty)
                {
                    var firstSymbMiddleName = FirstName.ToCharArray()[0];
                    sb.Append(firstSymbMiddleName);
                    sb.Append('.');

                }
                if (LastName != null || LastName == string.Empty)
                {
                    sb.Append(' ');
                    sb.Append(LastName);
                }
                return sb.ToString();
            }
            set { }
        }

        public string FirstName { get; set; }

        public string? MiddleName { get; set; }

        public string? LastName { get; set; }

        public string? Adress { get; set; }

        public int? Phone { get; set; }

        public string? PhoneMask
        {
            get
            {

                return string.Format("{0:+# (###) ###-####}", Phone);
            }
            set { }
        }
    }
}
