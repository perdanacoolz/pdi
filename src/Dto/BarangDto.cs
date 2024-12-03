namespace JwtRoleAuthentication.Dto
{
    public class BarangDto
    {
        public required int BarangId { get; set; }
        public required string? NamaBarang { get; set; }
        public required string? Harga { get; set; }
        public required string? StokAwal { get; set; }

        public required string? Kategori { get; set; }
        public required string? GambarBarang { get; set; }
 
    }
}
