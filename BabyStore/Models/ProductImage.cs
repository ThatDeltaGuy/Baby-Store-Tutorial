using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace BabyStore.Models
{
    public class ProductImage
    {
        public int ID { get; set; }
        [Display(Name="File")]
        public string FileName { get; set; }
    }
}