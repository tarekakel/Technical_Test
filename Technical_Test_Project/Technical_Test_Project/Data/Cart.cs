using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Technical_Test_Project.Data
{
    public class Cart
    {
        [Key]
        public int Id { get; set; }
        public virtual int UserId { get; set; }
        [ForeignKey("UserId")]
        public virtual User User { get; set; }
        public double Price { get; set; }
        public bool IsPaid { get; set; }
        public virtual ICollection<CartItem> CartItems { get; set; }
    }
}
