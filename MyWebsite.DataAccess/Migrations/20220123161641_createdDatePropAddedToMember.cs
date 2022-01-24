using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyWebsite.DataAccess.Migrations
{
    public partial class createdDatePropAddedToMember : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Members",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Newss",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 1, 23, 19, 16, 41, 217, DateTimeKind.Local).AddTicks(4197));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "09e26103-46e8-44fb-b03e-fa5460927947");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "fac47467-bd36-4407-b340-3a2766729427");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "46a708a2-0b09-483e-8848-6a45414a4153");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "198f51e6-24b4-4525-b877-7c4843da977c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "03332b3b-2280-448a-928e-fc6b0dd3d4c8");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 6,
                column: "ConcurrencyStamp",
                value: "6c33be9a-77a9-47c5-a6b3-7e93805650e2");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 7,
                column: "ConcurrencyStamp",
                value: "f8cef4fc-ddec-4e3f-9efe-34469827ec1d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 8,
                column: "ConcurrencyStamp",
                value: "c851fd91-578a-4727-bec1-12ab6ac1a7d3");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 9,
                column: "ConcurrencyStamp",
                value: "78d8d901-6e49-4723-846f-98459f99addf");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 10,
                column: "ConcurrencyStamp",
                value: "d00aab55-f159-49fe-a5b1-862b67e5930f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 11,
                column: "ConcurrencyStamp",
                value: "5d625e09-ddc7-442f-b2b3-3e17d05e0f66");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 12,
                column: "ConcurrencyStamp",
                value: "89d6d41a-2e9f-4503-944c-267233c8415f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 13,
                column: "ConcurrencyStamp",
                value: "c63943dd-c200-4984-bb81-4ce9605aab68");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 14,
                column: "ConcurrencyStamp",
                value: "b3afce3c-cfc6-4af4-a7cd-0d7c1a49202c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 15,
                column: "ConcurrencyStamp",
                value: "9794a09f-e367-41b7-9b20-f32c23fead19");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 16,
                column: "ConcurrencyStamp",
                value: "31be297f-fbde-4e0a-ab62-cdb2be9e1b49");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 17,
                column: "ConcurrencyStamp",
                value: "9195947c-e12e-4694-a94a-b9c693319357");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 18,
                column: "ConcurrencyStamp",
                value: "e36e4b91-dbc7-4277-a8cd-e9571ed9f199");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 19,
                column: "ConcurrencyStamp",
                value: "fdc48386-1206-4c62-b9da-ef3ae5275786");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 20,
                column: "ConcurrencyStamp",
                value: "383e8ca2-9886-426d-b1a0-f7796bc0420e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 21,
                column: "ConcurrencyStamp",
                value: "d070ec9b-7428-485a-ac33-c89220da0df2");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 22,
                column: "ConcurrencyStamp",
                value: "171451ea-478b-4d37-a543-0d7a30c26ec3");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2c97a6e2-f82f-4aa0-aae3-14cbb88028af", "AQAAAAEAACcQAAAAEOqqL0K0rTxxEsm0zNffgMj+ZIuwVNTDq8bbzwQgKqdxg/Fq9Qpdv1C2LAORrZmkEw==", "1ad17cde-1ea5-475d-b0d4-e4c4c19d4cd1" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b6342ddb-e77c-4e14-b956-bc440c809bbb", "AQAAAAEAACcQAAAAEE0JBTn1tRp+7Q7S0Kc96DaDte7rjvL3ZSb//5aMTnL9su4WUi3vng2GoCu/w+z+2Q==", "41cccd50-3d88-4692-b849-26db7a45ecfe" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Members");

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
    }
}
