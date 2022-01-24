using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyWebsite.DataAccess.Migrations
{
    public partial class addVisitorCountEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "VisitorCounts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Count = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VisitorCounts", x => x.Id);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VisitorCounts");

            migrationBuilder.UpdateData(
                table: "Newss",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 1, 22, 22, 6, 45, 486, DateTimeKind.Local).AddTicks(4804));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "ab56560a-fb48-4191-9b96-814fda57cd63");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "38d38538-fbb1-44ef-b94e-bfcd75a9a343");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "cbb1be4b-f2b6-411b-81ee-e56839780df5");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "45238a64-8b3f-4723-8052-39d387c1a0b3");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "b9ec1d9d-89ba-4da7-ac9e-8064eeeca426");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 6,
                column: "ConcurrencyStamp",
                value: "2c2304d7-6773-4dfd-a4ae-c26dfa1cdf34");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 7,
                column: "ConcurrencyStamp",
                value: "7d49b270-4512-47b8-81c5-8fb4a025bfaa");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 8,
                column: "ConcurrencyStamp",
                value: "c0f8daff-0937-43d5-b500-edba6caa5999");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 9,
                column: "ConcurrencyStamp",
                value: "8388054d-9ede-4683-938e-21dcf42dd964");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 10,
                column: "ConcurrencyStamp",
                value: "df540d83-a84a-426b-8cdd-e4cac5e86a90");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 11,
                column: "ConcurrencyStamp",
                value: "07da90f9-4f16-4ce2-a684-87ffefff1413");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 12,
                column: "ConcurrencyStamp",
                value: "9abce308-e904-45f1-a1e1-a2d485621d2d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 13,
                column: "ConcurrencyStamp",
                value: "de20c33e-4d4f-46bd-8a8c-6dc57b1f36cd");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 14,
                column: "ConcurrencyStamp",
                value: "c98a261e-c8e2-4931-bd1b-3760ee150c06");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 15,
                column: "ConcurrencyStamp",
                value: "a1e6d63f-aeb2-4e5b-9cc0-14da467dbde1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 16,
                column: "ConcurrencyStamp",
                value: "e6fbd5ec-e55a-468e-a538-8b8ba3d5fbfd");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 17,
                column: "ConcurrencyStamp",
                value: "f34ee28d-85bf-4b09-a53f-2f02c00f825f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 18,
                column: "ConcurrencyStamp",
                value: "d28481ce-ce77-4c79-8eae-aafa430fc3ec");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 19,
                column: "ConcurrencyStamp",
                value: "f5587ddf-335e-49c6-8965-312d94fe6a31");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 20,
                column: "ConcurrencyStamp",
                value: "7a255be5-aa28-4091-8505-10aaf507161d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 21,
                column: "ConcurrencyStamp",
                value: "32493d5f-263f-49e1-8fc1-43801c4d7d53");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 22,
                column: "ConcurrencyStamp",
                value: "2063322e-c016-4e1d-8e56-6d93f1049751");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0eb6d514-b484-4e16-b6ae-f8efe843eb7c", "AQAAAAEAACcQAAAAEJ7CuKUei5KVcRl6gzJlgSGn2ZLwHk6u1gk0+zCwWsgRBo2wA5j1R6Aowql9Sub3gg==", "3e31336b-d1dc-4857-b680-66d5a643d049" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "78e11f35-be67-4c42-b9a4-82ed11a722a6", "AQAAAAEAACcQAAAAEMxg1ZT0cO6nF4/xTsSL2q4smETeYiNA8GVMkmQEwoH7lkjjF2rVEp2Roc7509x3EQ==", "c377f3ef-65ff-4ff1-b42e-8cb570197468" });
        }
    }
}
