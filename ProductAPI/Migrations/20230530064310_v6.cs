using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProductAPI.Migrations
{
    /// <inheritdoc />
    public partial class v6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Properties_Products_ProductId",
                table: "Properties");

            migrationBuilder.DropForeignKey(
                name: "FK_PropertyDetails_Properties_PropertiesPropertyId",
                table: "PropertyDetails");

            migrationBuilder.DropIndex(
                name: "IX_PropertyDetails_PropertiesPropertyId",
                table: "PropertyDetails");

            migrationBuilder.DropColumn(
                name: "PropertiesPropertyId",
                table: "PropertyDetails");

            migrationBuilder.AlterColumn<int>(
                name: "PropertyId",
                table: "PropertyDetails",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ProductId",
                table: "Properties",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_PropertyDetails_PropertyId",
                table: "PropertyDetails",
                column: "PropertyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Properties_Products_ProductId",
                table: "Properties",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_PropertyDetails_Properties_PropertyId",
                table: "PropertyDetails",
                column: "PropertyId",
                principalTable: "Properties",
                principalColumn: "PropertyId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Properties_Products_ProductId",
                table: "Properties");

            migrationBuilder.DropForeignKey(
                name: "FK_PropertyDetails_Properties_PropertyId",
                table: "PropertyDetails");

            migrationBuilder.DropIndex(
                name: "IX_PropertyDetails_PropertyId",
                table: "PropertyDetails");

            migrationBuilder.AlterColumn<int>(
                name: "PropertyId",
                table: "PropertyDetails",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PropertiesPropertyId",
                table: "PropertyDetails",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ProductId",
                table: "Properties",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PropertyDetails_PropertiesPropertyId",
                table: "PropertyDetails",
                column: "PropertiesPropertyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Properties_Products_ProductId",
                table: "Properties",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PropertyDetails_Properties_PropertiesPropertyId",
                table: "PropertyDetails",
                column: "PropertiesPropertyId",
                principalTable: "Properties",
                principalColumn: "PropertyId");
        }
    }
}
