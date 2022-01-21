using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyWebsite.DataAccess.Migrations
{
    public partial class IsDeletedToVideoEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Videos",
                type: "bit",
                nullable: false,
                defaultValue: false);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Videos");

            migrationBuilder.UpdateData(
                table: "Newss",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 1, 18, 18, 19, 46, 621, DateTimeKind.Local).AddTicks(4630));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "04d0fb2d-0732-4334-af44-f0535b23ba75");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "fdd00b72-4a18-46c3-97b5-bc44edad289d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "ae0055a6-e1f5-48bb-ac62-fd26ea2fab56");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "0213f98f-c863-425c-b557-730c0dc75945");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "36b699ed-20ac-494d-b143-c54f04bee92a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 6,
                column: "ConcurrencyStamp",
                value: "f3824211-b225-4575-8e91-e4a71d5603ec");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 7,
                column: "ConcurrencyStamp",
                value: "b1c0e910-ea37-408d-976d-3b4efe75862e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 8,
                column: "ConcurrencyStamp",
                value: "8751386d-c9ff-400e-9d07-b7505ab964fb");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 9,
                column: "ConcurrencyStamp",
                value: "c029f057-5b4a-4492-9774-40b0cf559bfb");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 10,
                column: "ConcurrencyStamp",
                value: "f50800cf-44f5-42b4-8968-e60a16826d40");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 11,
                column: "ConcurrencyStamp",
                value: "8749556a-9744-45ed-90d1-70c9292bfb19");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 12,
                column: "ConcurrencyStamp",
                value: "4d470459-867a-4c4c-be21-f441d0614a40");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 13,
                column: "ConcurrencyStamp",
                value: "5a79e9eb-beee-4069-a648-60417424d005");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 14,
                column: "ConcurrencyStamp",
                value: "cbc1acb0-f615-4b36-bd9f-e6297926984f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 15,
                column: "ConcurrencyStamp",
                value: "b2426dd1-627d-4bf7-a62e-d0fa4ca57307");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 16,
                column: "ConcurrencyStamp",
                value: "c77d2a51-2308-4ee3-abdc-3ad4cb1c490a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 17,
                column: "ConcurrencyStamp",
                value: "d2d7171b-64fe-439c-b829-4c53a34c503b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 18,
                column: "ConcurrencyStamp",
                value: "49a02eda-d5ad-499f-b808-2c4c0d84f564");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 19,
                column: "ConcurrencyStamp",
                value: "670c1a37-d897-467c-845c-ef56b52b012a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 20,
                column: "ConcurrencyStamp",
                value: "22399189-d535-46c9-8505-72676c9865ba");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 21,
                column: "ConcurrencyStamp",
                value: "4c0dd5cd-ebcb-4a42-8362-447d891ed7fa");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 22,
                column: "ConcurrencyStamp",
                value: "01ff1843-f97d-4194-83cd-ec9081c5fa9b");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0e9b6662-cae3-48ab-8f97-1c3ec7b7aa6d", "AQAAAAEAACcQAAAAEE7dNEVSeHQ+aVo58iS8Dbuxq+ze3IzgTYHeeh/WfmN5wjebbonZtCInPCIHfgzqfQ==", "7f5175eb-3c1e-44e8-8f4b-5d1baa7c5305" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ca8f5f83-b254-4516-a3a6-9f34d6230641", "AQAAAAEAACcQAAAAEF8IDGuV6szobH3tYAr92FS8V5ihDsjvvvzLvsyJWPCQEzxKa7TuUbiKoeYBX2Lbeg==", "4099f77d-08fb-4ca3-9bdc-eb6b73f36bb5" });
        }
    }
}
