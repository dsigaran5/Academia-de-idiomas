using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Academia_De_Idiomas.Migrations
{
    public partial class academia : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Idiomas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomIdioma = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Idiomas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Modalidad",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomModalidad = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Modalidad", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Profesores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomProfe = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    idIdiomaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profesores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Profesores_Idiomas_idIdiomaId",
                        column: x => x.idIdiomaId,
                        principalTable: "Idiomas",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Alumnos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomAlum = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApeAlum = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Correo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Contraseña = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CodModalidadId = table.Column<int>(type: "int", nullable: true),
                    CodIdiomaId = table.Column<int>(type: "int", nullable: true),
                    IdProfeId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alumnos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Alumnos_Idiomas_CodIdiomaId",
                        column: x => x.CodIdiomaId,
                        principalTable: "Idiomas",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Alumnos_Modalidad_CodModalidadId",
                        column: x => x.CodModalidadId,
                        principalTable: "Modalidad",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Alumnos_Profesores_IdProfeId",
                        column: x => x.IdProfeId,
                        principalTable: "Profesores",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Alumnos_CodIdiomaId",
                table: "Alumnos",
                column: "CodIdiomaId");

            migrationBuilder.CreateIndex(
                name: "IX_Alumnos_CodModalidadId",
                table: "Alumnos",
                column: "CodModalidadId");

            migrationBuilder.CreateIndex(
                name: "IX_Alumnos_IdProfeId",
                table: "Alumnos",
                column: "IdProfeId");

            migrationBuilder.CreateIndex(
                name: "IX_Profesores_idIdiomaId",
                table: "Profesores",
                column: "idIdiomaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Alumnos");

            migrationBuilder.DropTable(
                name: "Modalidad");

            migrationBuilder.DropTable(
                name: "Profesores");

            migrationBuilder.DropTable(
                name: "Idiomas");
        }
    }
}
