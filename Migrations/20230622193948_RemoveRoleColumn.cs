using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pharmacy.Migrations
{
    /// <inheritdoc />
    public partial class RemoveRoleColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Role",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "044844c3-d66f-4ec2-80a2-53896398f9a2", "AQAAAAIAAYagAAAAEJUc68dR770vL2UIUOMPk8J+MrBKrhwzmAQtsjaUpgCJACTTIgHnB2ybydQPFW9vBQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "fc84b758-7d33-431c-a21c-06733980d238", "AQAAAAIAAYagAAAAEAyCbJ5BnDenAj4yWygq+xw/6IhRejrBDq4x9Hh4Rc1OYpwhdHV+VEp4ve5uAFYdMg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d751e09d-d37b-4219-a37e-b59aa0f5ca67", "AQAAAAIAAYagAAAAEPvM1sPDIUquw1FSeNcSx9OPgslArf3jaw9a2/oW269332EYqjyj9KU/FdrMrKJb8g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e1470fb7-499a-446a-ad43-b5ecfc133625", "AQAAAAIAAYagAAAAEJEsi58Cfl9G+gPGxGzcBFXp0SGChVigazPzMjgyuxqRAOmLrRdimt1AMF/25sC9Eg==" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Role",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "Role" },
                values: new object[] { "a710da54-6be5-4396-a128-7b14d90f08d6", "AQAAAAIAAYagAAAAELq9nyjgmtc0pbJ1SVzrFzfasnxwZlr6lYTsWmETrD/v3tz45+Ln/5+6z5xjcRWnwg==", "Patient" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "Role" },
                values: new object[] { "324e0963-744b-4b48-b86d-d9f911c3d05d", "AQAAAAIAAYagAAAAEJGYDXWRl2cHa+CgREUNj423QyVLsUzrW5WgE6fnhH1nibgTL13bifZn+I9u6DXH7g==", "Patient" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "Role" },
                values: new object[] { "2a50ae1c-9e64-47b3-80bd-f56d75a1f5e9", "AQAAAAIAAYagAAAAEBXShz9d9NOciKoROCm4mnYHobcwqh5tXISVPvmSygwYPq4dby9ESBN12tBT6EjjhA==", "Patient" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "Role" },
                values: new object[] { "0dba6ba8-ee93-4bfe-a14b-6a90990aeace", "AQAAAAIAAYagAAAAEC3Ug5sBbhRutI56/eF+2Bq1Y0pOkBBTz/GXZHgQyELw98JXvbq7fn/+ZGmv5v1wNw==", "Patient" });
        }
    }
}
