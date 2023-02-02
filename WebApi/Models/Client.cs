using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Models
{
    [Table("Client")]
    public class Client 
    {
        [Key]
        [Column(TypeName = "int")]
        public int IdClient { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string Name { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string SurName { get; set; }


      
       
    }
}
