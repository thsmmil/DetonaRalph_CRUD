using Microsoft.EntityFrameworkCore.Migrations;

namespace DetonaRalph_CRUD.Migrations
{
    public partial class CriacaoBD : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cenarios",
                columns: table => new
                {
                    CenarioID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeCenario = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pathImg = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cenarios", x => x.CenarioID);
                });

            migrationBuilder.CreateTable(
                name: "Personagens",
                columns: table => new
                {
                    PersonagemID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomePersonagem = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CenarioID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personagens", x => x.PersonagemID);
                    table.ForeignKey(
                        name: "FK_Personagens_Cenarios_CenarioID",
                        column: x => x.CenarioID,
                        principalTable: "Cenarios",
                        principalColumn: "CenarioID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Personagens_CenarioID",
                table: "Personagens",
                column: "CenarioID");
            migrationBuilder.InsertData(
                table: "Cenarios",
                columns: new[] { "NomeCenario", "pathImg" },
                values: new object[] { "Entrada do Prédio no Jogo do Ralph", "/img/predio_jogo.jpeg" });
            migrationBuilder.InsertData(
                table: "Cenarios",
                columns: new[] { "NomeCenario", "pathImg" },
                values: new object[] { "Telhado do Prédio no Jogo do Ralph", "/img/telhado_jogo.jpeg" });
            migrationBuilder.InsertData(
                table: "Cenarios",
                columns: new[] { "NomeCenario", "pathImg" },
                values: new object[] { "Lago no Mundo Doce", "/img/mundo_doce.jpeg" });
            migrationBuilder.InsertData(
                table: "Cenarios",
                columns: new[] { "NomeCenario", "pathImg" },
                values: new object[] { "Árvore no Mundo Doce", "/img/mundo_doce2.jpeg" });
            migrationBuilder.InsertData(
                table: "Cenarios",
                columns: new[] { "NomeCenario", "pathImg" },
                values: new object[] { "Corrida no Mundo Doce", "/img/mundo_doce3.jpeg" });

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Personagens");

            migrationBuilder.DropTable(
                name: "Cenarios");
        }
    }
}
