using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CompanyEmployees.Migrations
{
    public partial class AddedRolesToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "5974e296-8c39-4249-8427-e3d0c713bec3", "ff4b26a9-2e4a-4e0d-b9c2-ad5bfd133a42", "Administrator", "ADMINISTRATOR" },
                    { "96cda858-6b63-4384-8a22-397cec74dbbe", "67643c1d-398e-43a2-88db-5e228e4da473", "Manager", "MANAGER" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5974e296-8c39-4249-8427-e3d0c713bec3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "96cda858-6b63-4384-8a22-397cec74dbbe");
        }
    }
}
