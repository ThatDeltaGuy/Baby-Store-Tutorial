using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BabyStore.Models
{
    public class Category
    {
        public int ID { get; set; }
        [Required(ErrorMessage ="The Category name cannot be blank")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Please enter a category name between 3 and 50 charactors in length")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$", ErrorMessage ="Please enter a name beginning with a capital letter containing only letters and spaces")]
        [Display(Name = "Catagory Name")]
        public string Name { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}