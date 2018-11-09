using Microsoft.EntityFrameworkCore.Migrations;

namespace Sporfe1._0.Migrations
{
    public partial class fotoprofes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Foto",
                table: "Profesor",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Foto",
                table: "Profesor");
        }
    }
}
