using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TechFin.Spotifin.Infra.Migrations
{
    /// <inheritdoc />
    public partial class AjustaAssinatura : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "TipoAssinatura",
                table: "Assinaturas",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AddColumn<Guid>(
                name: "UsuarioId",
                table: "Assinaturas",
                type: "TEXT",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "Assinaturas");

            migrationBuilder.AlterColumn<string>(
                name: "TipoAssinatura",
                table: "Assinaturas",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");
        }
    }
}
