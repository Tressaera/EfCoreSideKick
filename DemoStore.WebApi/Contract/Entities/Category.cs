using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoStore.WebApi
{
    public partial class Category
    {
        [Required]
        [Key]
        public int CategoryId { get; set; }

        [StringLength(50)]
        public string? CategoryName { get; set; }

        public bool? CategoryStatus { get; set; }

        public virtual ICollection<Product> Categories { get; set; } = new HashSet<Product>();
    }
}
