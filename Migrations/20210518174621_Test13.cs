using Microsoft.EntityFrameworkCore.Migrations;

namespace model_test.Migrations
{
    public partial class Test13 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_WorkCenterOperations_OperationId",
                table: "WorkCenterOperations");

            migrationBuilder.CreateIndex(
                name: "IX_WorkCenterOperations_OperationId",
                table: "WorkCenterOperations",
                column: "OperationId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_WorkCenterOperations_OperationId",
                table: "WorkCenterOperations");

            migrationBuilder.CreateIndex(
                name: "IX_WorkCenterOperations_OperationId",
                table: "WorkCenterOperations",
                column: "OperationId",
                unique: true);
        }
    }
}
