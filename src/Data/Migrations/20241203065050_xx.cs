using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace JwtRoleAuthentication.Data.Migrations
{
    /// <inheritdoc />
    public partial class xx : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Barang",
                columns: table => new
                {
                    BarangId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NamaBarang = table.Column<string>(type: "text", nullable: false),
                    Harga = table.Column<string>(type: "text", nullable: false),
                    StokAwal = table.Column<string>(type: "text", nullable: false),
                    Kategori = table.Column<string>(type: "text", nullable: false),
                    GambarBarang = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Barang", x => x.BarangId);
                });

            migrationBuilder.CreateTable(
                name: "Kateogri",
                columns: table => new
                {
                    KategoriID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NamaKategori = table.Column<string>(type: "text", nullable: false),
                    BarangId = table.Column<int>(type: "integer", nullable: false),
                    NamaBarang = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kateogri", x => x.KategoriID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Barang");

            migrationBuilder.DropTable(
                name: "Kateogri");
        }
    }
}
