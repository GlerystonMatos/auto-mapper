using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Mapper.Api.Migrations
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
                values: new object[] { new Guid("09133751-e1b5-45f4-9cdc-2881b362ec0f"), "Administrador" });

            migrationBuilder.InsertData(
                table: "Usuario",
                columns: new[] { "Id", "IdPerfil", "Nome" },
                values: new object[] { new Guid("4f45917e-0391-42bc-a677-c3666d18ab82"), new Guid("09133751-e1b5-45f4-9cdc-2881b362ec0f"), "Snoopy" });

            migrationBuilder.InsertData(
                table: "Usuario",
                columns: new[] { "Id", "IdPerfil", "Nome" },
                values: new object[] { new Guid("2ab71627-e14c-48ee-ae7e-ac411b8fdf8b"), new Guid("09133751-e1b5-45f4-9cdc-2881b362ec0f"), "Lola" });

            migrationBuilder.InsertData(
                table: "Usuario",
                columns: new[] { "Id", "IdPerfil", "Nome" },
                values: new object[] { new Guid("1bb7f3b7-735d-4455-9d29-96c87473ac1a"), new Guid("09133751-e1b5-45f4-9cdc-2881b362ec0f"), "Tobias" });

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
