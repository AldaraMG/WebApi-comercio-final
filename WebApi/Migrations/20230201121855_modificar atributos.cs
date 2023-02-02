using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApi.Migrations
{
    /// <inheritdoc />
    public partial class modificaratributos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Precio",
                table: "Product",
                newName: "Price");

            migrationBuilder.RenameColumn(
                name: "Marca",
                table: "Product",
                newName: "Brand");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Price",
                table: "Product",
                newName: "Precio");

            migrationBuilder.RenameColumn(
                name: "Brand",
                table: "Product",
                newName: "Marca");
        }
    }
}
