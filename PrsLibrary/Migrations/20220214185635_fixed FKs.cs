using Microsoft.EntityFrameworkCore.Migrations;

namespace PrsLibrary.Migrations
{
    public partial class fixedFKs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Total",
                table: "Requests",
                type: "decimal(11,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Products",
                type: "decimal(11,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.CreateIndex(
                name: "IX_Requests_UserID",
                table: "Requests",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_RequestLines_ProductID",
                table: "RequestLines",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_RequestLines_RequestID",
                table: "RequestLines",
                column: "RequestID");

            migrationBuilder.CreateIndex(
                name: "IX_Products_VendorID",
                table: "Products",
                column: "VendorID");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Vendors_VendorID",
                table: "Products",
                column: "VendorID",
                principalTable: "Vendors",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RequestLines_Products_ProductID",
                table: "RequestLines",
                column: "ProductID",
                principalTable: "Products",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RequestLines_Requests_RequestID",
                table: "RequestLines",
                column: "RequestID",
                principalTable: "Requests",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Requests_Users_UserID",
                table: "Requests",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Vendors_VendorID",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_RequestLines_Products_ProductID",
                table: "RequestLines");

            migrationBuilder.DropForeignKey(
                name: "FK_RequestLines_Requests_RequestID",
                table: "RequestLines");

            migrationBuilder.DropForeignKey(
                name: "FK_Requests_Users_UserID",
                table: "Requests");

            migrationBuilder.DropIndex(
                name: "IX_Requests_UserID",
                table: "Requests");

            migrationBuilder.DropIndex(
                name: "IX_RequestLines_ProductID",
                table: "RequestLines");

            migrationBuilder.DropIndex(
                name: "IX_RequestLines_RequestID",
                table: "RequestLines");

            migrationBuilder.DropIndex(
                name: "IX_Products_VendorID",
                table: "Products");

            migrationBuilder.AlterColumn<decimal>(
                name: "Total",
                table: "Requests",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(11,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Products",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(11,2)");
        }
    }
}
