using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CoreWebAPI.Models
{
    public class PaymentDetail
    {
        [Key]
        public int MPId { get; set; }
        [Required]
        [Column(TypeName ="nvarchar(100)")]
        public string CardWonerName { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(16)")]
        public string CardNumber { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(5)")]
        public string ExpirationDate { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(3)")]
        public string CVV { get; set; }
    }
}
