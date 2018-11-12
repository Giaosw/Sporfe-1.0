using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Sporfe1._0.Migrations
{
    public partial class cDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Alumno",
                columns: table => new
                {
                    IdAlumno = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(nullable: false),
                    Alias = table.Column<string>(nullable: false),
                    correo = table.Column<string>(nullable: false),
                    Contraseña = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alumno", x => x.IdAlumno);
                });

            migrationBuilder.CreateTable(
                name: "Curso",
                columns: table => new
                {
                    IdCurso = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Curso", x => x.IdCurso);
                });

            migrationBuilder.CreateTable(
                name: "ProfesorAlumno",
                columns: table => new
                {
                    IdProfesor = table.Column<int>(nullable: false),
                    IdAlumno = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProfesorAlumno", x => new { x.IdProfesor, x.IdAlumno });
                    table.ForeignKey(
                        name: "FK_ProfesorAlumno_Alumno_IdAlumno",
                        column: x => x.IdAlumno,
                        principalTable: "Alumno",
                        principalColumn: "IdAlumno",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Profesor",
                columns: table => new
                {
                    IdProfesor = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(nullable: false),
                    Edad = table.Column<int>(nullable: false),
                    Foto = table.Column<string>(nullable: true),
                    correo = table.Column<string>(nullable: true),
                    AniosExperiencia = table.Column<int>(nullable: false),
                    calificacionIdCalificacion = table.Column<int>(nullable: true),
                    comentario = table.Column<string>(nullable: true),
                    CursoIdCurso = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profesor", x => x.IdProfesor);
                    table.ForeignKey(
                        name: "FK_Profesor_Curso_CursoIdCurso",
                        column: x => x.CursoIdCurso,
                        principalTable: "Curso",
                        principalColumn: "IdCurso",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Calificacion",
                columns: table => new
                {
                    IdCalificacion = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    promcalificacion = table.Column<int>(nullable: false),
                    ensenanza = table.Column<int>(nullable: false),
                    evaluacion = table.Column<int>(nullable: false),
                    buenaGente = table.Column<int>(nullable: false),
                    ProfesorIdProfesor = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Calificacion", x => x.IdCalificacion);
                    table.ForeignKey(
                        name: "FK_Calificacion_Profesor_ProfesorIdProfesor",
                        column: x => x.ProfesorIdProfesor,
                        principalTable: "Profesor",
                        principalColumn: "IdProfesor",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProfesorCurso",
                columns: table => new
                {
                    IdProfesor = table.Column<int>(nullable: false),
                    IdCurso = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProfesorCurso", x => new { x.IdCurso, x.IdProfesor });
                    table.ForeignKey(
                        name: "FK_ProfesorCurso_Curso_IdCurso",
                        column: x => x.IdCurso,
                        principalTable: "Curso",
                        principalColumn: "IdCurso",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProfesorCurso_Profesor_IdProfesor",
                        column: x => x.IdProfesor,
                        principalTable: "Profesor",
                        principalColumn: "IdProfesor",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Calificacion_ProfesorIdProfesor",
                table: "Calificacion",
                column: "ProfesorIdProfesor");

            migrationBuilder.CreateIndex(
                name: "IX_Profesor_CursoIdCurso",
                table: "Profesor",
                column: "CursoIdCurso");

            migrationBuilder.CreateIndex(
                name: "IX_Profesor_calificacionIdCalificacion",
                table: "Profesor",
                column: "calificacionIdCalificacion");

            migrationBuilder.CreateIndex(
                name: "IX_ProfesorAlumno_IdAlumno",
                table: "ProfesorAlumno",
                column: "IdAlumno");

            migrationBuilder.CreateIndex(
                name: "IX_ProfesorCurso_IdProfesor",
                table: "ProfesorCurso",
                column: "IdProfesor");

            migrationBuilder.AddForeignKey(
                name: "FK_ProfesorAlumno_Profesor_IdProfesor",
                table: "ProfesorAlumno",
                column: "IdProfesor",
                principalTable: "Profesor",
                principalColumn: "IdProfesor",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Profesor_Calificacion_calificacionIdCalificacion",
                table: "Profesor",
                column: "calificacionIdCalificacion",
                principalTable: "Calificacion",
                principalColumn: "IdCalificacion",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Calificacion_Profesor_ProfesorIdProfesor",
                table: "Calificacion");

            migrationBuilder.DropTable(
                name: "ProfesorAlumno");

            migrationBuilder.DropTable(
                name: "ProfesorCurso");

            migrationBuilder.DropTable(
                name: "Alumno");

            migrationBuilder.DropTable(
                name: "Profesor");

            migrationBuilder.DropTable(
                name: "Curso");

            migrationBuilder.DropTable(
                name: "Calificacion");
        }
    }
}
