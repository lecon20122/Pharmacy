using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Pharmacy.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { 1, null, "Doctor", "DOCTOR" },
                    { 2, null, "Nurse", "NURSE" },
                    { 3, null, "Patient", "PATIENT" },
                    { 4, null, "Pharmacist", "PHARMACIST" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Role", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { 1, 0, "a710da54-6be5-4396-a128-7b14d90f08d6", "doctor@gmail.com", true, false, null, "DOCTOR@GMAIL.COM", "DOCTOR@GMAIL.COM", "AQAAAAIAAYagAAAAELq9nyjgmtc0pbJ1SVzrFzfasnxwZlr6lYTsWmETrD/v3tz45+Ln/5+6z5xjcRWnwg==", null, false, "Patient", "", false, "doctor@gmail.com" },
                    { 2, 0, "324e0963-744b-4b48-b86d-d9f911c3d05d", "Nurse@gmail.com", true, false, null, "NURSE@GMAIL.COM", "NURSE@GMAIL.COM", "AQAAAAIAAYagAAAAEJGYDXWRl2cHa+CgREUNj423QyVLsUzrW5WgE6fnhH1nibgTL13bifZn+I9u6DXH7g==", null, false, "Patient", "", false, "Nurse@gmail.com" },
                    { 3, 0, "2a50ae1c-9e64-47b3-80bd-f56d75a1f5e9", "Patient@gmail.com", true, false, null, "PATIENT@GMAIL.COM", "PATIENT@GMAIL.COM", "AQAAAAIAAYagAAAAEBXShz9d9NOciKoROCm4mnYHobcwqh5tXISVPvmSygwYPq4dby9ESBN12tBT6EjjhA==", null, false, "Patient", "", false, "Patient@gmail.com" },
                    { 4, 0, "0dba6ba8-ee93-4bfe-a14b-6a90990aeace", "Pharmacist@gmail.com", true, false, null, "PHARMACIST@GMAIL.COM", "PHARMACIST@GMAIL.COM", "AQAAAAIAAYagAAAAEC3Ug5sBbhRutI56/eF+2Bq1Y0pOkBBTz/GXZHgQyELw98JXvbq7fn/+ZGmv5v1wNw==", null, false, "Patient", "", false, "Pharmacist@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 },
                    { 3, 3 },
                    { 4, 4 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 4, 4 });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
