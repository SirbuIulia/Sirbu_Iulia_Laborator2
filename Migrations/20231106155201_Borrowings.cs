﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sirbu_Iulia_Laborator2.Migrations
{
    public partial class Borrowings : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BorrowingID",
                table: "Book",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Author",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Author",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateTable(
                name: "Member",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Adress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Member", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Borrowing",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MemberID = table.Column<int>(type: "int", nullable: true),
                    BookID = table.Column<int>(type: "int", nullable: true),
                    ReturnDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Borrowing", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Borrowing_Book_BookID",
                        column: x => x.BookID,
                        principalTable: "Book",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Borrowing_Member_MemberID",
                        column: x => x.MemberID,
                        principalTable: "Member",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Borrowing_BookID",
                table: "Borrowing",
                column: "BookID",
                unique: true,
                filter: "[BookID] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Borrowing_MemberID",
                table: "Borrowing",
                column: "MemberID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Borrowing");

            migrationBuilder.DropTable(
                name: "Member");

            migrationBuilder.DropColumn(
                name: "BorrowingID",
                table: "Book");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Author",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Author",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
