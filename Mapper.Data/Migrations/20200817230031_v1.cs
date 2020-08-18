using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Mapper.Data.Migrations
{
    public partial class v1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Perfil",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Nome = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Perfil", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Nome = table.Column<string>(nullable: false),
                    IdPerfil = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Usuario_Perfil_IdPerfil",
                        column: x => x.IdPerfil,
                        principalTable: "Perfil",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Perfil",
                columns: new[] { "Id", "Nome" },
                values: new object[] { new Guid("ee41c173-2df4-4014-ab9f-93ed74579fc7"), "Administrador" });

            migrationBuilder.InsertData(
                table: "Usuario",
                columns: new[] { "Id", "IdPerfil", "Nome" },
                values: new object[] { new Guid("09ed19f5-a91c-424a-aff0-d2f0e63b8a26"), new Guid("ee41c173-2df4-4014-ab9f-93ed74579fc7"), "Snoopy" });

            migrationBuilder.InsertData(
                table: "Usuario",
                columns: new[] { "Id", "IdPerfil", "Nome" },
                values: new object[] { new Guid("911417ce-88f7-48c5-8186-4695b60a92d8"), new Guid("ee41c173-2df4-4014-ab9f-93ed74579fc7"), "Lola" });

            migrationBuilder.InsertData(
                table: "Usuario",
                columns: new[] { "Id", "IdPerfil", "Nome" },
                values: new object[] { new Guid("d5318abd-2b47-4115-a900-4c6fb1792456"), new Guid("ee41c173-2df4-4014-ab9f-93ed74579fc7"), "Tobias" });

            migrationBuilder.CreateIndex(
                name: "IX_Perfil_Nome",
                table: "Perfil",
                column: "Nome",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_IdPerfil",
                table: "Usuario",
                column: "IdPerfil");

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_Nome",
                table: "Usuario",
                column: "Nome",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropTable(
                name: "Perfil");
        }
    }
}
