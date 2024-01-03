using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
	public class DiscountDTO
	{
		[Key]
		public int DiscountID { get; set; }
		public int MedicineID { get; set; }
		public int CustomerID { get; set; }
		public decimal DiscountPercentage { get; set; }
		public DateTime StartDate { get; set; }
		public DateTime EndDate { get; set; }



	}
}
