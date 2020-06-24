using Microsoft.EntityFrameworkCore.Migrations;

namespace SmartSchool.API.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AlunoDisciplinas",
                columns: table => new
                {
                    ALunoId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DisciplinaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AlunoDisciplinas", x => x.ALunoId);
                });

            migrationBuilder.CreateTable(
                name: "Alunos",
                columns: table => new
                {
                    AlunooId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(nullable: true),
                    Sobrenome = table.Column<string>(nullable: true),
                    telefone = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alunos", x => x.AlunooId);
                });

            migrationBuilder.CreateTable(
                name: "Disciplinas",
                columns: table => new
                {
                    DisciplinaId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NomeDisciplina = table.Column<string>(nullable: true),
                    IdQuemLeciona = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Disciplinas", x => x.DisciplinaId);
                });

            migrationBuilder.CreateTable(
                name: "Professores",
                columns: table => new
                {
                    ProfessorId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NomeProfessor = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Professores", x => x.ProfessorId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AlunoDisciplinas");

            migrationBuilder.DropTable(
                name: "Alunos");

            migrationBuilder.DropTable(
                name: "Disciplinas");

            migrationBuilder.DropTable(
                name: "Professores");
        }
    }
}
