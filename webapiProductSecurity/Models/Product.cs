using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace webapiProductSecurity.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [Required]
        [Display(Name = "Nombre del producto")]
        public string Name { get; set; }
        [Range(0, 1000000, ErrorMessage = "El valor debe ser mayor a")]
        public double Value { get; set; }
    }
    
}