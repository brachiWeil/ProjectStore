using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Store.Model
{
    [Table("Products")]
    public class Products
    {
        [Key]
        [Required]

        public int Code { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        [MaxLength(2)]
        public int MinSize { get; set; }
        [MaxLength(2)]
        public int MaxSize { get; set; }
        //כמות במלאי
        public int QtyInventory { get; set; }




    }
}
