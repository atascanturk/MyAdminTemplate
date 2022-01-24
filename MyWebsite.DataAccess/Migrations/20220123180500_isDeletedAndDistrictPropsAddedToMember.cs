using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyWebsite.DataAccess.Migrations
{
    public partial class isDeletedAndDistrictPropsAddedToMember : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "District",
                table: "Members",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Members",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Newss",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 1, 23, 21, 4, 59, 953, DateTimeKind.Local).AddTicks(8148));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "908739d2-463d-4494-847e-b0c4cc8c6194");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "8e55aa74-cd4c-4bc2-b0ce-df4cd308c8ff");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "3cd19e56-fa52-47f5-ad3a-0104f226791c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "d13bdeb3-2f19-469e-8a84-dee91013f8e8");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "e851eb31-d262-456d-a59c-029f1d4ef231");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 6,
                column: "ConcurrencyStamp",
                value: "eb310d24-bf59-453a-85c6-bf68ab487974");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 7,
                column: "ConcurrencyStamp",
                value: "c75b08b6-3560-4356-8ed1-9878ca0796ef");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 8,
                column: "ConcurrencyStamp",
                value: "cdc6dc19-abdc-43d2-94c9-85d9bf6bd715");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 9,
                column: "ConcurrencyStamp",
                value: "a037f92f-7a06-497c-95ed-f5812c7eddf7");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 10,
                column: "ConcurrencyStamp",
                value: "67ab29f7-30fc-4f40-a13b-74f2e31accad");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 11,
                column: "ConcurrencyStamp",
                value: "5b7c6e4b-9e96-4fe6-91c6-76362f1c103f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 12,
                column: "ConcurrencyStamp",
                value: "599076d5-93b6-4b5c-b95d-1c2398c032c1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 13,
                column: "ConcurrencyStamp",
                value: "43d43c7b-416d-4171-9edc-d41d73c13f3a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 14,
                column: "ConcurrencyStamp",
                value: "98ef9ab3-464e-44e3-b0c8-e8b6428b1b1e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 15,
                column: "ConcurrencyStamp",
                value: "bfd819d4-5b1b-4ed3-b6b8-569dd0dc768b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 16,
                column: "ConcurrencyStamp",
                value: "960b4da9-bbc9-4ba5-a2d6-3abe5d5113dc");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 17,
                column: "ConcurrencyStamp",
                value: "34b24c15-eb33-4f32-9831-3254bda96c2e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 18,
                column: "ConcurrencyStamp",
                value: "6c229ba0-86a0-44ba-899e-1e4cdd7e5621");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 19,
                column: "ConcurrencyStamp",
                value: "4abe8193-e649-4819-ae69-fe7ad0487ca3");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 20,
                column: "ConcurrencyStamp",
                value: "c5596d16-9ae1-4bfb-9805-d83f6882df99");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 21,
                column: "ConcurrencyStamp",
                value: "492a7443-115e-4470-9d52-0adfbd9dbb5c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 22,
                column: "ConcurrencyStamp",
                value: "aeff2764-c15a-46ab-858f-c8f0f90fb8a9");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "61d81d39-91b3-4399-86cd-a0b151e0c016", "AQAAAAEAACcQAAAAEOM4ZlaXxEHKQ9v3+0K9Hhfon0tMi20/N+3E6G92P16uLK/Be+IvFYkUg1DSOcJphw==", "b75fda5c-18f6-4d24-a40e-b6a569f4308e" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "047277e8-7a17-4f01-bd7c-82521678e085", "AQAAAAEAACcQAAAAECHTXviZTwtsMhHa0gigauqoqpig8OtAQsLdFaEKLakmbGRd1iQ2jmItUCDlbC6teQ==", "f0208eb5-3315-4022-baf7-986539ba2336" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "District",
                table: "Members");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Members");

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
    }
}
