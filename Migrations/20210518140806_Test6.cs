using Microsoft.EntityFrameworkCore.Migrations;

namespace model_test.Migrations
{
    public partial class Test6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SubProducts_Products_ProductId",
                table: "SubProducts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SubProducts",
                table: "SubProducts");

            migrationBuilder.RenameTable(
                name: "SubProducts",
                newName: "SubProductTrees");

            migrationBuilder.RenameIndex(
                name: "IX_SubProducts_ProductId",
                table: "SubProductTrees",
                newName: "IX_SubProductTrees_ProductId");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "SubProductTrees",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_SubProductTrees",
                table: "SubProductTrees",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SubProductTrees_Products_ProductId",
                table: "SubProductTrees",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SubProductTrees_Products_ProductId",
                table: "SubProductTrees");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SubProductTrees",
                table: "SubProductTrees");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "SubProductTrees");

            migrationBuilder.RenameTable(
                name: "SubProductTrees",
                newName: "SubProducts");

            migrationBuilder.RenameIndex(
                name: "IX_SubProductTrees_ProductId",
                table: "SubProducts",
                newName: "IX_SubProducts_ProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SubProducts",
                table: "SubProducts",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SubProducts_Products_ProductId",
                table: "SubProducts",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
