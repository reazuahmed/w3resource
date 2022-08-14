using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.Models
{
    public class ProductTypes
    {
        public int Id { get; set; }     //If we name any property as 'Id' or if we name any property as "class-name+Id" in a class and if the data type is 'integer', system automatically takes it as primary key.
        [Required]
        [Display(Name = "Product Type")]
        public string ProductType { get; set; }

    }
}
