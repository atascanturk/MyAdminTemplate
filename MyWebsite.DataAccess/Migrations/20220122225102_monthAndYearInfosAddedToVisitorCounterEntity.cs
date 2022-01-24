using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyWebsite.DataAccess.Migrations
{
    public partial class monthAndYearInfosAddedToVisitorCounterEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Month",
                table: "VisitorCounts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Year",
                table: "VisitorCounts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Newss",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 1, 23, 1, 51, 1, 610, DateTimeKind.Local).AddTicks(9779));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "e9802515-70ee-492e-95bc-5c4656cdcf95");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "0fef3706-75f7-4011-b522-1de2604b99f4");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "9031429f-138a-4c25-be7a-e2eb05fd6bc7");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "37fa4dd0-3def-4c9d-a1a9-8732057cdfde");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "5d86ebcc-d819-4ff1-a8fa-f3af5a2f54e4");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 6,
                column: "ConcurrencyStamp",
                value: "705c2d53-f7be-47f4-8f5f-e6da03c67140");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 7,
                column: "ConcurrencyStamp",
                value: "2feb0b70-b807-432c-9271-5fdbd3a3ff0f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 8,
                column: "ConcurrencyStamp",
                value: "1d5d7827-a3fe-47c6-9f6a-a6930da0234f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 9,
                column: "ConcurrencyStamp",
                value: "4a8eadd5-8840-46dd-8907-d3106276b7b7");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 10,
                column: "ConcurrencyStamp",
                value: "57d0e29e-e488-42e1-bc0c-edffae30357f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 11,
                column: "ConcurrencyStamp",
                value: "1c89f820-b6c3-4751-90b2-1b8c8419f295");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 12,
                column: "ConcurrencyStamp",
                value: "7dc37087-8a21-486c-be12-fcaddfcd8f9a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 13,
                column: "ConcurrencyStamp",
                value: "2a304fd6-3fc2-43ff-96a0-887b03b5c626");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 14,
                column: "ConcurrencyStamp",
                value: "9b8be8b0-4ef9-4641-9ee2-b4c935173380");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 15,
                column: "ConcurrencyStamp",
                value: "0e5ebd81-f798-4fc5-960f-fc7147a0c6e9");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 16,
                column: "ConcurrencyStamp",
                value: "f6f5e489-f5ed-4f56-bb90-c16da319322f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 17,
                column: "ConcurrencyStamp",
                value: "df0ac3b7-19a1-4482-ba00-8a331b0a7a3b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 18,
                column: "ConcurrencyStamp",
                value: "45f32fa9-ca72-40af-bf9d-e5e9995104d4");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 19,
                column: "ConcurrencyStamp",
                value: "bcce833f-c8c4-44ec-aecd-fe5f2d66b254");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 20,
                column: "ConcurrencyStamp",
                value: "49c995bc-55d0-4e7b-8026-b31439b78c99");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 21,
                column: "ConcurrencyStamp",
                value: "ac7a1de3-92db-4e8b-9908-e58849316b0b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 22,
                column: "ConcurrencyStamp",
                value: "30a58521-3421-4389-ad88-a764ac15aaf9");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "df66c6e2-eec2-48e7-b54b-3e99c0025c73", "AQAAAAEAACcQAAAAEA8/ibZs6cjmKVifBcGsOWsX2hbNs+4fZ+y9P6BSok+3MSoSSoLXzknOyYL9RLRAhw==", "8cad5b73-aec7-4447-9b20-e41c87300d99" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a8885789-6eae-464e-998f-72770152f11e", "AQAAAAEAACcQAAAAEIMO96lylNvUejKBeIVTrZw6KmfA9U2BvMW2SGlJIJhWVRVYAeQqFfMcj7crmmZc4Q==", "fb14edbc-4c9a-40c6-91c3-abc737574e85" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Month",
                table: "VisitorCounts");

            migrationBuilder.DropColumn(
                name: "Year",
                table: "VisitorCounts");

            migrationBuilder.UpdateData(
                table: "Newss",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 1, 22, 22, 30, 52, 214, DateTimeKind.Local).AddTicks(110));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "693039e5-16b9-4e72-9de6-64240d5d263b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "4c297912-2eb8-4dad-8328-05bb5e703af1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "0751e6a1-9bef-4066-975f-d21183e86ab0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "3a15906e-08a3-4e82-8e55-e7907266671b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "5780f473-94e7-4b8d-9f6d-9d0a1844739d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 6,
                column: "ConcurrencyStamp",
                value: "16b46a74-97f3-4b98-b5cc-92cba9bbc27b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 7,
                column: "ConcurrencyStamp",
                value: "aa70452b-ded0-4d98-88f6-91b14cf5aa0d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 8,
                column: "ConcurrencyStamp",
                value: "b97cc50b-aed1-4b23-b7eb-e096bbae15e9");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 9,
                column: "ConcurrencyStamp",
                value: "06528fec-8b5b-4b24-b1ac-8ed77ec1989d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 10,
                column: "ConcurrencyStamp",
                value: "9419cf0a-3c4f-4da7-810e-cb0ccab80678");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 11,
                column: "ConcurrencyStamp",
                value: "e92cb92b-198a-4f91-a3d0-94635e73c636");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 12,
                column: "ConcurrencyStamp",
                value: "f62c0903-226f-4bdb-8cfe-7ad5d6fa60f0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 13,
                column: "ConcurrencyStamp",
                value: "b6f96a7b-8ecd-4494-a46a-451f1ccbc28d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 14,
                column: "ConcurrencyStamp",
                value: "2009565f-d44b-4e7b-ba86-679cf4fdc39a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 15,
                column: "ConcurrencyStamp",
                value: "e10f3327-8522-487e-b7ca-138a8af367bc");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 16,
                column: "ConcurrencyStamp",
                value: "d1999fa7-44a8-4599-a8ee-18a235c9d745");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 17,
                column: "ConcurrencyStamp",
                value: "147bbe54-ee20-497c-8649-679c9c29855a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 18,
                column: "ConcurrencyStamp",
                value: "2122a264-31ac-4a83-a06f-c8dfcb554280");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 19,
                column: "ConcurrencyStamp",
                value: "325c0967-aa71-4aeb-a642-df8784d40269");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 20,
                column: "ConcurrencyStamp",
                value: "98f9096d-f4ca-407f-99c6-72f70f2935b0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 21,
                column: "ConcurrencyStamp",
                value: "09455e32-7bb3-4219-bd73-9c0cb0d8e215");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 22,
                column: "ConcurrencyStamp",
                value: "3ddbb1c7-24fc-45a3-a69d-73f29d870691");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2925dfd1-fb2a-4300-97e6-89fc8cdab698", "AQAAAAEAACcQAAAAEIIQ6QgdTezVZW0Mgvw9sJoxOxcGc+LwxfiJJMKME94qckbu+f/dE4fzE0Hj+BlRtQ==", "504aef58-4aec-4489-ab8a-b8edb8a7305e" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e03053ff-5afd-4094-99b6-ac8a725b1d1b", "AQAAAAEAACcQAAAAECpEKRKXKjeQD+ckpTdZaXaKvRXedtYASAFU11Na9Xdh1uGSdtIdWF8cLiedjOtbEA==", "2adaf20f-8ee4-43dd-97be-12299e8e3361" });
        }
    }
}
