using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyWebsite.DataAccess.Migrations
{
    public partial class titlePropAddedToSliderEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "SliderImages",
                type: "nvarchar(max)",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Title",
                table: "SliderImages");

            migrationBuilder.UpdateData(
                table: "Newss",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 1, 24, 22, 4, 41, 738, DateTimeKind.Local).AddTicks(3752));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "459e8640-addb-4955-92eb-d402c6505ca1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "3f22cb61-ee03-4383-add1-074fa0bc1311");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "dbab6f5d-c1e0-4652-8be6-986c448a8625");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "e1157ea3-f7ee-420c-93ac-b13dca633553");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "d5828c72-28dc-4e46-afa3-3b3700b48811");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 6,
                column: "ConcurrencyStamp",
                value: "4b2b78bf-eddb-4bdf-9f0e-ed3157394472");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 7,
                column: "ConcurrencyStamp",
                value: "73609800-b11e-4d9d-9973-ace5eb650d36");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 8,
                column: "ConcurrencyStamp",
                value: "ce830675-f4cb-4d3d-a9d3-9f8a9f87a2fc");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 9,
                column: "ConcurrencyStamp",
                value: "b56d04d6-d38c-4bc1-bcf8-4f0d70fd8123");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 10,
                column: "ConcurrencyStamp",
                value: "55b2c993-c70a-40d5-ad1c-0f303b3ca03d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 11,
                column: "ConcurrencyStamp",
                value: "f550e11b-8cb9-4def-8144-228ebb1d5eb0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 12,
                column: "ConcurrencyStamp",
                value: "4bbc8286-85d0-45dd-93bf-3c7250605f21");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 13,
                column: "ConcurrencyStamp",
                value: "951466b0-d746-4d7c-a3a5-b9df242dae4d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 14,
                column: "ConcurrencyStamp",
                value: "b891654e-cc3e-41b8-af6d-5f7ecef5feb4");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 15,
                column: "ConcurrencyStamp",
                value: "69b7681e-a9e8-4531-80fa-fff8fc96f4b4");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 16,
                column: "ConcurrencyStamp",
                value: "92d03a01-e093-465c-8c68-5de689ef5870");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 17,
                column: "ConcurrencyStamp",
                value: "dbfab9fa-c2c9-4c91-8250-6710fa6e1e85");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 18,
                column: "ConcurrencyStamp",
                value: "49177405-5f2f-40dd-915c-6e55b6e38694");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 19,
                column: "ConcurrencyStamp",
                value: "d1c01649-4f11-472f-a016-db16732fa1f0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 20,
                column: "ConcurrencyStamp",
                value: "20fe2752-a114-48c6-8da0-a4a8d75adfef");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 21,
                column: "ConcurrencyStamp",
                value: "9087e3ce-f63d-4ecd-9bdd-96018a95f257");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 22,
                column: "ConcurrencyStamp",
                value: "f5499fdd-4787-4b2a-932b-23e7a44ffc8c");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "71f50cf4-295b-4437-a791-d8f1f071d8a8", "AQAAAAEAACcQAAAAECYOX5FM2xMLaLiLm274dvxwb1keQZcyxxbR0pv3YfgNn/k0S2gqptjT1gn+i7hm1A==", "28ceed01-cf1e-4dce-923e-ecf246be6055" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "97ddf80d-3abf-4938-9ca7-220c86e11b95", "AQAAAAEAACcQAAAAEF6Ji/ZFo58McLhdRCITc5kMsKzFJZ+HHWqaVKoDNYomGinnXADNj1//Sq/LIrfvVg==", "158c96bc-7609-4608-8d7e-afdd20bf0ed5" });
        }
    }
}
