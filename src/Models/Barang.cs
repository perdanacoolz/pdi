using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JwtRoleAuthentication.Models
{
    [Table("Barang")]
    public class Barang
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BarangId { get; set; }
        public string NamaBarang { get; set; }
        public string Harga { get; set; }
        public string StokAwal { get; set; }
        public string Kategori { get; set; }

        public string GambarBarang { get; set; }
    }
}
