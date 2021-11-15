using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Technical_Test_Project.Data
{
    public class CartItem
    {
        [Key]
        public int Id { get; set; }
        public virtual int CartId { get; set; }
        [ForeignKey("CartId")]
        public virtual Cart Cart { get; set; }
        public virtual int ProductId { get; set; }
        [ForeignKey("ProductId")]
        public virtual Product  Product { get; set; }
        public double TotalPrice { get; set; }
        public bool Quantity { get; set; }
    }
}
