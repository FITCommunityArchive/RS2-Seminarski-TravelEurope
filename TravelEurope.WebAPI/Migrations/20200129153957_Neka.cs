using Microsoft.EntityFrameworkCore.Migrations;

namespace TravelEurope.WebAPI.Migrations
{
    public partial class Neka : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
        

            migrationBuilder.AddForeignKey(
                name: "FK_TuristickiVodic_StraniJezik_StraniJezikId",
                table: "TuristickiVodic",
                column: "StraniJezikId",
                principalTable: "StraniJezik",
                principalColumn: "StraniJezikId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TuristickiVodic_StraniJezik_StraniJezikId",
                table: "TuristickiVodic");

           
        }
    }
}
