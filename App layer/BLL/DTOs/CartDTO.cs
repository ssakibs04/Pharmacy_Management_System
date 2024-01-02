using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class CartDTO
    {
        public int Id { get; set; }
        [Required]
        public int MedicineId { get; set; }
        [Required]
        public string InvoiceId { get; set; }
    }
}
