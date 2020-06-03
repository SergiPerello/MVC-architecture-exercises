using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MVC_Zoo_2.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Especie",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nombre_com = table.Column<string>(nullable: true),
                    Nombre_cient = table.Column<string>(nullable: true),
                    Descripcion = table.Column<string>(nullable: true),
                    Foto = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Especie", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Itinerario",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Codigo = table.Column<string>(nullable: true),
                    Duracion = table.Column<int>(nullable: false),
                    Visitantes = table.Column<int>(nullable: false),
                    Longitud = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Itinerario", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Habitat",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(nullable: true),
                    Clima = table.Column<string>(nullable: true),
                    Vegetacion = table.Column<string>(nullable: true),
                    ItinerarioId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Habitat", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Habitat_Itinerario_ItinerarioId",
                        column: x => x.ItinerarioId,
                        principalTable: "Itinerario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HabitatEspecie",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    HabitatId = table.Column<int>(nullable: false),
                    EspecieId = table.Column<int>(nullable: false),
                    Indice = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HabitatEspecie", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HabitatEspecie_Especie_EspecieId",
                        column: x => x.EspecieId,
                        principalTable: "Especie",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HabitatEspecie_Habitat_HabitatId",
                        column: x => x.HabitatId,
                        principalTable: "Habitat",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Habitat_ItinerarioId",
                table: "Habitat",
                column: "ItinerarioId");

            migrationBuilder.CreateIndex(
                name: "IX_HabitatEspecie_EspecieId",
                table: "HabitatEspecie",
                column: "EspecieId");

            migrationBuilder.CreateIndex(
                name: "IX_HabitatEspecie_HabitatId",
                table: "HabitatEspecie",
                column: "HabitatId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HabitatEspecie");

            migrationBuilder.DropTable(
                name: "Especie");

            migrationBuilder.DropTable(
                name: "Habitat");

            migrationBuilder.DropTable(
                name: "Itinerario");
        }
    }
}
