﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bodone_Iulia_Lab2.Migrations
{
    /// <inheritdoc />
    public partial class authors : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Author",
                table: "Book",
                newName: "AuthorID");

            migrationBuilder.AddColumn<int>(
                name: "AuthorID1",
                table: "Book",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Author",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AuthorFirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AuthorLastName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Author", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Book_AuthorID1",
                table: "Book",
                column: "AuthorID1");

            migrationBuilder.AddForeignKey(
                name: "FK_Book_Author_AuthorID1",
                table: "Book",
                column: "AuthorID1",
                principalTable: "Author",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Book_Author_AuthorID1",
                table: "Book");

            migrationBuilder.DropTable(
                name: "Author");

            migrationBuilder.DropIndex(
                name: "IX_Book_AuthorID1",
                table: "Book");

            migrationBuilder.DropColumn(
                name: "AuthorID1",
                table: "Book");

            migrationBuilder.RenameColumn(
                name: "AuthorID",
                table: "Book",
                newName: "Author");
        }
    }
}
