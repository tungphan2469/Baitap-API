using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProductAPI.Migrations
{
    /// <inheritdoc />
    public partial class v3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductDetailPropertyDetails_ProductDetails_ProductDetailId",
                table: "ProductDetailPropertyDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductDetailPropertyDetails_Products_ProductId",
                table: "ProductDetailPropertyDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductDetailPropertyDetails_PropertyDetails_PropertyDetailId",
                table: "ProductDetailPropertyDetails");

            migrationBuilder.AlterColumn<int>(
                name: "PropertyDetailId",
                table: "ProductDetailPropertyDetails",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ProductId",
                table: "ProductDetailPropertyDetails",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ProductDetailId",
                table: "ProductDetailPropertyDetails",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductDetailPropertyDetails_ProductDetails_ProductDetailId",
                table: "ProductDetailPropertyDetails",
                column: "ProductDetailId",
                principalTable: "ProductDetails",
                principalColumn: "ProductDetailId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductDetailPropertyDetails_Products_ProductId",
                table: "ProductDetailPropertyDetails",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductDetailPropertyDetails_PropertyDetails_PropertyDetailId",
                table: "ProductDetailPropertyDetails",
                column: "PropertyDetailId",
                principalTable: "PropertyDetails",
                principalColumn: "PropertyDetailId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductDetailPropertyDetails_ProductDetails_ProductDetailId",
                table: "ProductDetailPropertyDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductDetailPropertyDetails_Products_ProductId",
                table: "ProductDetailPropertyDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductDetailPropertyDetails_PropertyDetails_PropertyDetailId",
                table: "ProductDetailPropertyDetails");

            migrationBuilder.AlterColumn<int>(
                name: "PropertyDetailId",
                table: "ProductDetailPropertyDetails",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ProductId",
                table: "ProductDetailPropertyDetails",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ProductDetailId",
                table: "ProductDetailPropertyDetails",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductDetailPropertyDetails_ProductDetails_ProductDetailId",
                table: "ProductDetailPropertyDetails",
                column: "ProductDetailId",
                principalTable: "ProductDetails",
                principalColumn: "ProductDetailId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductDetailPropertyDetails_Products_ProductId",
                table: "ProductDetailPropertyDetails",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductDetailPropertyDetails_PropertyDetails_PropertyDetailId",
                table: "ProductDetailPropertyDetails",
                column: "PropertyDetailId",
                principalTable: "PropertyDetails",
                principalColumn: "PropertyDetailId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
