using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TimeApi.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TB_AFAZERES",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeAfazer = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    Descricao = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    DataRegistro = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataAfazer = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TipodeAfazer = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_AFAZERES", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "TB_AFAZERES",
                columns: new[] { "Id", "DataAfazer", "DataRegistro", "Descricao", "NomeAfazer", "TipodeAfazer" },
                values: new object[,]
                {
                    { 1, null, null, "Varrer o chão, lavar o banheiro e tirar pó das estantes", "Limpar a Casa", 1 },
                    { 2, null, null, "Terminar a apresentação para a equipe da empresa", "Terminar Apresentação", 3 },
                    { 3, null, null, "Finalizar a API da aula de DS e entregar no prazo", "Terminar a API", 2 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TB_AFAZERES");
        }
    }
}
