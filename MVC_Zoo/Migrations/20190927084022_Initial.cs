using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MVC_Zoo.Migrations
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
                    nombre_com = table.Column<string>(nullable: true),
                    nombre_cient = table.Column<string>(nullable: true),
                    descripcion = table.Column<string>(nullable: true),
                    foto = table.Column<string>(nullable: true)
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
                    codigo = table.Column<string>(nullable: true),
                    duracion = table.Column<int>(nullable: false),
                    visitantes = table.Column<int>(nullable: false),
                    longitud = table.Column<int>(nullable: false)
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
                    nombre = table.Column<string>(nullable: true),
                    clima = table.Column<string>(nullable: true),
                    vegetacion = table.Column<string>(nullable: true),
                    itinerarioId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Habitat", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Habitat_Itinerario_itinerarioId",
                        column: x => x.itinerarioId,
                        principalTable: "Itinerario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HabitatEspecie",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    habitatId = table.Column<int>(nullable: false),
                    especieId = table.Column<int>(nullable: false),
                    indice = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HabitatEspecie", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HabitatEspecie_Especie_especieId",
                        column: x => x.especieId,
                        principalTable: "Especie",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HabitatEspecie_Habitat_habitatId",
                        column: x => x.habitatId,
                        principalTable: "Habitat",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Habitat_itinerarioId",
                table: "Habitat",
                column: "itinerarioId");

            migrationBuilder.CreateIndex(
                name: "IX_HabitatEspecie_especieId",
                table: "HabitatEspecie",
                column: "especieId");

            migrationBuilder.CreateIndex(
                name: "IX_HabitatEspecie_habitatId",
                table: "HabitatEspecie",
                column: "habitatId");
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
