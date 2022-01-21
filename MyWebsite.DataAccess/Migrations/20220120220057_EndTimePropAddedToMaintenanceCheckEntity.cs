using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyWebsite.DataAccess.Migrations
{
    public partial class EndTimePropAddedToMaintenanceCheckEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "EndTime",
                table: "MaintenanceChecks",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EndTime",
                table: "MaintenanceChecks");

            migrationBuilder.UpdateData(
                table: "Newss",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 1, 20, 22, 32, 28, 673, DateTimeKind.Local).AddTicks(1713));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "c8425d74-11f3-4673-bf7d-694214acb0e7");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "19031b6b-aa08-462f-bf38-8cc2e1cf6a1c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "135d50d6-4d85-4827-bf3a-6c81895601ab");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "a65b5180-5741-47da-9736-5d2c37e679a9");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "38e94084-56ae-498f-b774-a5fff14819a1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 6,
                column: "ConcurrencyStamp",
                value: "b130a183-49ae-439c-b906-8f97d3f1d4de");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 7,
                column: "ConcurrencyStamp",
                value: "9e7b8a61-1226-4f28-81d1-d7b5357c6119");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 8,
                column: "ConcurrencyStamp",
                value: "3ab59f43-57ea-49c7-bb1f-18dd722686b8");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 9,
                column: "ConcurrencyStamp",
                value: "2fdbaf59-c4c1-4397-b752-1544e587a0a5");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 10,
                column: "ConcurrencyStamp",
                value: "f5ce87b8-04c5-4292-981c-8e18f0758d94");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 11,
                column: "ConcurrencyStamp",
                value: "888abe47-7142-4d10-941d-72fcb709977a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 12,
                column: "ConcurrencyStamp",
                value: "c7ee9304-8981-4ce7-8c7a-50c15012042e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 13,
                column: "ConcurrencyStamp",
                value: "4a9f0802-f2db-4e08-a013-dc09e5a566ee");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 14,
                column: "ConcurrencyStamp",
                value: "fb72b134-47b7-4a02-ace4-1f44e16749c0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 15,
                column: "ConcurrencyStamp",
                value: "2c76536d-44c5-4c6f-937b-b9df4fb628a6");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 16,
                column: "ConcurrencyStamp",
                value: "02b18bcf-bf74-4fe5-b5fd-be900ec7aa5d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 17,
                column: "ConcurrencyStamp",
                value: "8f9121d2-44c0-46ec-80a1-0b0246dc14cb");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 18,
                column: "ConcurrencyStamp",
                value: "42733a78-a709-46d2-96b2-e9afbb8283d8");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 19,
                column: "ConcurrencyStamp",
                value: "9fb09920-b0e2-42a7-a033-ee9164c009fe");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 20,
                column: "ConcurrencyStamp",
                value: "4cda768f-dbb9-4e87-bdec-13e7c077ea28");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 21,
                column: "ConcurrencyStamp",
                value: "3e2542ec-b38f-4bf3-9342-c30d45effde1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 22,
                column: "ConcurrencyStamp",
                value: "f4e407ab-d7cd-4c47-bbcc-1275cd48fce8");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8622a519-486e-404c-9acd-27244ec3e9fd", "AQAAAAEAACcQAAAAEKwAwB+38jf+tfFlmSs5rYq8Us9woPtBvH3lrKR5nKXgp++wcDI978PAMS/aGCKknQ==", "a002cdd7-5323-4544-80d6-989e870188f9" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8baf9f61-2ad2-436b-bc88-3c220a61efb0", "AQAAAAEAACcQAAAAEJ60U1v38Tms/BlkBqlT6leUCRLkp5wZvB+BacNGo2EVkzmRhB5qnWnOmYwMltja5A==", "b847c14f-8c91-4ec1-94da-874a09ebfb0f" });
        }
    }
}
