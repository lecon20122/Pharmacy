using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pharmacy.Migrations
{
    /// <inheritdoc />
    public partial class AddPrescriptionStatus : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Status",
                table: "Prescription",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f2ba69b1-f3ab-4b0e-9167-d26dcda3a87e", "AQAAAAIAAYagAAAAEG5tb+rrGfvQoEGuuqOCIcx9xcRcoHIG5jKFEHdcJIcFDtKH16cWJhB21e78Z79nJw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4855bbc5-d4c6-4f48-867c-af32b8002cbf", "AQAAAAIAAYagAAAAEDlFSiCtv05MGKrNAAF52mdsLp6C7PGGzdPi00DUANa6tJz5PbG8go/VPACW4BcW1g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2f21aa26-b00c-45d1-ae2c-422611e7755d", "AQAAAAIAAYagAAAAEDJi/uCNHv6P41vE4JprMaUHHzE8/jQaCg7zxsHaoTH/bA7apqrrCFdCQ1QmePCxJA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2f1abd20-df01-4eee-a688-93862d05ffe4", "AQAAAAIAAYagAAAAEFf6wKqLmlv5yAOTreiHAw5c/q1GdfCzdgkCDsL/ICJoACmGgMbF55j8Y/MEaDpevg==" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "Prescription");

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
    }
}
