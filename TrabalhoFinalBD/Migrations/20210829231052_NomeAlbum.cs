using Microsoft.EntityFrameworkCore.Migrations;

namespace Trabalho_Final_BD.Migrations
{
    public partial class NomeAlbum : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Nome",
                table: "Albuns",
                type: "text",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Nome",
                table: "Albuns");
        }
    }
}
