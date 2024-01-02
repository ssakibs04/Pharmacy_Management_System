using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models.Entities
{
    public class Sale
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int InvoiceId { get; set; }
    }
}
