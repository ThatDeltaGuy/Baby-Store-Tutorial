using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BabyStore.Models
{
    public class Category
    {
        public int ID { get; set; }
        [Display(Name = "Catagory Name")]
        public string Name { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}