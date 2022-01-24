using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyWebsite.DataAccess.Migrations
{
    public partial class visitorCountEntityAddedAndCategoryTypePropAddedToCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoryType",
                table: "Categories",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CategoryType",
                table: "Categories");

            migrationBuilder.UpdateData(
                table: "Newss",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 1, 21, 1, 0, 56, 885, DateTimeKind.Local).AddTicks(7540));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "0e34a5ab-20d1-4521-922f-2b0b63168077");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "02bd2b59-b0ff-44a1-8829-8738ce15060c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "76e57237-0cb2-4831-9d61-6fe911d353aa");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "66714192-627a-4a78-91ac-4b149aab7366");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "1591efda-9a93-43d5-8e4a-75ea4aff942f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 6,
                column: "ConcurrencyStamp",
                value: "c8fd9c83-ab78-48c2-8e39-1b825bdae3c4");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 7,
                column: "ConcurrencyStamp",
                value: "319d5b5d-a08c-442d-9096-07207472763b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 8,
                column: "ConcurrencyStamp",
                value: "9b5fd1c9-3545-4d74-9e60-c3403f8a3691");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 9,
                column: "ConcurrencyStamp",
                value: "05fb3577-b239-4b9f-89e3-1cd36763f1b1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 10,
                column: "ConcurrencyStamp",
                value: "6cb2484d-38ad-4007-9ee3-ad9b533fca8b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 11,
                column: "ConcurrencyStamp",
                value: "e4773461-d872-4ae0-b361-f14bc840ba16");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 12,
                column: "ConcurrencyStamp",
                value: "e50c9bac-193f-4253-8b37-9a9fc6ef191a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 13,
                column: "ConcurrencyStamp",
                value: "90f4d1f8-716b-46b8-8d46-144df44a343b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 14,
                column: "ConcurrencyStamp",
                value: "7ef90d51-a4e2-4e81-95e6-92f7a26a317f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 15,
                column: "ConcurrencyStamp",
                value: "0467f2c6-e9c9-44c8-930b-f2b5bf958959");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 16,
                column: "ConcurrencyStamp",
                value: "5744cc40-1cc7-4c6c-b837-f6f4bdfd7dde");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 17,
                column: "ConcurrencyStamp",
                value: "731adf4e-36e9-40ee-b5cc-2d92650bfcd6");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 18,
                column: "ConcurrencyStamp",
                value: "ef762575-2693-40c1-94ee-fc8ed7d253e3");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 19,
                column: "ConcurrencyStamp",
                value: "a2024788-facd-46b1-8d4f-99ea8dfcafe8");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 20,
                column: "ConcurrencyStamp",
                value: "2f724892-e4d5-4200-bd09-90f9bb547a22");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 21,
                column: "ConcurrencyStamp",
                value: "155be80e-4e8b-450f-b8be-d1ec03711765");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 22,
                column: "ConcurrencyStamp",
                value: "7d53e1f4-2540-400d-9712-0978454db5af");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c4999a64-9b43-4298-92ab-9f7654045c53", "AQAAAAEAACcQAAAAEE0EIu1pbFnH/2f0orPbrTdemeHU/EsFJyTTCeOMC/oGvuPiW7EcgvZjKeO8IZQkuQ==", "6dfa2d81-81c2-4763-8cbf-448d5e10c983" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "506e679a-2b57-4aa4-a4e5-87777055f694", "AQAAAAEAACcQAAAAEBqo8VRgJtim+B09Wr99GoP6/nRGqf/ANM6fdDyZAfaEoxJl92htzgQcSd8fdGnTSA==", "d9471354-53f2-4cc2-ad00-5c4d9e6af1c8" });
        }
    }
}
