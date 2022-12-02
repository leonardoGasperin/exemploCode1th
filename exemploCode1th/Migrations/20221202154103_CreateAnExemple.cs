using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace exemploCode1th.Migrations
{
    /// <inheritdoc />
    public partial class CreateAnExemple : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cursos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Requisito = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CargaHorária = table.Column<int>(name: "Carga Horária", type: "int", nullable: true),
                    Valor = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cursos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Estudante",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cpf = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(name: "E-mail", type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Telefone = table.Column<string>(type: "nvarchar(14)", maxLength: 14, nullable: false),
                    DatadeNascimento = table.Column<DateTime>(name: "Data de Nascimento", type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estudante", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Instructors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Email = table.Column<string>(name: "E-mail", type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Telefone = table.Column<string>(type: "nvarchar(14)", maxLength: 14, nullable: false),
                    ValorHora = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Certificado = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instructors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Turma",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdInstrutor = table.Column<int>(name: "Id Instrutor", type: "int", nullable: false),
                    IdCurso = table.Column<int>(name: "Id Curso", type: "int", nullable: false),
                    Datadeinício = table.Column<DateTime>(name: "Data de início", type: "datetime2", nullable: true),
                    Datadetérmino = table.Column<DateTime>(name: "Data de término", type: "datetime2", nullable: true),
                    CargaHorária = table.Column<int>(name: "Carga Horária", type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Turma", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Turma_Cursos_Id Curso",
                        column: x => x.IdCurso,
                        principalTable: "Cursos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Turma_Instructors_Id Instrutor",
                        column: x => x.IdInstrutor,
                        principalTable: "Instructors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Matrícula",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdTurma = table.Column<int>(name: "Id Turma", type: "int", nullable: false),
                    IdAluno = table.Column<int>(name: "Id Aluno", type: "int", nullable: false),
                    DataMatricula = table.Column<DateTime>(name: "Data Matricula", type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Matrícula", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Matrícula_Estudante_Id Aluno",
                        column: x => x.IdAluno,
                        principalTable: "Estudante",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Matrícula_Turma_Id Turma",
                        column: x => x.IdTurma,
                        principalTable: "Turma",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Matrícula_Id Aluno",
                table: "Matrícula",
                column: "Id Aluno");

            migrationBuilder.CreateIndex(
                name: "IX_Matrícula_Id Turma",
                table: "Matrícula",
                column: "Id Turma");

            migrationBuilder.CreateIndex(
                name: "IX_Turma_Id Curso",
                table: "Turma",
                column: "Id Curso");

            migrationBuilder.CreateIndex(
                name: "IX_Turma_Id Instrutor",
                table: "Turma",
                column: "Id Instrutor");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Matrícula");

            migrationBuilder.DropTable(
                name: "Estudante");

            migrationBuilder.DropTable(
                name: "Turma");

            migrationBuilder.DropTable(
                name: "Cursos");

            migrationBuilder.DropTable(
                name: "Instructors");
        }
    }
}
