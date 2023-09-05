using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProductsAndCategories.Migrations
{
    public partial class SecondMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Associations_Categories_CategoriesCategoryId",
                table: "Associations");

            migrationBuilder.DropForeignKey(
                name: "FK_Associations_Products_ProductsProductId",
                table: "Associations");

            migrationBuilder.DropIndex(
                name: "IX_Associations_CategoriesCategoryId",
                table: "Associations");

            migrationBuilder.DropIndex(
                name: "IX_Associations_ProductsProductId",
                table: "Associations");

            migrationBuilder.DropColumn(
                name: "CategoriesCategoryId",
                table: "Associations");

            migrationBuilder.DropColumn(
                name: "ProductsProductId",
                table: "Associations");

            migrationBuilder.RenameColumn(
                name: "Product",
                table: "Associations",
                newName: "ProductId");

            migrationBuilder.RenameColumn(
                name: "Category",
                table: "Associations",
                newName: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Associations_CategoryId",
                table: "Associations",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Associations_ProductId",
                table: "Associations",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Associations_Categories_CategoryId",
                table: "Associations",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Associations_Products_ProductId",
                table: "Associations",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Associations_Categories_CategoryId",
                table: "Associations");

            migrationBuilder.DropForeignKey(
                name: "FK_Associations_Products_ProductId",
                table: "Associations");

            migrationBuilder.DropIndex(
                name: "IX_Associations_CategoryId",
                table: "Associations");

            migrationBuilder.DropIndex(
                name: "IX_Associations_ProductId",
                table: "Associations");

            migrationBuilder.RenameColumn(
                name: "ProductId",
                table: "Associations",
                newName: "Product");

            migrationBuilder.RenameColumn(
                name: "CategoryId",
                table: "Associations",
                newName: "Category");

            migrationBuilder.AddColumn<int>(
                name: "CategoriesCategoryId",
                table: "Associations",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProductsProductId",
                table: "Associations",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Associations_CategoriesCategoryId",
                table: "Associations",
                column: "CategoriesCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Associations_ProductsProductId",
                table: "Associations",
                column: "ProductsProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Associations_Categories_CategoriesCategoryId",
                table: "Associations",
                column: "CategoriesCategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Associations_Products_ProductsProductId",
                table: "Associations",
                column: "ProductsProductId",
                principalTable: "Products",
                principalColumn: "ProductId");
        }
    }
}
