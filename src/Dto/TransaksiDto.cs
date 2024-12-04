namespace JwtRoleAuthentication.Dto
{
    public class TransaksiDto
    {

        public required int transactionId { get; set; }
        public required int BarangId { get; set; }
        public required int KategoriID { get; set; }

        public required int Jmlitem { get; set; }
        public required int Hargaitem { get; set; }
        public required int Totalharga { get; set; }

        public required DateTime transactionDate { get; set; }
    }
}
