using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SolutionName.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class firstMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MultiplicadorBase = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ValorCotadoEmReais = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ValorOriginal = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ValorComTaxa = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cliente");
        }
    }
}
