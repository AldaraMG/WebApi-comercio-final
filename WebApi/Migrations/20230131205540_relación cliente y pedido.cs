using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApi.Migrations
{
    
    public partial class Relaciónclienteypedido : Migration
    {
        
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "IdProduct",
                table: "Order",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ClientIdClient",
                table: "Order",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "IdOrder",
                table: "Client",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Order_ClientIdClient",
                table: "Order",
                column: "ClientIdClient");

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Client_ClientIdClient",
                table: "Order",
                column: "ClientIdClient",
                principalTable: "Client",
                principalColumn: "IdClient");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Order_Client_ClientIdClient",
                table: "Order");

            migrationBuilder.DropIndex(
                name: "IX_Order_ClientIdClient",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "ClientIdClient",
                table: "Order");

            migrationBuilder.AlterColumn<int>(
                name: "IdProduct",
                table: "Order",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "IdOrder",
                table: "Client",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");
        }
    }
}
