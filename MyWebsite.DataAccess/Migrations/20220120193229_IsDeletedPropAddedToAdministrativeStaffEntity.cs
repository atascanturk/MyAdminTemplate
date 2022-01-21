using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyWebsite.DataAccess.Migrations
{
    public partial class IsDeletedPropAddedToAdministrativeStaffEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "AdministrativeStaffs",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Newss",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 1, 20, 22, 32, 28, 673, DateTimeKind.Local).AddTicks(1713));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "c8425d74-11f3-4673-bf7d-694214acb0e7");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "19031b6b-aa08-462f-bf38-8cc2e1cf6a1c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "135d50d6-4d85-4827-bf3a-6c81895601ab");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "a65b5180-5741-47da-9736-5d2c37e679a9");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "38e94084-56ae-498f-b774-a5fff14819a1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 6,
                column: "ConcurrencyStamp",
                value: "b130a183-49ae-439c-b906-8f97d3f1d4de");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 7,
                column: "ConcurrencyStamp",
                value: "9e7b8a61-1226-4f28-81d1-d7b5357c6119");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 8,
                column: "ConcurrencyStamp",
                value: "3ab59f43-57ea-49c7-bb1f-18dd722686b8");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 9,
                column: "ConcurrencyStamp",
                value: "2fdbaf59-c4c1-4397-b752-1544e587a0a5");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 10,
                column: "ConcurrencyStamp",
                value: "f5ce87b8-04c5-4292-981c-8e18f0758d94");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 11,
                column: "ConcurrencyStamp",
                value: "888abe47-7142-4d10-941d-72fcb709977a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 12,
                column: "ConcurrencyStamp",
                value: "c7ee9304-8981-4ce7-8c7a-50c15012042e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 13,
                column: "ConcurrencyStamp",
                value: "4a9f0802-f2db-4e08-a013-dc09e5a566ee");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 14,
                column: "ConcurrencyStamp",
                value: "fb72b134-47b7-4a02-ace4-1f44e16749c0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 15,
                column: "ConcurrencyStamp",
                value: "2c76536d-44c5-4c6f-937b-b9df4fb628a6");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 16,
                column: "ConcurrencyStamp",
                value: "02b18bcf-bf74-4fe5-b5fd-be900ec7aa5d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 17,
                column: "ConcurrencyStamp",
                value: "8f9121d2-44c0-46ec-80a1-0b0246dc14cb");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 18,
                column: "ConcurrencyStamp",
                value: "42733a78-a709-46d2-96b2-e9afbb8283d8");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 19,
                column: "ConcurrencyStamp",
                value: "9fb09920-b0e2-42a7-a033-ee9164c009fe");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 20,
                column: "ConcurrencyStamp",
                value: "4cda768f-dbb9-4e87-bdec-13e7c077ea28");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 21,
                column: "ConcurrencyStamp",
                value: "3e2542ec-b38f-4bf3-9342-c30d45effde1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 22,
                column: "ConcurrencyStamp",
                value: "f4e407ab-d7cd-4c47-bbcc-1275cd48fce8");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8622a519-486e-404c-9acd-27244ec3e9fd", "AQAAAAEAACcQAAAAEKwAwB+38jf+tfFlmSs5rYq8Us9woPtBvH3lrKR5nKXgp++wcDI978PAMS/aGCKknQ==", "a002cdd7-5323-4544-80d6-989e870188f9" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8baf9f61-2ad2-436b-bc88-3c220a61efb0", "AQAAAAEAACcQAAAAEJ60U1v38Tms/BlkBqlT6leUCRLkp5wZvB+BacNGo2EVkzmRhB5qnWnOmYwMltja5A==", "b847c14f-8c91-4ec1-94da-874a09ebfb0f" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "AdministrativeStaffs");

            migrationBuilder.UpdateData(
                table: "Newss",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 1, 20, 17, 10, 18, 774, DateTimeKind.Local).AddTicks(446));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "436ec39b-ccd4-4153-92ad-891e754adc40");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "f92b004e-23ad-4a5f-b40a-0cba16cfeb2e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "2742506d-2026-4285-9307-03b5100ed778");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "38cd2ba6-5d1e-409d-b9ef-dedf40c12c69");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "bf795d6a-1a4d-4ebf-806b-3f90fe4bd5da");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 6,
                column: "ConcurrencyStamp",
                value: "5f274041-cfe2-492b-ab9e-79db0261a79d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 7,
                column: "ConcurrencyStamp",
                value: "b8eb532d-7a49-4332-8a2e-cd9cfb21d2a0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 8,
                column: "ConcurrencyStamp",
                value: "302302d5-1d1b-4b1d-8a1c-325c117d7fc4");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 9,
                column: "ConcurrencyStamp",
                value: "63a72e40-0be2-4ae4-aa9a-4ef2a23288c3");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 10,
                column: "ConcurrencyStamp",
                value: "bbe3600c-e599-4572-8172-d8488f4ff3df");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 11,
                column: "ConcurrencyStamp",
                value: "73ab6c72-9010-41a5-9c21-24b6608e9605");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 12,
                column: "ConcurrencyStamp",
                value: "748bd6a7-63a9-40bf-9838-5a1e2d4cac6d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 13,
                column: "ConcurrencyStamp",
                value: "1689c098-dd14-47d5-ab9e-01239b0247a1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 14,
                column: "ConcurrencyStamp",
                value: "ada48b92-18dd-4360-a075-55aca5af9bb0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 15,
                column: "ConcurrencyStamp",
                value: "62969318-a489-45de-8e2c-d0548f010a52");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 16,
                column: "ConcurrencyStamp",
                value: "5b52b05c-2d1c-403d-a77f-537148794e7e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 17,
                column: "ConcurrencyStamp",
                value: "873354c1-509d-4d28-a825-e10cfc40166c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 18,
                column: "ConcurrencyStamp",
                value: "8eca4308-e366-4990-bb07-277cef9bcb6c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 19,
                column: "ConcurrencyStamp",
                value: "be8d09fe-e41d-4ae9-baff-0c31b7b9006b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 20,
                column: "ConcurrencyStamp",
                value: "0f9b4a59-d458-409e-916d-de494c87f9e0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 21,
                column: "ConcurrencyStamp",
                value: "c6df14d6-57ff-4d16-941b-abe6efe5bac6");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 22,
                column: "ConcurrencyStamp",
                value: "2ed01ce2-260c-48ee-bed9-09a24274038d");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "714bec93-be1a-4dd6-8d66-39ac3dda1dfc", "AQAAAAEAACcQAAAAEMBcizjvUau8hjQdFBU37Y4z/NBYnMwS1X9FCWekHRoXV86rNRzF6qPIjBktTnCMCg==", "a4487e94-dd7d-4ad5-bafc-ab4301690e59" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f603b456-78a6-4747-ad61-210b2cb61e79", "AQAAAAEAACcQAAAAEInVJYDDVy3hBpoC1o9alR+fxl/WMeWOJWASfy0aWxa3P/bsQ7UAEx8uh96eP+GtxQ==", "7f9fafdd-2094-4adc-bd19-d4f2b05313f1" });
        }
    }
}
