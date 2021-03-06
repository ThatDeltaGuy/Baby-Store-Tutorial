﻿using System;
using System.ComponentModel.DataAnnotations;

namespace BabyStore.Models
{
    public partial class Product
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "The product name cannot be blank")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Please enter a product name between 3 and 50 charactors in length")]
        [RegularExpression(@"^[a-zA-Z0-9'-'\s]*$", ErrorMessage = "Please enter a product name containing only letters and numbers")]
        public String Name { get; set; }
        [Required(ErrorMessage = "The product description cannot be blank")]
        [StringLength(200, MinimumLength = 10, ErrorMessage = "Please enter a product description between 10 and 200 charactors in length")]
        [RegularExpression(@"^[,;a-zA-Z0-9'-'\s]*$", ErrorMessage = "Please enter a product name containing only letters and numbers")]
        [DataType(DataType.MultilineText)]
        public String Description { get; set; }
        [Required(ErrorMessage = "The product price cannot be blank")]
        [Range(0.10, 10000, ErrorMessage = "Please enter a product price between 0.10 and 10000")]
        [DataType(DataType.Currency)]
        [DisplayFormat(DataFormatString = "{0:c}")]
        [RegularExpression("[0-9]+(\\.[0-9][0-9]?)?",ErrorMessage ="Price must havce upto 2 decimal places")]
        public decimal Price { get; set; }
        public int? CategoryID { get; set; }
        public virtual Category Category { get; set; }
    }
}