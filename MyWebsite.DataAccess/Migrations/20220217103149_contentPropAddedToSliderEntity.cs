using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyWebsite.DataAccess.Migrations
{
    public partial class contentPropAddedToSliderEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Content",
                table: "SliderImages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Newss",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 2, 17, 13, 31, 48, 817, DateTimeKind.Local).AddTicks(9788));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "96440eb1-1d4a-46d4-b7a2-fae1cefa67c4");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "a8ea4364-e623-40e0-a9e3-e04cce241678");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "16520e4f-cf0e-4d6d-9f75-bf3e48241bd9");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "e2d94149-0e7d-4677-8a30-8f5e5a6c4fdb");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "807d57b8-abe8-4acc-8adb-b28b9919515a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 6,
                column: "ConcurrencyStamp",
                value: "af8d2d69-08da-407a-8a5f-87414c386e4f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 7,
                column: "ConcurrencyStamp",
                value: "4653dd33-b279-4abb-a219-1b072d18b785");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 8,
                column: "ConcurrencyStamp",
                value: "8f892ce0-c865-4dad-874a-03c38098550d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 9,
                column: "ConcurrencyStamp",
                value: "2419a716-0774-44dc-a60d-1f3982ee6354");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 10,
                column: "ConcurrencyStamp",
                value: "d11478a0-050f-47f1-8a2c-d09410b7f2e5");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 11,
                column: "ConcurrencyStamp",
                value: "088780a9-a11b-4d40-9f27-178768cb2b93");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 12,
                column: "ConcurrencyStamp",
                value: "909df92d-f68d-489c-b6a0-1f1365ead5d0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 13,
                column: "ConcurrencyStamp",
                value: "400d5cbb-8298-49ed-9d32-a75e072843ca");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 14,
                column: "ConcurrencyStamp",
                value: "cfc04b84-da93-44b1-bd59-dfeb836b8c48");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 15,
                column: "ConcurrencyStamp",
                value: "85633ef2-8c3e-4e9f-a84f-2a44ac9e5eb0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 16,
                column: "ConcurrencyStamp",
                value: "782223fd-484e-485d-9b0d-ec323ee4bec3");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 17,
                column: "ConcurrencyStamp",
                value: "8a4efb18-6736-48ea-80e6-5c121680077c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 18,
                column: "ConcurrencyStamp",
                value: "d5c3b591-475e-405e-81ea-8d89573f8ab0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 19,
                column: "ConcurrencyStamp",
                value: "22464a35-f994-4594-b5a5-84f23aac0be7");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 20,
                column: "ConcurrencyStamp",
                value: "5134fd1e-6c54-4a40-9dcd-cdc326431545");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 21,
                column: "ConcurrencyStamp",
                value: "8a44402b-4675-4b94-9589-a70105f54cc0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 22,
                column: "ConcurrencyStamp",
                value: "f2d07453-d5e4-4829-9bb8-3e81beb69fa5");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "223b06e9-ec46-469c-bd5d-769c6a8a44d0", "AQAAAAEAACcQAAAAEDq/N5tpx99MpXNDe6v1IGIOvsrLmeHr2b1g6xx3rQ7V+oTNLig4e1hosj3T+/0DEw==", "a707695d-2e4c-4556-a87e-c28d3028517c" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0d96a0f0-1d42-405c-8859-07be94fd9009", "AQAAAAEAACcQAAAAEDIHy0XUt4Cz7iMcwg6I/1ZBJQfdd/LDBkI6R5YE61H24yk2wHdld7EomJwaiLr91Q==", "4ae8e9d1-5ccf-43c0-8408-0318601df3ba" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Content",
                table: "SliderImages");

            migrationBuilder.UpdateData(
                table: "Newss",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 2, 13, 18, 20, 4, 925, DateTimeKind.Local).AddTicks(9050));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "eded5f09-3db7-420c-b63b-a75422ea97c8");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "037d3880-bcaf-4b73-a803-16cea9544b0f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "5fe3e500-1b98-4ed2-afde-c10fab81f618");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "e81579ce-2477-480a-8e7a-8c68697f8f65");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "bd885666-612f-490b-81ec-fdf2963c75f4");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 6,
                column: "ConcurrencyStamp",
                value: "47604ff1-a8b2-4eab-82f6-b38fd60a248e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 7,
                column: "ConcurrencyStamp",
                value: "6aa267c7-e3d4-48d6-90af-5505d3f01a26");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 8,
                column: "ConcurrencyStamp",
                value: "b7194827-eb49-4b3c-bfbd-7f4a74ee9126");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 9,
                column: "ConcurrencyStamp",
                value: "79742951-625a-4e57-b2ca-9a4eb798cefc");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 10,
                column: "ConcurrencyStamp",
                value: "738779c4-f1a4-482d-81d6-9c7e2a33f180");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 11,
                column: "ConcurrencyStamp",
                value: "6a3d9d48-522a-478d-844f-c82326652d1e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 12,
                column: "ConcurrencyStamp",
                value: "693086fb-91ef-4bb1-a23b-18ee0fba5cf6");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 13,
                column: "ConcurrencyStamp",
                value: "d9ffd36c-0045-4cdd-b056-b6b264136ead");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 14,
                column: "ConcurrencyStamp",
                value: "4d1692fa-f29b-4114-a958-97bff5a7221c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 15,
                column: "ConcurrencyStamp",
                value: "47a596ea-96d3-4f9a-8909-c260322ba275");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 16,
                column: "ConcurrencyStamp",
                value: "65b3dbba-9b1a-4df8-a81f-513218cf6fff");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 17,
                column: "ConcurrencyStamp",
                value: "6773d71f-5d38-4892-bcbd-585f9ba9870b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 18,
                column: "ConcurrencyStamp",
                value: "c948daab-0a9e-41a5-ac48-7f51bbd62558");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 19,
                column: "ConcurrencyStamp",
                value: "5751defe-9f4b-45c2-bf3b-ef0a19dc90a1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 20,
                column: "ConcurrencyStamp",
                value: "86ee8217-a710-4d6b-ab01-bdcf70ee066a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 21,
                column: "ConcurrencyStamp",
                value: "e79c9d17-2355-4fae-928d-405d3ef11432");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 22,
                column: "ConcurrencyStamp",
                value: "3782790b-817b-4ef2-a767-8e2577abb712");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a181d89d-3285-4f19-a220-ffcaf91e4cdb", "AQAAAAEAACcQAAAAEA2oCft2kxTwmRXZPagmX5PsaQdJYFEVij4Q6X9eCnuHEjRS9c+1O4YMGa2rN42j9Q==", "43f77984-f7f3-4c0d-9a94-747e2a4c12f7" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2dcd527c-b8f0-4580-b095-ad76b58ae7d5", "AQAAAAEAACcQAAAAENYCJQnasocBoUi/SgKZukyUg9yaw+nNK+ao4xBMgw+B+0x9ypWDIN/OblxV1PBmmw==", "8d0ed18c-70c0-4e4b-a1dd-9134d2736a85" });
        }
    }
}
