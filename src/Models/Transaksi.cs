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
            public int BarangId { get; set; }
            [JsonIgnore]
            public Barang barang { get; set; }
            public int KategoriID { get; set; }
            [JsonIgnore]
            public Kategori kategori { get; set; }           
            public int Hargaitem { get; set; }
            public int Totalharga { get; set; }
            public int JmlItem { get; set; }

        //field tambahan
        public DateTime transactionDate { get; set; }

         
    }
}
