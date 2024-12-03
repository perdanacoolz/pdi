using System.ComponentModel.DataAnnotations;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace JwtRoleAuthentication.Models
{
    [Table("Kategori")]
    public class Kategori
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int KategoriID { get; set; }
        public string NamaKategori { get; set; }

        public int BarangId { get; set; }
        public string NamaBarang { get; set; }
 
    }
}
