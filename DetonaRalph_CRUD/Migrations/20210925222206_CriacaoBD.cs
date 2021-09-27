using Microsoft.EntityFrameworkCore.Migrations;

namespace DetonaRalph_CRUD.Migrations
{
    public partial class CriacaoBD : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Personagens",
                columns: table => new
                {
                    PersonagemID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomePersonagem = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CenarioID = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personagens", x => x.PersonagemID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Personagens");
        }
    }
}
