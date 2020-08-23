using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Mapper.Api.Migrations
{
    public partial class v1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Nome = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.Id);
                });

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
                table: "Cliente",
                columns: new[] { "Id", "Nome" },
                values: new object[] { new Guid("02f4b241-a1ad-488f-b04b-0bc7cbf7f382"), "Tobias" });

            migrationBuilder.InsertData(
                table: "Perfil",
                columns: new[] { "Id", "Nome" },
                values: new object[] { new Guid("e5777322-6c48-4482-8194-95e15fbe4a74"), "Administrador" });

            migrationBuilder.InsertData(
                table: "Usuario",
                columns: new[] { "Id", "IdPerfil", "Nome" },
                values: new object[] { new Guid("e1c923c4-bdb6-4c1b-9e02-acb845b3ab5a"), new Guid("e5777322-6c48-4482-8194-95e15fbe4a74"), "Snoopy" });

            migrationBuilder.InsertData(
                table: "Usuario",
                columns: new[] { "Id", "IdPerfil", "Nome" },
                values: new object[] { new Guid("b5a09339-6f6d-4a9b-9b81-17fa1a16cdb3"), new Guid("e5777322-6c48-4482-8194-95e15fbe4a74"), "Lola" });

            migrationBuilder.InsertData(
                table: "Usuario",
                columns: new[] { "Id", "IdPerfil", "Nome" },
                values: new object[] { new Guid("1f47bfdc-19ec-4dc2-bd8f-3dc3cccbe185"), new Guid("e5777322-6c48-4482-8194-95e15fbe4a74"), "Tobias" });

            migrationBuilder.CreateIndex(
                name: "IX_Cliente_Nome",
                table: "Cliente",
                column: "Nome",
                unique: true);

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
                name: "Cliente");

            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropTable(
                name: "Perfil");
        }
    }
}
