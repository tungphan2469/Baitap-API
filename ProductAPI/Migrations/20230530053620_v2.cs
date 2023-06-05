using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProductAPI.Migrations
{
    /// <inheritdoc />
    public partial class v2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductDetailPropertyDetails_PropertyDetails_PropertyDetailsPropertyDetailId",
                table: "ProductDetailPropertyDetails");

            migrationBuilder.DropIndex(
                name: "IX_ProductDetailPropertyDetails_PropertyDetailsPropertyDetailId",
                table: "ProductDetailPropertyDetails");

            migrationBuilder.DropColumn(
                name: "PropertyDetailsPropertyDetailId",
                table: "ProductDetailPropertyDetails");

            migrationBuilder.CreateIndex(
                name: "IX_ProductDetailPropertyDetails_PropertyDetailId",
                table: "ProductDetailPropertyDetails",
                column: "PropertyDetailId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductDetailPropertyDetails_PropertyDetails_PropertyDetailId",
                table: "ProductDetailPropertyDetails",
                column: "PropertyDetailId",
                principalTable: "PropertyDetails",
                principalColumn: "PropertyDetailId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductDetailPropertyDetails_PropertyDetails_PropertyDetailId",
                table: "ProductDetailPropertyDetails");

            migrationBuilder.DropIndex(
                name: "IX_ProductDetailPropertyDetails_PropertyDetailId",
                table: "ProductDetailPropertyDetails");

            migrationBuilder.AddColumn<int>(
                name: "PropertyDetailsPropertyDetailId",
                table: "ProductDetailPropertyDetails",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProductDetailPropertyDetails_PropertyDetailsPropertyDetailId",
                table: "ProductDetailPropertyDetails",
                column: "PropertyDetailsPropertyDetailId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductDetailPropertyDetails_PropertyDetails_PropertyDetailsPropertyDetailId",
                table: "ProductDetailPropertyDetails",
                column: "PropertyDetailsPropertyDetailId",
                principalTable: "PropertyDetails",
                principalColumn: "PropertyDetailId");
        }
    }
}
