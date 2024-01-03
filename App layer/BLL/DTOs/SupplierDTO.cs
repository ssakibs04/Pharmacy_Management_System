using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
	public class SupplierDTO
	{
		[Key]
		public int Id { get; set; }
		[Required]
		public string CompanyName { get; set; }
		[Required]
		public string Address { get; set; }
		[Required]
			
		public string Email { get; set;
		}
	}
}
