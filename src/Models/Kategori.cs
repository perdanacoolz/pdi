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

       

    }
}
