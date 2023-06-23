using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pharmacy.Migrations
{
    /// <inheritdoc />
    public partial class AddReportsAndPrescriptions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a3d330fa-3b01-4dcc-b44b-cc501a77b8cb", "AQAAAAIAAYagAAAAEGyirrHaNqlBh+bis525zKU0ackfjBF8zUYVzE6otnqEz0fhbsxvWfqW9C8I+uejmQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "fb12d6eb-6eac-4da9-abde-ba88edb001b2", "AQAAAAIAAYagAAAAEHinqdx2Sn005/3F7gT3IxCCMaklQcCMd7KioGK+121iBu83GHXTLuvS6TSotHRBrQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5f5b0748-a0c4-44ef-98ab-82b8fbea1727", "AQAAAAIAAYagAAAAEPazC3pyuDEbDWpkigAzbEokwOHNE8E6cAnCCwUf90irJ9mBb0nX8kTqY2xoWOPWhg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8a523cae-3e59-464d-bda0-07ffc7dac773", "AQAAAAIAAYagAAAAEI19ezOj/T1N4sLWjNJrDBr7vpoP8+AjzlgByk2hxz6vN3vc73Sg9kGABLs3GkzAYg==" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
