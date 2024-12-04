using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JwtRoleAuthentication.data.migrations
{
    /// <inheritdoc />
    public partial class updatebrg : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Transaksi_Barang_BarangId",
                table: "Transaksi");

            migrationBuilder.DropForeignKey(
                name: "FK_Transaksi_Kategori_KategoriID",
                table: "Transaksi");

            migrationBuilder.DropIndex(
                name: "IX_Transaksi_BarangId",
                table: "Transaksi");

            migrationBuilder.DropIndex(
                name: "IX_Transaksi_KategoriID",
                table: "Transaksi");

            migrationBuilder.DropColumn(
                name: "BarangId",
                table: "Transaksi");

            migrationBuilder.DropColumn(
                name: "KategoriID",
                table: "Transaksi");

            migrationBuilder.AlterColumn<string>(
                name: "StokAwal",
                table: "Barang",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "NamaBarang",
                table: "Barang",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "Kategori",
                table: "Barang",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "Harga",
                table: "Barang",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "GambarBarang",
                table: "Barang",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BarangId",
                table: "Transaksi",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "KategoriID",
                table: "Transaksi",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "StokAwal",
                table: "Barang",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NamaBarang",
                table: "Barang",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Kategori",
                table: "Barang",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Harga",
                table: "Barang",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "GambarBarang",
                table: "Barang",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Transaksi_BarangId",
                table: "Transaksi",
                column: "BarangId");

            migrationBuilder.CreateIndex(
                name: "IX_Transaksi_KategoriID",
                table: "Transaksi",
                column: "KategoriID");

            migrationBuilder.AddForeignKey(
                name: "FK_Transaksi_Barang_BarangId",
                table: "Transaksi",
                column: "BarangId",
                principalTable: "Barang",
                principalColumn: "BarangId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Transaksi_Kategori_KategoriID",
                table: "Transaksi",
                column: "KategoriID",
                principalTable: "Kategori",
                principalColumn: "KategoriID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
