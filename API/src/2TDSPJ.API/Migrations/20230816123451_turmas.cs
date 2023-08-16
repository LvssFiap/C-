using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _2TDSPJ.API.Migrations
{
    /// <inheritdoc />
    public partial class turmas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Turmas",
                columns: table => new
                {
                    TurmaId = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Sigla = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Sala = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Ativo = table.Column<bool>(type: "NUMBER(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Turmas", x => x.TurmaId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Turmas");
        }
    }
}
