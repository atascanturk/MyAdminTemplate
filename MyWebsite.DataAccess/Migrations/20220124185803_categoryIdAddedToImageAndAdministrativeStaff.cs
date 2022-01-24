using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyWebsite.DataAccess.Migrations
{
    public partial class categoryIdAddedToImageAndAdministrativeStaff : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AdministrativeStaffs_Categories_CategoryId",
                table: "AdministrativeStaffs");

            migrationBuilder.DropForeignKey(
                name: "FK_Images_Categories_CategoryId",
                table: "Images");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "Images",
                type: "int",
                nullable: true,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "AdministrativeStaffs",
                type: "int",
                nullable: true,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AdministrativeStaffs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CategoryId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Newss",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 1, 24, 21, 58, 2, 278, DateTimeKind.Local).AddTicks(9454));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "94bdb89d-49b1-4b12-80c3-e73f75dbf82f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "051d52e3-2b25-410e-a230-e9285df93d52");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "d515b8bd-4737-4072-b92b-a056022dcafd");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "3d992726-2551-4b4a-b1b4-e61981b9746a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "e1d661ad-2c8f-4460-9345-21e23609f3b2");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 6,
                column: "ConcurrencyStamp",
                value: "3953f848-8e71-4df3-8fba-0981186a17bb");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 7,
                column: "ConcurrencyStamp",
                value: "efc8c3df-74ff-4d0f-bea7-c72fc6e03065");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 8,
                column: "ConcurrencyStamp",
                value: "52c103fc-cbed-42c7-a5c6-e227f9c6f028");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 9,
                column: "ConcurrencyStamp",
                value: "116db301-3e6e-49e7-9b60-1f4cbc42ae2d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 10,
                column: "ConcurrencyStamp",
                value: "aed5b0ab-5348-4df6-8c49-ef57affc93fc");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 11,
                column: "ConcurrencyStamp",
                value: "71546d1b-a5c5-44c5-8e17-122f84a0428a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 12,
                column: "ConcurrencyStamp",
                value: "438fc294-4228-41b8-9d0f-05530020c058");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 13,
                column: "ConcurrencyStamp",
                value: "e18898b6-c2e5-4b08-a1e5-407aba241e34");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 14,
                column: "ConcurrencyStamp",
                value: "5a694cd5-c70e-4718-b68f-77aae9baecb3");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 15,
                column: "ConcurrencyStamp",
                value: "5f5c4365-48bc-47c2-a71c-79b392fae574");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 16,
                column: "ConcurrencyStamp",
                value: "0b6d229e-a2b5-4dc7-870a-35baef0ce06d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 17,
                column: "ConcurrencyStamp",
                value: "040bbe51-8711-457e-a49f-0f5fe2ca9d6f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 18,
                column: "ConcurrencyStamp",
                value: "d8e899c5-1513-4295-a994-ec84e26556fa");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 19,
                column: "ConcurrencyStamp",
                value: "860a46f4-7369-46a8-bcb6-813fcc4ef6a9");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 20,
                column: "ConcurrencyStamp",
                value: "2f418dee-c119-4cf4-ad2b-038fa2bbc3ae");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 21,
                column: "ConcurrencyStamp",
                value: "f2554c73-b750-4622-81e1-36c7475dda40");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 22,
                column: "ConcurrencyStamp",
                value: "8d7fa61e-a9a1-4c13-af2d-17e7017d145c");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "341513e4-dd55-4bd4-a4c9-4123c6aafe33", "AQAAAAEAACcQAAAAENO3x7tRDl2nmVvtx8v0mbbmCc0OhpKWdWPdigeBThkqv1lpQtPIm4uTh46E2HtCEg==", "60ef7538-e7bd-42e7-b4b0-2c272b79f54d" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "40dae25c-423d-4e62-82cd-889c1b91eb6a", "AQAAAAEAACcQAAAAEB2iw+JQRdNpw4nVRZXf0z3yqFAwSjaVA+zyhXTk7YW3Qs44y+DzPjOZkrEue1Jpng==", "e838024b-9624-4564-bafc-50db2554ccfb" });

            migrationBuilder.AddForeignKey(
                name: "FK_AdministrativeStaffs_Categories_CategoryId",
                table: "AdministrativeStaffs",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Images_Categories_CategoryId",
                table: "Images",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AdministrativeStaffs_Categories_CategoryId",
                table: "AdministrativeStaffs");

            migrationBuilder.DropForeignKey(
                name: "FK_Images_Categories_CategoryId",
                table: "Images");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "Images",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "AdministrativeStaffs",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AdministrativeStaffs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CategoryId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Newss",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 1, 24, 20, 30, 2, 648, DateTimeKind.Local).AddTicks(1288));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "18e9475d-7318-4d3e-8471-5cf61640e778");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "5e9ecb82-9aa2-4a2a-8935-cd6f124f7016");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "a8f2dc32-883c-4007-8617-c2fddaca7d16");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "6f4d353c-a180-4b4c-8850-1b3ed51b3cbf");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "cc847fbd-e88b-4534-943a-1197930afb84");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 6,
                column: "ConcurrencyStamp",
                value: "f20c9ccf-0f4f-4c46-b406-669459c70164");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 7,
                column: "ConcurrencyStamp",
                value: "34ad1b3c-76ed-4ddf-a578-f38629229020");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 8,
                column: "ConcurrencyStamp",
                value: "dbf08868-92e7-4374-acf8-5162dc5c15ba");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 9,
                column: "ConcurrencyStamp",
                value: "e5408ce4-5f9a-4a94-a38e-2922819200d4");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 10,
                column: "ConcurrencyStamp",
                value: "09ac6a13-da04-4094-9839-255d6ccd62cb");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 11,
                column: "ConcurrencyStamp",
                value: "75acf940-87d5-414b-8ddc-f70bd6d29af3");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 12,
                column: "ConcurrencyStamp",
                value: "aa9db47d-6e76-4b2c-8aa1-7698cd9848c9");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 13,
                column: "ConcurrencyStamp",
                value: "71771501-0ab3-4e53-b65b-a562e30fe6b9");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 14,
                column: "ConcurrencyStamp",
                value: "70412bad-6807-436a-9ad8-518da5e94cf1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 15,
                column: "ConcurrencyStamp",
                value: "3c0feb17-05dc-4b61-a8ab-231536133edc");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 16,
                column: "ConcurrencyStamp",
                value: "5b01b615-a01c-4f87-97d0-6f50b166fd1a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 17,
                column: "ConcurrencyStamp",
                value: "20a99b79-dff1-4dbc-bef0-92daf77fb587");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 18,
                column: "ConcurrencyStamp",
                value: "c2b5c7d0-93fe-42e6-84fc-426a8b8967cf");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 19,
                column: "ConcurrencyStamp",
                value: "879baeed-465f-4753-ac30-5553adbf603c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 20,
                column: "ConcurrencyStamp",
                value: "45fc33b3-4200-461b-bbea-2d830e4d0444");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 21,
                column: "ConcurrencyStamp",
                value: "101930cb-7b21-42f7-9f08-f6ab496315d9");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 22,
                column: "ConcurrencyStamp",
                value: "7727b3b6-5b57-4802-8345-905377f7af4c");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "681088c0-91aa-45fa-9e08-d9c2768b43a8", "AQAAAAEAACcQAAAAEExPrdgVO29NJa00iPRsJmuy0JK5sHnyhzXIp2yyO4raZFuo6t8RI93TShuNVK597g==", "ace84033-deb9-4285-9a0e-6e5f40a5bbf3" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9863c84f-5d45-49b0-8e51-f55588059033", "AQAAAAEAACcQAAAAEFHIBNX7xANcOmeJVGV2Yd8WAYvBbGCU6jpCO2Fd15fP65ZlnjPG5jSZV9OvzUgamg==", "d0a20e2e-a713-413a-944e-bb6f4f7ac15b" });

            migrationBuilder.AddForeignKey(
                name: "FK_AdministrativeStaffs_Categories_CategoryId",
                table: "AdministrativeStaffs",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Images_Categories_CategoryId",
                table: "Images",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
