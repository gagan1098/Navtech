using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Navtech.Migrations.DataContextOrderMigrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "orders",
                columns: table => new
                {
                    orderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    orderStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    placedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    items = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_orders", x => x.orderId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "orders");
        }
    }
}
