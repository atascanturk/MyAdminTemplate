using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyWebsite.DataAccess.Migrations
{
    public partial class updateCategoryAdministrativeStaffImage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Images",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Categories",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "AdministrativeStaffs",
                type: "int",
                nullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_Images_CategoryId",
                table: "Images",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_AdministrativeStaffs_CategoryId",
                table: "AdministrativeStaffs",
                column: "CategoryId");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AdministrativeStaffs_Categories_CategoryId",
                table: "AdministrativeStaffs");

            migrationBuilder.DropForeignKey(
                name: "FK_Images_Categories_CategoryId",
                table: "Images");

            migrationBuilder.DropIndex(
                name: "IX_Images_CategoryId",
                table: "Images");

            migrationBuilder.DropIndex(
                name: "IX_AdministrativeStaffs_CategoryId",
                table: "AdministrativeStaffs");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Images");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "AdministrativeStaffs");

            migrationBuilder.UpdateData(
                table: "Newss",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 1, 23, 23, 6, 8, 813, DateTimeKind.Local).AddTicks(1101));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "bf1e9464-81be-471c-a275-c58202b3813a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "a530b57a-1c74-4739-a751-a209f36d9f59");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "a6f3e3aa-8ab2-417a-9d67-c6591845a432");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "88db0eb9-49f8-4506-abb7-43b8ff1abc9e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "39ee3527-a1fb-4406-8123-fed910361d1a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 6,
                column: "ConcurrencyStamp",
                value: "61d4a927-4c9c-4a5d-a835-b65c9e7f0b10");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 7,
                column: "ConcurrencyStamp",
                value: "11618c43-21f2-4fa6-962a-2cc24f31a115");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 8,
                column: "ConcurrencyStamp",
                value: "67d0af68-067a-415f-9013-f7345192203c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 9,
                column: "ConcurrencyStamp",
                value: "334c272f-9e63-4f50-ac48-80c855472fac");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 10,
                column: "ConcurrencyStamp",
                value: "54ff6cc3-9ece-47c7-b17f-8ec3df6097be");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 11,
                column: "ConcurrencyStamp",
                value: "bfccf0ce-c276-4750-b820-544bf2f2be34");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 12,
                column: "ConcurrencyStamp",
                value: "0c8d8b61-c9b7-4438-8810-a0832bdf5a55");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 13,
                column: "ConcurrencyStamp",
                value: "e206367c-246e-49a9-aad9-2751951dea42");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 14,
                column: "ConcurrencyStamp",
                value: "a81665a2-63d3-4dcd-bffb-b704e2396309");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 15,
                column: "ConcurrencyStamp",
                value: "1e7b7e4c-5fc2-48a8-86d4-c16e41825998");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 16,
                column: "ConcurrencyStamp",
                value: "39b4b3b3-7480-4720-a414-027ac4b5aadb");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 17,
                column: "ConcurrencyStamp",
                value: "efdb06c6-723f-43b9-94c7-9898106bded0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 18,
                column: "ConcurrencyStamp",
                value: "d20d392b-a737-4e55-a940-689967ae145e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 19,
                column: "ConcurrencyStamp",
                value: "9a23c9e7-a28c-481c-a1b3-2d3602053da0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 20,
                column: "ConcurrencyStamp",
                value: "80e73098-2f5a-4e9a-93b6-d14e77d61ef1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 21,
                column: "ConcurrencyStamp",
                value: "91ada4d9-58f5-41eb-8571-4d9741bb05d7");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 22,
                column: "ConcurrencyStamp",
                value: "b65f3fd7-3343-40b7-85dd-f21821550175");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1cea19b6-6f8e-4e1f-ac70-bfdffcf194eb", "AQAAAAEAACcQAAAAEOc/+ftxf1EvLXfHENPZswAtdLig27huI5TsbVbt5OU0RAXIHipKufHzqY8KANifxQ==", "e6f95a4d-b624-4f86-a494-486ff9a39a46" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d33c64c2-4259-47ac-8b75-6985841405eb", "AQAAAAEAACcQAAAAEF/AaeoWY28apXjeRLqvyMF80t1uAUSteJgRf28C+T4Rq9DXTMyH5nMCTZuq/en3oQ==", "9ecbd3f0-1023-490b-9dda-c6a9ce84a12f" });
        }
    }
}
