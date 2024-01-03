using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models.Entities
{
	public class Supplier
	{
		[Key]
		public int Id { get; set; }
		[Required]
		public string CompanyName { get; set; }
		[Required]
		public String Address { get; set; }
		[Required]
		public string Email { get; set; }
	}
}
