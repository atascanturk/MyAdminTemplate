using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyWebsite.DataAccess.Migrations
{
    public partial class namePropAddedToMusicEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Musics",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Newss",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 2, 3, 0, 47, 0, 96, DateTimeKind.Local).AddTicks(6071));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "84ac487e-c597-4aaf-9c8a-c19db9a63a24");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "a08fac8f-43ad-4a8c-8603-d5de696bb8b0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "f07a14c7-47e3-44b3-aef4-84163e95563b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "8c1ea8e0-956f-4dde-a7ca-6c59ec5ba193");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "a15c7234-5bb0-4ca4-99b0-554f18e11100");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 6,
                column: "ConcurrencyStamp",
                value: "0f3721db-a0c4-46ed-928c-c742bd85c633");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 7,
                column: "ConcurrencyStamp",
                value: "493777be-f9df-4e7a-93c8-e1bbc43918de");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 8,
                column: "ConcurrencyStamp",
                value: "89ac4e0d-39d2-46d9-a0ee-bda627ddddb4");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 9,
                column: "ConcurrencyStamp",
                value: "a2471f36-e955-477d-b4dc-8a6b203a2bf8");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 10,
                column: "ConcurrencyStamp",
                value: "5b628577-53a4-4476-b356-5dd0a406c5cc");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 11,
                column: "ConcurrencyStamp",
                value: "502941be-c4c3-412f-942d-5713d298ab03");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 12,
                column: "ConcurrencyStamp",
                value: "453a56af-9554-4464-96ca-98193f802388");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 13,
                column: "ConcurrencyStamp",
                value: "20af92ae-9b75-480b-8981-6a4e748edd35");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 14,
                column: "ConcurrencyStamp",
                value: "899aa43c-cbb9-45f1-b1b0-e6ad7c25c27c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 15,
                column: "ConcurrencyStamp",
                value: "cf3cd75a-5244-491f-9b43-31fead3f57a0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 16,
                column: "ConcurrencyStamp",
                value: "8e419245-2a27-411d-b036-51e59cfb0d69");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 17,
                column: "ConcurrencyStamp",
                value: "3b0d47af-61fa-4612-9707-1e152c8e0ac4");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 18,
                column: "ConcurrencyStamp",
                value: "18b78fa8-70f1-41b1-bace-f38aebed69c9");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 19,
                column: "ConcurrencyStamp",
                value: "53ac004c-3925-44f0-8c10-dee1e6866b05");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 20,
                column: "ConcurrencyStamp",
                value: "390b5a18-d1ff-4813-90ee-edc96a878d8c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 21,
                column: "ConcurrencyStamp",
                value: "4f9e4537-c12a-40a5-93ed-84d9d36ce6cf");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 22,
                column: "ConcurrencyStamp",
                value: "0951665a-3703-4acc-b1ef-55fd2b2ca8d7");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3ebdb030-c2ec-4f3c-b724-eab69319e892", "AQAAAAEAACcQAAAAEBuGL5tlOxVkDUgd6K76950Sb5cTWj4zsFV/UrOzKypJ60mPhd1dPKbxJtz09f0pbQ==", "9491a18f-a4d9-4e28-9863-5d43ea01b06e" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5d94ac2f-ff12-4519-8f29-32bbba974430", "AQAAAAEAACcQAAAAEILZGQ/iN93wHUubr6LF1vAO3fJUxsgHh9XTuYKHVBk280qq38YXkqk4KzYAfCcpYw==", "936bb9e4-4d2c-44aa-b7b0-26e336335b8a" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Musics");

            migrationBuilder.UpdateData(
                table: "Newss",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 2, 2, 23, 23, 34, 427, DateTimeKind.Local).AddTicks(7697));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "7cb69cdf-fb0e-4b0a-8300-4bca33639f8e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "16050512-7cb0-41cf-a712-2cb86ea8e0dc");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "50eb1e7e-bf2a-4d18-b9ed-e5edbdf59c5e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "90a0544d-39ab-42c3-8360-d2978841a495");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "cc6dba36-be3f-4934-ab94-15147bb4673e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 6,
                column: "ConcurrencyStamp",
                value: "3f163fb6-1383-4958-9aad-f1e1440929f1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 7,
                column: "ConcurrencyStamp",
                value: "1dc7af9e-009f-4233-8350-e279f84a5ead");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 8,
                column: "ConcurrencyStamp",
                value: "97976c80-eb56-4071-9657-840204220e0f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 9,
                column: "ConcurrencyStamp",
                value: "fb238164-fbfb-43fc-ad68-b5904e5a5068");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 10,
                column: "ConcurrencyStamp",
                value: "4ed850c7-87d3-46cc-8c28-231081db4afa");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 11,
                column: "ConcurrencyStamp",
                value: "fd819cba-69ca-481a-8fce-30ed1fd59a42");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 12,
                column: "ConcurrencyStamp",
                value: "37292b08-db57-4d17-bfe5-5d19d58aa2c4");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 13,
                column: "ConcurrencyStamp",
                value: "1d7f973c-5158-4b77-bb77-e2bfe0fc725f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 14,
                column: "ConcurrencyStamp",
                value: "d66d1044-fb42-426f-b639-0b8ba8f70143");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 15,
                column: "ConcurrencyStamp",
                value: "8856acfe-b038-4dcf-9c78-2f957309476b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 16,
                column: "ConcurrencyStamp",
                value: "d0dbef8b-e1f7-417c-9389-e01b662406a2");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 17,
                column: "ConcurrencyStamp",
                value: "2d7f0bce-a577-4989-a73b-a600991b98de");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 18,
                column: "ConcurrencyStamp",
                value: "681ee4c5-8b66-46c9-bd30-d174a026383a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 19,
                column: "ConcurrencyStamp",
                value: "89a00cb3-fd03-4d72-9128-0d9cca353d13");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 20,
                column: "ConcurrencyStamp",
                value: "85657898-31f0-40a6-b59f-837a8e64aa94");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 21,
                column: "ConcurrencyStamp",
                value: "7701133c-1c4a-48b0-9008-b86ac519cdfe");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 22,
                column: "ConcurrencyStamp",
                value: "8fcd4ee1-3137-4d33-a7b1-acb47c612071");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1a5b5ae8-ae94-4be4-bea7-3707ece624bd", "AQAAAAEAACcQAAAAEMnGG9CwBn6ZOTnn4kvoAYi+n45val48275t40Ks59W7ssOtUmv3Nfab3ROJnYc52g==", "4e97520a-21d8-485f-83ca-b7dcad73f1be" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7f226c33-decf-402a-b7dc-f35351649734", "AQAAAAEAACcQAAAAENxSarvE1fi3KGeOWuYIi3DhuWNyDni4Jo+T8Ogt0SLRc8rNIq3qAAPOjfLbqv52Tg==", "e7f5c2ad-aa87-4aa9-aa31-098d1aaa48d0" });
        }
    }
}
