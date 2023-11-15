using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Store.Model
{
    [Table("ProductsOrders")]
    public class ProductsOrders
    {
        [Key]
        [Required]
        public int Code { get; set; }
        [MaxLength(25)]
        public string Name { get; set; }
        public int Price { get; set; }
        public int Qty { get; set; }
    }
}
