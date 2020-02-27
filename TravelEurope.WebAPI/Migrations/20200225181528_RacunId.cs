using Microsoft.EntityFrameworkCore.Migrations;

namespace TravelEurope.WebAPI.Migrations
{
    public partial class RacunId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "RacunId",
                table: "Rezervacija",
                nullable: true,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "RacunId",
                table: "Rezervacija",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);
        }
    }
}
