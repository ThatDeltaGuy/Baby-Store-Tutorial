using System;
using System.ComponentModel.DataAnnotations;

namespace BabyStore.Models
{
    public partial class Product
    {
        public int ID { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }
        public decimal Price { get; set; }
        public int? CategoryID { get; set; }
        public virtual Category Category { get; set; }
    }
}