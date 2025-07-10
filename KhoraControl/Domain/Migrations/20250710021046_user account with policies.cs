using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace KhoraControl.Migrations
{
    /// <inheritdoc />
    public partial class useraccountwithpolicies : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.CreateTable(
                name: "user_account",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    user_name = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    password = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user_account", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "user_account_policy",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    user_account_id = table.Column<int>(type: "INTEGER", nullable: false),
                    user_policy = table.Column<string>(type: "TEXT", nullable: true),
                    is_enabled = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user_account_policy", x => x.id);
                });

            migrationBuilder.InsertData(
                table: "user_account",
                columns: new[] { "id", "password", "user_name" },
                values: new object[] { 1, "Admin", "admin" });

            migrationBuilder.InsertData(
                table: "user_account_policy",
                columns: new[] { "id", "is_enabled", "user_account_id", "user_policy" },
                values: new object[,]
                {
                    { 1, true, 1, "VIEW_PRODUCT" },
                    { 2, true, 1, "UPDATE_PRODUCT" },
                    { 3, true, 1, "DELETE_PRODUCT" },
                    { 4, true, 1, "CREATE_PRODUCT" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.DropTable(
                name: "user_account");

            migrationBuilder.DropTable(
                name: "user_account_policy");
        }
    }
}
