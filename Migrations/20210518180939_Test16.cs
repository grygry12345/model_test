using Microsoft.EntityFrameworkCore.Migrations;

namespace model_test.Migrations
{
    public partial class Test16 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Schedules_Products_ProductId1",
                table: "Schedules");

            migrationBuilder.DropIndex(
                name: "IX_Schedules_ProductId1",
                table: "Schedules");

            migrationBuilder.DropColumn(
                name: "ProductId1",
                table: "Schedules");

            migrationBuilder.AlterColumn<string>(
                name: "ProductId",
                table: "Schedules",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.CreateIndex(
                name: "IX_Schedules_ProductId",
                table: "Schedules",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Schedules_Products_ProductId",
                table: "Schedules",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Schedules_Products_ProductId",
                table: "Schedules");

            migrationBuilder.DropIndex(
                name: "IX_Schedules_ProductId",
                table: "Schedules");

            migrationBuilder.AlterColumn<int>(
                name: "ProductId",
                table: "Schedules",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProductId1",
                table: "Schedules",
                type: "TEXT",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Schedules_ProductId1",
                table: "Schedules",
                column: "ProductId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Schedules_Products_ProductId1",
                table: "Schedules",
                column: "ProductId1",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
