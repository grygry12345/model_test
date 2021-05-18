using Microsoft.EntityFrameworkCore.Migrations;

namespace model_test.Migrations
{
    public partial class Test4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Operations_ProductType",
                table: "Operations");

            migrationBuilder.CreateIndex(
                name: "IX_Operations_ProductType",
                table: "Operations",
                column: "ProductType");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Operations_ProductType",
                table: "Operations");

            migrationBuilder.CreateIndex(
                name: "IX_Operations_ProductType",
                table: "Operations",
                column: "ProductType",
                unique: true);
        }
    }
}
