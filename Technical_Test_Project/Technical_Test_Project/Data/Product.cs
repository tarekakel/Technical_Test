using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Technical_Test_Project.Data
{
    public class Product
    {
        [Key]

        public int ID { get; set; }

        public string Name { get; set; }
        [Display(Name ="Unit Price")]
        [Required]
        public double UnitPrice { get; set; }

        [Display(Name = "Image")]
        public string PictureUrl { get; set; }
        [Display(Name = "Current Quantity")]
        public int CurrentQuantity { get; set; }
        public string Description { get; set; }
    }
}
