using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pharmacy.Migrations
{
    /// <inheritdoc />
    public partial class RemoveStatusAndHistory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "History",
                table: "Pet");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Appointment");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "366c8e5e-e076-4ccb-b8d2-c13252084cdf", "AQAAAAIAAYagAAAAEIy+zoxOCrvp54u26sGdBajGSqRDPMu8Rox3UejXgZgJE5AozsoYM5HcE/YjMzUdKg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f8fdd538-bc9a-45a5-8501-1b1c002d4273", "AQAAAAIAAYagAAAAEGnj3mMsdH70dlivC7+2SV3VyeXgON9dzlo43USRrMzZWUFDyXYaaFsaEN72m7HrUA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c6b1838b-d9e6-4a48-8824-951c98cbd0b4", "AQAAAAIAAYagAAAAEK0EpQ8DEVNQ9hGu6L/nQxn5sjEBeEM3ETfq3RVzESRqXpiMQIVKOr+f1h6EYSI3Tg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "075b6a0e-dd20-456c-883e-6a5b5311630f", "AQAAAAIAAYagAAAAEHUSY7KP+xKS1g6nBxbg77z+mfzJjUZwIbPrnmuoecy3STfxvclDhlRE+u73iY2QDA==" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "History",
                table: "Pet",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Appointment",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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
    }
}
