using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShopBackEnd.Data.Migrations
{
    public partial class OrderEntityAddeds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "7b407f44-835f-4852-90f8-15db576daedf");

            migrationBuilder.UpdateData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "a7e20e56-9116-4320-b928-9bb4476da9a8");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "e3e96a89-22a5-4981-afa8-5b75560499f7");

            migrationBuilder.UpdateData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "a69859a7-7447-4299-8e56-fa6b57a2d50c");
        }
    }
}
