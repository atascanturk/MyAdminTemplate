using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyWebsite.DataAccess.Migrations
{
    public partial class updatedDatePropAddedToSEOEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "Seos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Newss",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 2, 10, 0, 36, 50, 315, DateTimeKind.Local).AddTicks(9382));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "6d4b3994-4bc5-43ae-9dc2-3f81bd26605c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "6632d9b1-1fc8-4856-9292-64bba0cbb528");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "de1e5b44-e775-4b85-b7b2-9630f1883084");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "cb0b20c3-bd27-4e43-8334-16a9ea113b0d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "fe82874d-2c4e-4cec-a3cb-4f7febf1e2c7");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 6,
                column: "ConcurrencyStamp",
                value: "a002984e-c4a8-4f84-ac0a-e30e860ac0c6");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 7,
                column: "ConcurrencyStamp",
                value: "d5f1d8b4-b022-4a16-9e4b-cbebb9208c0a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 8,
                column: "ConcurrencyStamp",
                value: "7ce95c4d-e92c-46b1-8fcc-e2c303f00f22");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 9,
                column: "ConcurrencyStamp",
                value: "df030be1-d9bb-496a-8bc6-af24312947ba");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 10,
                column: "ConcurrencyStamp",
                value: "4f9173c0-d5be-4d91-8c8a-7fb3536bab07");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 11,
                column: "ConcurrencyStamp",
                value: "fcad518c-2595-46ba-bab3-b3c5b751916d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 12,
                column: "ConcurrencyStamp",
                value: "179b6583-2cf5-4cdb-8ebc-a63f31bfd406");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 13,
                column: "ConcurrencyStamp",
                value: "212d38b7-5da9-4dbf-85e3-490150afc195");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 14,
                column: "ConcurrencyStamp",
                value: "09bb419f-0fc5-451b-b280-a8424ddb33a6");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 15,
                column: "ConcurrencyStamp",
                value: "3d0096b7-ba33-4159-bab7-9dd1cc68f12c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 16,
                column: "ConcurrencyStamp",
                value: "1057362c-dd44-4989-aeb7-f0516439ea30");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 17,
                column: "ConcurrencyStamp",
                value: "be9f7ee5-7f75-4197-b240-da8b7690b8a6");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 18,
                column: "ConcurrencyStamp",
                value: "30a06a1c-21c1-468e-aa80-24e038a0879b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 19,
                column: "ConcurrencyStamp",
                value: "a183ffcb-aa16-4b5d-a912-13622903dc39");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 20,
                column: "ConcurrencyStamp",
                value: "1d032907-d750-45b8-89e4-805c35ff036e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 21,
                column: "ConcurrencyStamp",
                value: "aa44ff5f-d123-49c3-9313-2101e74460d5");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 22,
                column: "ConcurrencyStamp",
                value: "1330135b-6e56-4faf-945a-b866f2649b2d");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f45fd87a-de38-4a69-87cd-91c39ecdf56e", "AQAAAAEAACcQAAAAEMekW4u5CRcqRrfSFMLq4WgiSyFV2qlTzGCEF4DnoKzokXmnbBwL/C1lqIArMVeoaQ==", "fd38b296-e2f6-4827-8c6a-c30a3fb5ec4a" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e5407a11-7a1e-4dae-a6eb-16790c099f29", "AQAAAAEAACcQAAAAEKbSg8JYfhYynkj8ac/ijGjIcGtDX0S2NL1XkZBLmanoEAyMFRpE0hx5i0bDjj6Hww==", "0a020a61-0841-436e-a8e4-05a95c2ea787" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "Seos");

            migrationBuilder.UpdateData(
                table: "Newss",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 2, 4, 22, 7, 42, 213, DateTimeKind.Local).AddTicks(7877));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "69873c70-217d-43b2-b2a4-5b82ca1109a4");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "ab31034c-bfb2-413f-a765-2b91aea9cac9");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "5f2ff50a-5c6d-4624-a250-42b7a59078bc");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "370caef0-53a7-499c-8e16-57203786adec");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "a2c357b2-e0bc-459e-936f-8224bbab96a9");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 6,
                column: "ConcurrencyStamp",
                value: "929721d6-dfcc-4dd4-9973-5979374459a4");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 7,
                column: "ConcurrencyStamp",
                value: "1b22b622-7be3-4d13-8c99-3a3c91f866cd");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 8,
                column: "ConcurrencyStamp",
                value: "1edfabbd-ea35-483f-aaa6-70bc6b8a3a62");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 9,
                column: "ConcurrencyStamp",
                value: "54457056-4734-47de-ae01-e42f5331748a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 10,
                column: "ConcurrencyStamp",
                value: "f9e8418f-cbc5-4a7f-8c0a-4e571e606ee2");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 11,
                column: "ConcurrencyStamp",
                value: "38cbc9fd-7576-49c6-a574-d6195e28c814");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 12,
                column: "ConcurrencyStamp",
                value: "3c981b5f-c9e2-434c-b398-9e280b15adf9");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 13,
                column: "ConcurrencyStamp",
                value: "828cfb12-aeb5-4a99-ad8f-8cca90309afc");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 14,
                column: "ConcurrencyStamp",
                value: "4f126750-6dbd-4302-8d6e-fe585f746cce");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 15,
                column: "ConcurrencyStamp",
                value: "20160835-7db7-4e63-9ac6-732e1949b6cc");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 16,
                column: "ConcurrencyStamp",
                value: "b8cbe0f3-54b6-418c-874f-db84ec0207cb");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 17,
                column: "ConcurrencyStamp",
                value: "a554e194-418b-485c-86ae-186eac7f3b1a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 18,
                column: "ConcurrencyStamp",
                value: "5caf99c1-e949-4f90-a73a-9b03f0f0fd2c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 19,
                column: "ConcurrencyStamp",
                value: "8344e5d9-e0b3-4d9d-b30c-9e9924c05584");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 20,
                column: "ConcurrencyStamp",
                value: "fe4d5934-8aa5-4888-832b-4e2d64ae8563");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 21,
                column: "ConcurrencyStamp",
                value: "fbbe885b-8689-4b85-861c-0cfb4cb845b4");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 22,
                column: "ConcurrencyStamp",
                value: "933d3e2e-bbed-4e53-a656-6ae57bfdc344");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cfb274a5-c352-4e85-a615-bd492daad3ce", "AQAAAAEAACcQAAAAEJ/NEVwxkYDooD1PIDsalmb6l9uGo+SynXLi3UNQ5yJv6ecgBU350hab4v6yT6yo7A==", "8628f76b-9b59-4b0b-9d08-0a6075083e32" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ef243144-8bae-4887-a535-942d3d485825", "AQAAAAEAACcQAAAAELTyFfFzB1hQ9/6SlUpOC8OPmnybDCXcQP4frpXx+wFargIpVOX1PCN6VIAYeOZFxQ==", "d5a6b65b-49f5-4f84-960d-b8b3f38e8cb9" });
        }
    }
}
