﻿using System.ComponentModel.DataAnnotations;

namespace BTL.Models.EF
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        [Required]
        public string? CategoryName { get; set; }
        public string? Description { get; set; }
        public bool? Active { get; set; }

        public virtual ICollection<Product> Products { get; set; }

        public Category()
        {
            Products = new HashSet<Product>();
        }
    }
}