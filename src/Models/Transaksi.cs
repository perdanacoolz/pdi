using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace JwtRoleAuthentication.Models
{
    [Table("Transaksi")]
    public class Transaksi
    {
            [Key]
            [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            public int transactionId { get; set; }
            public string BarangId { get; set; }
            public string KategoriID { get; set; }

            public string Jmlitem { get; set; }
            public string Hargaitem { get; set; }
            public string Totalharga { get; set; }

            public DateTime transactionDate { get; set; }

         
    }
}
