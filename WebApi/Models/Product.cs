using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Models
{
    [Table("Product")]
    public class Product
    {
        [Key]
        [Column (TypeName = "int")]
        public int Id { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string Name { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }
        
        [Column(TypeName = "int")]
        public int Stock { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string Brand { get; set; }

        
    }
}
