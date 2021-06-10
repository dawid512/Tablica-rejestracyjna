using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace tablica_rejestracyjna.Migrations
{
    public partial class Inital_v7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Komentarze_Tablice_tablicaId",
                table: "Komentarze");

            migrationBuilder.RenameColumn(
                name: "tablicaId",
                table: "Komentarze",
                newName: "tablicaID");

            migrationBuilder.RenameIndex(
                name: "IX_Komentarze_tablicaId",
                table: "Komentarze",
                newName: "IX_Komentarze_tablicaID");

            migrationBuilder.AlterColumn<int>(
                name: "tablicaID",
                table: "Komentarze",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CommentDate",
                table: "Komentarze",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Komentarze",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Komentarze_Tablice_tablicaID",
                table: "Komentarze",
                column: "tablicaID",
                principalTable: "Tablice",
                principalColumn: "tablicaId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Komentarze_Tablice_tablicaID",
                table: "Komentarze");

            migrationBuilder.DropColumn(
                name: "CommentDate",
                table: "Komentarze");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Komentarze");

            migrationBuilder.RenameColumn(
                name: "tablicaID",
                table: "Komentarze",
                newName: "tablicaId");

            migrationBuilder.RenameIndex(
                name: "IX_Komentarze_tablicaID",
                table: "Komentarze",
                newName: "IX_Komentarze_tablicaId");

            migrationBuilder.AlterColumn<int>(
                name: "tablicaId",
                table: "Komentarze",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Komentarze_Tablice_tablicaId",
                table: "Komentarze",
                column: "tablicaId",
                principalTable: "Tablice",
                principalColumn: "tablicaId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
