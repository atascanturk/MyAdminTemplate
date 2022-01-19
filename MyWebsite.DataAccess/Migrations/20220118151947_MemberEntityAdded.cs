using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyWebsite.DataAccess.Migrations
{
    public partial class MemberEntityAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Members",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdentityNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BirthOfDay = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Members", x => x.Id);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Members");

            migrationBuilder.UpdateData(
                table: "Newss",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 1, 18, 18, 18, 57, 21, DateTimeKind.Local).AddTicks(2072));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "6071cee6-9360-4186-b639-0853988aab6d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "e911909c-d8b4-49f9-aa94-d1cc0e620d38");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "9d478811-cbb9-4708-975f-6052ea003e55");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "a5099313-a499-450d-9e76-22b9e3e5b8ed");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "cc411473-cf88-4a51-8efe-74822d6ee94c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 6,
                column: "ConcurrencyStamp",
                value: "c874ec0f-57aa-437f-9015-43980e69fa24");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 7,
                column: "ConcurrencyStamp",
                value: "bad1dbbe-7a39-421d-89e1-a27ecc7dfad2");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 8,
                column: "ConcurrencyStamp",
                value: "3beb33a7-7c7c-423b-b363-fc800abc7b80");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 9,
                column: "ConcurrencyStamp",
                value: "fe5157c0-37ab-4190-973f-4486f2709270");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 10,
                column: "ConcurrencyStamp",
                value: "bb23648c-ab10-4ba2-8a84-ca468fbd9230");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 11,
                column: "ConcurrencyStamp",
                value: "96bb5287-6bd8-4e4f-b1e7-8fe8242f2238");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 12,
                column: "ConcurrencyStamp",
                value: "c8a2d955-3d65-47e9-9a3e-02d90681e676");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 13,
                column: "ConcurrencyStamp",
                value: "0330393a-e0ad-4164-a7ac-040021c66a6d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 14,
                column: "ConcurrencyStamp",
                value: "205f80d2-071f-423b-9254-3fea04a725f0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 15,
                column: "ConcurrencyStamp",
                value: "ee8ecbea-df82-4de1-9f51-af0915192a22");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 16,
                column: "ConcurrencyStamp",
                value: "a68da4ec-f728-424d-86a1-477ba88b8ee4");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 17,
                column: "ConcurrencyStamp",
                value: "00f5146b-dfa2-4cce-967b-0023e398e9b2");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 18,
                column: "ConcurrencyStamp",
                value: "8220b210-c1ef-4680-802b-ca56278e73e2");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 19,
                column: "ConcurrencyStamp",
                value: "fe538600-698f-4eee-96f4-22b614e8c89e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 20,
                column: "ConcurrencyStamp",
                value: "c1b49484-2d56-4b81-b9ce-8f82b4f601a4");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 21,
                column: "ConcurrencyStamp",
                value: "0ec31752-fe86-4bb3-8a62-d3982ab5c517");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 22,
                column: "ConcurrencyStamp",
                value: "4a4469bf-c3ae-4f33-8146-93c8581ab64d");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d615d567-e4c0-410c-92fd-f18d953fe9a6", "AQAAAAEAACcQAAAAEEO6MEPiR6HrKEzPPtVEkoErqe0JSYJ7EI6cKS7cE7giuqlmFx3CWZDp/s/cWFWkkQ==", "646cd059-1daa-48f6-86de-455341ff9c8e" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f420a958-2e92-4e84-a655-2fb23e8c80f2", "AQAAAAEAACcQAAAAELrSaG/2suTumcxA5sk25bn5jsBM5ZjjWyOuraWfXe9Uv3QwmHNQqEoJnPae+ycEPg==", "faffb621-75e9-40b6-91c8-2fe986547fce" });
        }
    }
}
