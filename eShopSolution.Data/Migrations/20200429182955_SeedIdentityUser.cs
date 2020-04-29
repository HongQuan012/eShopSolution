using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class SeedIdentityUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AppRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[] { new Guid("e7e6995c-b07e-435f-9a83-4614de0b168b"), "b26a8bb1-ed71-4672-a0a8-3038b828ad47", "administrator role", "admin", "admin" });

            migrationBuilder.InsertData(
                table: "AppUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { new Guid("4b041493-1272-4d17-a457-1b1e4dcbc557"), new Guid("e7e6995c-b07e-435f-9a83-4614de0b168b") });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Dob", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("4b041493-1272-4d17-a457-1b1e4dcbc557"), 0, "db372228-6989-4b87-80eb-17da9514ab2a", new DateTime(1997, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "thuongthien07@gmail.com", true, "Hong", "Quan", false, null, "thuongthien07@gmail.com", "admin", "AQAAAAEAACcQAAAAED/H1gABjqK/rosGOTA2baWGSq3/3em6pEeR0B1b4fdCaac1VeFPwdE9OjNVDyoqPw==", null, false, "", false, "admin" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2020, 4, 30, 1, 29, 55, 177, DateTimeKind.Local).AddTicks(7434));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("e7e6995c-b07e-435f-9a83-4614de0b168b"));

            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("4b041493-1272-4d17-a457-1b1e4dcbc557"), new Guid("e7e6995c-b07e-435f-9a83-4614de0b168b") });

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("4b041493-1272-4d17-a457-1b1e4dcbc557"));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2020, 4, 30, 1, 27, 25, 412, DateTimeKind.Local).AddTicks(4755));
        }
    }
}
