using Microsoft.EntityFrameworkCore.Migrations;

namespace TravelEurope.WebAPI.Migrations
{
    public partial class AddKategorije : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "KategorijaId",
                table: "Vozilo",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "KategorijaId",
                table: "Vozac",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "KategorijaId",
                table: "TuristRuta",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Vozilo_KategorijaId",
                table: "Vozilo",
                column: "KategorijaId");

            migrationBuilder.CreateIndex(
                name: "IX_Vozac_KategorijaId",
                table: "Vozac",
                column: "KategorijaId");

            migrationBuilder.CreateIndex(
                name: "IX_TuristRuta_KategorijaId",
                table: "TuristRuta",
                column: "KategorijaId");

            migrationBuilder.AddForeignKey(
                name: "FK_TuristRuta_Kategorije_KategorijaId",
                table: "TuristRuta",
                column: "KategorijaId",
                principalTable: "Kategorije",
                principalColumn: "KategorijaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vozac_Kategorije_KategorijaId",
                table: "Vozac",
                column: "KategorijaId",
                principalTable: "Kategorije",
                principalColumn: "KategorijaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vozilo_Kategorije_KategorijaId",
                table: "Vozilo",
                column: "KategorijaId",
                principalTable: "Kategorije",
                principalColumn: "KategorijaId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TuristRuta_Kategorije_KategorijaId",
                table: "TuristRuta");

            migrationBuilder.DropForeignKey(
                name: "FK_Vozac_Kategorije_KategorijaId",
                table: "Vozac");

            migrationBuilder.DropForeignKey(
                name: "FK_Vozilo_Kategorije_KategorijaId",
                table: "Vozilo");

            migrationBuilder.DropIndex(
                name: "IX_Vozilo_KategorijaId",
                table: "Vozilo");

            migrationBuilder.DropIndex(
                name: "IX_Vozac_KategorijaId",
                table: "Vozac");

            migrationBuilder.DropIndex(
                name: "IX_TuristRuta_KategorijaId",
                table: "TuristRuta");

            migrationBuilder.DropColumn(
                name: "KategorijaId",
                table: "Vozilo");

            migrationBuilder.DropColumn(
                name: "KategorijaId",
                table: "Vozac");

            migrationBuilder.DropColumn(
                name: "KategorijaId",
                table: "TuristRuta");
        }
    }
}
