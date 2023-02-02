using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApi.Migrations
{
    /// <inheritdoc />
    public partial class cambiosatributos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdOrder",
                table: "Client");

            migrationBuilder.RenameColumn(
                name: "ClientId",
                table: "Order",
                newName: "IdClient");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IdClient",
                table: "Order",
                newName: "ClientId");

            migrationBuilder.AddColumn<int>(
                name: "IdOrder",
                table: "Client",
                type: "int",
                nullable: true);
        }
    }
}
