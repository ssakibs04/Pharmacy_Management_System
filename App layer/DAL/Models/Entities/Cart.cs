using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models.Entities
{
    public class Cart
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Medicine")]
        public int MedicineId { get; set; }
        public virtual Medicine Medicine { get; set; }

        [Required]
        public string InvoiceId { get; set; }
    }
}
