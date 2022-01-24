using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyWebsite.DataAccess.Migrations
{
    public partial class categoryIdFixed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Newss",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 1, 24, 21, 58, 2, 278, DateTimeKind.Local).AddTicks(9454));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "94bdb89d-49b1-4b12-80c3-e73f75dbf82f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "051d52e3-2b25-410e-a230-e9285df93d52");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "d515b8bd-4737-4072-b92b-a056022dcafd");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "3d992726-2551-4b4a-b1b4-e61981b9746a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "e1d661ad-2c8f-4460-9345-21e23609f3b2");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 6,
                column: "ConcurrencyStamp",
                value: "3953f848-8e71-4df3-8fba-0981186a17bb");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 7,
                column: "ConcurrencyStamp",
                value: "efc8c3df-74ff-4d0f-bea7-c72fc6e03065");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 8,
                column: "ConcurrencyStamp",
                value: "52c103fc-cbed-42c7-a5c6-e227f9c6f028");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 9,
                column: "ConcurrencyStamp",
                value: "116db301-3e6e-49e7-9b60-1f4cbc42ae2d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 10,
                column: "ConcurrencyStamp",
                value: "aed5b0ab-5348-4df6-8c49-ef57affc93fc");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 11,
                column: "ConcurrencyStamp",
                value: "71546d1b-a5c5-44c5-8e17-122f84a0428a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 12,
                column: "ConcurrencyStamp",
                value: "438fc294-4228-41b8-9d0f-05530020c058");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 13,
                column: "ConcurrencyStamp",
                value: "e18898b6-c2e5-4b08-a1e5-407aba241e34");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 14,
                column: "ConcurrencyStamp",
                value: "5a694cd5-c70e-4718-b68f-77aae9baecb3");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 15,
                column: "ConcurrencyStamp",
                value: "5f5c4365-48bc-47c2-a71c-79b392fae574");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 16,
                column: "ConcurrencyStamp",
                value: "0b6d229e-a2b5-4dc7-870a-35baef0ce06d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 17,
                column: "ConcurrencyStamp",
                value: "040bbe51-8711-457e-a49f-0f5fe2ca9d6f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 18,
                column: "ConcurrencyStamp",
                value: "d8e899c5-1513-4295-a994-ec84e26556fa");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 19,
                column: "ConcurrencyStamp",
                value: "860a46f4-7369-46a8-bcb6-813fcc4ef6a9");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 20,
                column: "ConcurrencyStamp",
                value: "2f418dee-c119-4cf4-ad2b-038fa2bbc3ae");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 21,
                column: "ConcurrencyStamp",
                value: "f2554c73-b750-4622-81e1-36c7475dda40");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 22,
                column: "ConcurrencyStamp",
                value: "8d7fa61e-a9a1-4c13-af2d-17e7017d145c");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "341513e4-dd55-4bd4-a4c9-4123c6aafe33", "AQAAAAEAACcQAAAAENO3x7tRDl2nmVvtx8v0mbbmCc0OhpKWdWPdigeBThkqv1lpQtPIm4uTh46E2HtCEg==", "60ef7538-e7bd-42e7-b4b0-2c272b79f54d" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "40dae25c-423d-4e62-82cd-889c1b91eb6a", "AQAAAAEAACcQAAAAEB2iw+JQRdNpw4nVRZXf0z3yqFAwSjaVA+zyhXTk7YW3Qs44y+DzPjOZkrEue1Jpng==", "e838024b-9624-4564-bafc-50db2554ccfb" });
        }
    }
}
