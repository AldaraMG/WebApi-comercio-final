using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Models
{
    [Table("Order")]
    public class Order
    {
        [Key]
        [Column(TypeName = "int")]
        public int Id { get; set; }

        [Column(TypeName = "int")]
        public int IdClient { get; set; }


        [Column(TypeName = "int")]
        public int IdProduct { get; set; }

        [Column(TypeName = "int")]
        public int Amount { get; set; }
        public DateTime OrderDate { get; set; }

        public virtual ICollection<Product>? Products { get; set; }

        public virtual ICollection<Client>? Clients { get; set; }
    }

      
}
