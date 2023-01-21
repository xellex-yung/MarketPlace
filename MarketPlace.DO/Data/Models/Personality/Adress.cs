using Microsoft.Extensions.Primitives;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace MarketPlace.DO.Data.Models.Personality
{
	public class Adress
	{
		[Key, Required]
		public Guid Id { get; set; }

		public Guid? UserId { get; set; }

		public string Name { get; set; }

		public string? FullAdress
		{
			get
			{
				StringBuilder sb = new StringBuilder();
				sb.Append(City);
				sb.Append(',');
				sb.Append(' ');
				sb.Append(Street);
				sb.Append(',');
				sb.Append(' ');
				sb.Append(Home);
				if (Building != null || Building == string.Empty)
				{
					sb.Append('/');
					sb.Append(Building);
					
				}
				if (Apartment != null || Apartment == string.Empty)
				{
					sb.Append(',');
					sb.Append(' ');
					sb.Append(Apartment);			
			
				}
				if (Floor != null || Floor == string.Empty)
				{
					sb.Append(',');
					sb.Append(' ');
					sb.Append(Floor);
				}
				return sb.ToString();
			}
			set { }
		}

		public string? DeliveryComment { get; set; }	

		public string? City { get; set; }

		public string? Street { get; set; }

		public string? Home { get; set; }

		public string? Building { get; set; }

		public string? Apartment { get; set; }

		public string? Floor { get; set; }
	



		

		
	}
}
