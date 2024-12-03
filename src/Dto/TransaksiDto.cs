namespace JwtRoleAuthentication.Dto
{
    public class TransaksiDto
    {

        public required int transactionId { get; set; }
        public required string BarangId { get; set; }
        public required string KategoriID { get; set; }

        public required string Jmlitem { get; set; }
        public required string Hargaitem { get; set; }
        public required string Totalharga { get; set; }

        public required DateTime transactionDate { get; set; }
    }
}
