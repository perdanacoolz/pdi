using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace JwtRoleAuthentication.Models
{
    [Table("Transaksi")]
    public class Transaksi
    {
            [Key]
            [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            public int transactionId { get; set; }
            
            public int Hargaitem { get; set; }
            public int Totalharga { get; set; }
            public int JmlItem { get; set; }
 
            public DateTime transactionDate { get; set; }

         
    }
}
