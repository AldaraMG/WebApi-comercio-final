using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApi.Migrations
{
    /// <inheritdoc />
    public partial class relacionesentretablas4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Order_Order_OrderId",
                table: "Order");

            migrationBuilder.DropIndex(
                name: "IX_Order_OrderId",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "Order");

            migrationBuilder.AddColumn<int>(
                name: "OrderId",
                table: "Client",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Client_OrderId",
                table: "Client",
                column: "OrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_Client_Order_OrderId",
                table: "Client",
                column: "OrderId",
                principalTable: "Order",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Client_Order_OrderId",
                table: "Client");

            migrationBuilder.DropIndex(
                name: "IX_Client_OrderId",
                table: "Client");

            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "Client");

            migrationBuilder.AddColumn<int>(
                name: "OrderId",
                table: "Order",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Order_OrderId",
                table: "Order",
                column: "OrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Order_OrderId",
                table: "Order",
                column: "OrderId",
                principalTable: "Order",
                principalColumn: "Id");
        }
    }
}
