using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyWebsite.DataAccess.Migrations
{
    public partial class namePropAddedToContactEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Contacts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Newss",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 2, 1, 0, 45, 21, 624, DateTimeKind.Local).AddTicks(6337));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "c564dca0-ba15-455b-8bbe-b5b80b5c8782");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "d18d9aaf-b34e-4662-b148-390eb78411e5");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "c60e7203-a8a1-4d92-9754-04ce35af260c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "300ce682-a593-42c9-90bb-188f2b8baaaf");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "ff28353f-5bd7-4763-a3a2-15f997b633e5");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 6,
                column: "ConcurrencyStamp",
                value: "20b8b566-437a-4e38-a3ad-7b1f475bb893");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 7,
                column: "ConcurrencyStamp",
                value: "9a880099-c056-46fd-8496-2359181725ee");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 8,
                column: "ConcurrencyStamp",
                value: "21ef42f6-f686-4ad2-9977-1c7118bc1f35");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 9,
                column: "ConcurrencyStamp",
                value: "0da28af2-93e8-4208-b4cf-ba4abe3e3a66");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 10,
                column: "ConcurrencyStamp",
                value: "7c2aa60e-1190-4977-881a-125292ef2eab");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 11,
                column: "ConcurrencyStamp",
                value: "82c41a5b-571a-4bab-a800-e7161c55b681");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 12,
                column: "ConcurrencyStamp",
                value: "38af1bc1-1511-4d3c-8742-beb2fe502342");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 13,
                column: "ConcurrencyStamp",
                value: "2ac01173-9a17-46d8-a6ae-6f51ee367e0d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 14,
                column: "ConcurrencyStamp",
                value: "3294afe9-ce63-460c-aeb5-0c8d4ce2c37b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 15,
                column: "ConcurrencyStamp",
                value: "4602ba77-febb-4ed5-ae3a-7ba98d95d1cc");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 16,
                column: "ConcurrencyStamp",
                value: "fc318877-5b2e-4a94-8108-93a1e91d2109");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 17,
                column: "ConcurrencyStamp",
                value: "3e78c81c-92fd-45b2-9827-74da3ce4aac5");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 18,
                column: "ConcurrencyStamp",
                value: "ce585d02-ead3-4634-8201-b2e23c3cca1e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 19,
                column: "ConcurrencyStamp",
                value: "bb683ea0-a695-4f70-acc9-a76881e4b2c2");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 20,
                column: "ConcurrencyStamp",
                value: "5662fc5c-84eb-4daa-a36f-0c3a17b43051");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 21,
                column: "ConcurrencyStamp",
                value: "789af174-8b2c-4247-ba85-f7c148ad99ef");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 22,
                column: "ConcurrencyStamp",
                value: "55ef30b2-14a1-4550-ae7b-e11ee8c47bcc");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f9c5d6f2-b116-4a6c-ae9a-77355b467089", "AQAAAAEAACcQAAAAEFQBrhEaHNmNyacg1Bf6mCdekHJyLgjAokz6lfpQIzhRr4eW51PePjxbwn+omceXSw==", "e2d35e13-cdcf-49ec-af18-951778b95760" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2cacb17d-4833-4e30-895f-bc33bd7d441a", "AQAAAAEAACcQAAAAEDn8f5IqcbPmna4F+G9oNJv5YmgEvft/UYui//OdY4FXNoZF0ioRc4kA4h9gjLoopg==", "1fc7d9e0-1680-445a-a2c1-215e4a98435c" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Contacts");

            migrationBuilder.UpdateData(
                table: "Newss",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 1, 31, 15, 49, 11, 757, DateTimeKind.Local).AddTicks(2226));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "dcdc4cf4-98ad-4579-b30c-64a54109adb5");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "aa22c276-d014-41ec-9275-57377ee3db43");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "b069296d-b118-47a1-a902-bfe8c29e563c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "7222f220-8fe6-4651-8a41-22208ff41a56");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "ed00056f-07b2-4a71-be94-a12ff3aa9c49");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 6,
                column: "ConcurrencyStamp",
                value: "41a04ce6-d9d0-4afa-8128-a56099fc8731");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 7,
                column: "ConcurrencyStamp",
                value: "9a15526a-a26e-4aaf-89c6-683e74a4d990");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 8,
                column: "ConcurrencyStamp",
                value: "54a2ad86-7068-429a-b924-28664b6e07fa");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 9,
                column: "ConcurrencyStamp",
                value: "476792ce-e72f-4ded-8c51-2bf8ca14ce17");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 10,
                column: "ConcurrencyStamp",
                value: "dcec5b2e-0622-44d6-b263-05a3edef020d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 11,
                column: "ConcurrencyStamp",
                value: "32c96260-c751-47e4-99ce-ba32c6239a9a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 12,
                column: "ConcurrencyStamp",
                value: "09743227-29da-4385-9360-c7c10af68dc8");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 13,
                column: "ConcurrencyStamp",
                value: "4e20c90f-cc4b-49bf-a539-d15660b39192");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 14,
                column: "ConcurrencyStamp",
                value: "b4aa988d-6706-4be3-9cc1-8be2d6c88b1a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 15,
                column: "ConcurrencyStamp",
                value: "e9ccfc80-0e91-46c7-86a1-650b5126022a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 16,
                column: "ConcurrencyStamp",
                value: "48142eba-2480-4e24-8b25-6c42aa0b2e3b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 17,
                column: "ConcurrencyStamp",
                value: "8d34638b-f07b-442d-8e6a-488c5359802b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 18,
                column: "ConcurrencyStamp",
                value: "a3186bf1-2449-4b4e-a703-69b7f3ebeb2a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 19,
                column: "ConcurrencyStamp",
                value: "f5407960-318d-483f-8a10-f5b3ed23b2c9");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 20,
                column: "ConcurrencyStamp",
                value: "83cfdf00-f85c-4dad-96ee-cc2e2772d90c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 21,
                column: "ConcurrencyStamp",
                value: "9a55bda6-8622-453f-86e5-7d41976d4c88");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 22,
                column: "ConcurrencyStamp",
                value: "4a192c9f-cf10-4538-853e-9962fe7f2a3f");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "92d2b01c-5d3d-4844-ab34-2609243fe6f5", "AQAAAAEAACcQAAAAEFSMhz+ixvlkHrrJ3WS0gmuFvat7hGY8cxx4K5XNtM9ByzlvfeX3SdIsXJFxrb/qyA==", "5e1a6254-c12a-4a7b-8ea0-27c4ba4f6241" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bfd4bf42-f843-4596-9a3a-50fdfd13bc56", "AQAAAAEAACcQAAAAECGxOcBlnefIqBTiP2IPIJvya+jCc/xsu0NpSI1xAOb6SnQIauuSoiPnLPRnB2ZlWQ==", "d39023f9-93c0-4348-adf6-af18a9c7488a" });
        }
    }
}
