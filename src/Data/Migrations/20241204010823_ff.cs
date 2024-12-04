using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace JwtRoleAuthentication.Data.Migrations
{
    /// <inheritdoc />
    public partial class ff : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Kateogri",
                table: "Kateogri");

            migrationBuilder.RenameTable(
                name: "Kateogri",
                newName: "Kategori");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Kategori",
                table: "Kategori",
                column: "KategoriID");

            migrationBuilder.CreateTable(
                name: "Transaksi",
                columns: table => new
                {
                    transactionId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    BarangId = table.Column<int>(type: "integer", nullable: false),
                    KategoriID = table.Column<int>(type: "integer", nullable: false),
                    Hargaitem = table.Column<int>(type: "integer", nullable: false),
                    Totalharga = table.Column<int>(type: "integer", nullable: false),
                    JmlItem = table.Column<int>(type: "integer", nullable: false),
                    transactionDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transaksi", x => x.transactionId);
                    table.ForeignKey(
                        name: "FK_Transaksi_Barang_BarangId",
                        column: x => x.BarangId,
                        principalTable: "Barang",
                        principalColumn: "BarangId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Transaksi_Kategori_KategoriID",
                        column: x => x.KategoriID,
                        principalTable: "Kategori",
                        principalColumn: "KategoriID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Transaksi_BarangId",
                table: "Transaksi",
                column: "BarangId");

            migrationBuilder.CreateIndex(
                name: "IX_Transaksi_KategoriID",
                table: "Transaksi",
                column: "KategoriID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Transaksi");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Kategori",
                table: "Kategori");

            migrationBuilder.RenameTable(
                name: "Kategori",
                newName: "Kateogri");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Kateogri",
                table: "Kateogri",
                column: "KategoriID");
        }
    }
}
