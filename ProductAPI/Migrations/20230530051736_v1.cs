using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProductAPI.Migrations
{
    /// <inheritdoc />
    public partial class v1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductDetailPropertyDetails_PropertyDetails_PropertyDetailsPropertyDetailId",
                table: "ProductDetailPropertyDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_PropertyDetails_Properties_PropertiesPropertyId",
                table: "PropertyDetails");

            migrationBuilder.AlterColumn<int>(
                name: "PropertiesPropertyId",
                table: "PropertyDetails",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "PropertyDetailsPropertyDetailId",
                table: "ProductDetailPropertyDetails",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductDetailPropertyDetails_PropertyDetails_PropertyDetailsPropertyDetailId",
                table: "ProductDetailPropertyDetails",
                column: "PropertyDetailsPropertyDetailId",
                principalTable: "PropertyDetails",
                principalColumn: "PropertyDetailId");

            migrationBuilder.AddForeignKey(
                name: "FK_PropertyDetails_Properties_PropertiesPropertyId",
                table: "PropertyDetails",
                column: "PropertiesPropertyId",
                principalTable: "Properties",
                principalColumn: "PropertyId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductDetailPropertyDetails_PropertyDetails_PropertyDetailsPropertyDetailId",
                table: "ProductDetailPropertyDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_PropertyDetails_Properties_PropertiesPropertyId",
                table: "PropertyDetails");

            migrationBuilder.AlterColumn<int>(
                name: "PropertiesPropertyId",
                table: "PropertyDetails",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PropertyDetailsPropertyDetailId",
                table: "ProductDetailPropertyDetails",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductDetailPropertyDetails_PropertyDetails_PropertyDetailsPropertyDetailId",
                table: "ProductDetailPropertyDetails",
                column: "PropertyDetailsPropertyDetailId",
                principalTable: "PropertyDetails",
                principalColumn: "PropertyDetailId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PropertyDetails_Properties_PropertiesPropertyId",
                table: "PropertyDetails",
                column: "PropertiesPropertyId",
                principalTable: "Properties",
                principalColumn: "PropertyId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
