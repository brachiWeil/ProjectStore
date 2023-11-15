
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Store.Model
{
    [Table("Orders")]
    public class Orders
    {
        [Key]
        [Required]
        public int Id { get; set; }

        public int? CustomersCode { get; set; }
        [ForeignKey(nameof(CustomersCode))]
        public Orders IdOfCustomers { get; set; }
        [Column(TypeName = "date"), DisplayFormat(DataFormatString = "{0:dd/mm/yyyy }")]
        public DateTime DateOrder { get; set; }

        public int SumPayment { get; set; }
        public string PaymentMethods { get; set; }
     
    }
}
