using Microsoft.EntityFrameworkCore.Migrations;

namespace prova_dev_API.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "nome",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    nome = table.Column<string>(type: "TEXT", nullable: true),
                    email = table.Column<string>(type: "TEXT", nullable: true),
                    cpf = table.Column<int>(type: "INTEGER", nullable: false),
                    renda = table.Column<string>(type: "TEXT", nullable: true),
                    dtnasc = table.Column<string>(type: "TEXT", nullable: true),
                    celular = table.Column<string>(type: "TEXT", nullable: true),
                    profissao = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_nome", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "nome",
                columns: new[] { "Id", "celular", "cpf", "dtnasc", "email", "nome", "profissao", "renda" },
                values: new object[] { 1, "jfvnsjk", 123456, "gsdjfn", "email", "nome", "jfjsn", "huti" });

            migrationBuilder.InsertData(
                table: "nome",
                columns: new[] { "Id", "celular", "cpf", "dtnasc", "email", "nome", "profissao", "renda" },
                values: new object[] { 2, "jfvnsjk", 123456, "gsdjfn", "email", "nome", "jfjsn", "huti" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "nome");
        }
    }
}
