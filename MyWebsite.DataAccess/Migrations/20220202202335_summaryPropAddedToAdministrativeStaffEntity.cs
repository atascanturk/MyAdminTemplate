using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyWebsite.DataAccess.Migrations
{
    public partial class summaryPropAddedToAdministrativeStaffEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Summary",
                table: "AdministrativeStaffs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Newss",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 2, 2, 23, 23, 34, 427, DateTimeKind.Local).AddTicks(7697));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "7cb69cdf-fb0e-4b0a-8300-4bca33639f8e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "16050512-7cb0-41cf-a712-2cb86ea8e0dc");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "50eb1e7e-bf2a-4d18-b9ed-e5edbdf59c5e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "90a0544d-39ab-42c3-8360-d2978841a495");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "cc6dba36-be3f-4934-ab94-15147bb4673e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 6,
                column: "ConcurrencyStamp",
                value: "3f163fb6-1383-4958-9aad-f1e1440929f1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 7,
                column: "ConcurrencyStamp",
                value: "1dc7af9e-009f-4233-8350-e279f84a5ead");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 8,
                column: "ConcurrencyStamp",
                value: "97976c80-eb56-4071-9657-840204220e0f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 9,
                column: "ConcurrencyStamp",
                value: "fb238164-fbfb-43fc-ad68-b5904e5a5068");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 10,
                column: "ConcurrencyStamp",
                value: "4ed850c7-87d3-46cc-8c28-231081db4afa");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 11,
                column: "ConcurrencyStamp",
                value: "fd819cba-69ca-481a-8fce-30ed1fd59a42");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 12,
                column: "ConcurrencyStamp",
                value: "37292b08-db57-4d17-bfe5-5d19d58aa2c4");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 13,
                column: "ConcurrencyStamp",
                value: "1d7f973c-5158-4b77-bb77-e2bfe0fc725f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 14,
                column: "ConcurrencyStamp",
                value: "d66d1044-fb42-426f-b639-0b8ba8f70143");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 15,
                column: "ConcurrencyStamp",
                value: "8856acfe-b038-4dcf-9c78-2f957309476b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 16,
                column: "ConcurrencyStamp",
                value: "d0dbef8b-e1f7-417c-9389-e01b662406a2");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 17,
                column: "ConcurrencyStamp",
                value: "2d7f0bce-a577-4989-a73b-a600991b98de");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 18,
                column: "ConcurrencyStamp",
                value: "681ee4c5-8b66-46c9-bd30-d174a026383a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 19,
                column: "ConcurrencyStamp",
                value: "89a00cb3-fd03-4d72-9128-0d9cca353d13");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 20,
                column: "ConcurrencyStamp",
                value: "85657898-31f0-40a6-b59f-837a8e64aa94");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 21,
                column: "ConcurrencyStamp",
                value: "7701133c-1c4a-48b0-9008-b86ac519cdfe");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 22,
                column: "ConcurrencyStamp",
                value: "8fcd4ee1-3137-4d33-a7b1-acb47c612071");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1a5b5ae8-ae94-4be4-bea7-3707ece624bd", "AQAAAAEAACcQAAAAEMnGG9CwBn6ZOTnn4kvoAYi+n45val48275t40Ks59W7ssOtUmv3Nfab3ROJnYc52g==", "4e97520a-21d8-485f-83ca-b7dcad73f1be" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7f226c33-decf-402a-b7dc-f35351649734", "AQAAAAEAACcQAAAAENxSarvE1fi3KGeOWuYIi3DhuWNyDni4Jo+T8Ogt0SLRc8rNIq3qAAPOjfLbqv52Tg==", "e7f5c2ad-aa87-4aa9-aa31-098d1aaa48d0" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Summary",
                table: "AdministrativeStaffs");

            migrationBuilder.UpdateData(
                table: "Newss",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 2, 1, 21, 0, 41, 356, DateTimeKind.Local).AddTicks(7327));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "1751bb5a-785b-4991-b7ce-7015d40128af");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "2e85941d-d6c9-41a8-a474-4afaf0393387");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "d3bd74e7-17e7-4037-9c47-eaf19d701bfa");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "8371e18b-2d79-4eb3-af73-a4e8fef6e29d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "034fd762-e2b1-4771-a949-4417fe0a02f9");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 6,
                column: "ConcurrencyStamp",
                value: "057fcc01-bfe2-46dc-b87d-da6851e9616b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 7,
                column: "ConcurrencyStamp",
                value: "9cb73772-84ab-4f33-b8b0-96077bef4617");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 8,
                column: "ConcurrencyStamp",
                value: "4159f562-7fea-49a3-a042-879123c1d385");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 9,
                column: "ConcurrencyStamp",
                value: "a7b98221-8929-4b4c-a572-01c52dc89fdc");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 10,
                column: "ConcurrencyStamp",
                value: "0b6d778d-8b53-48dc-ab8e-485e47a783c9");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 11,
                column: "ConcurrencyStamp",
                value: "f6592ee5-a388-4cee-ae75-5a2589b5b2af");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 12,
                column: "ConcurrencyStamp",
                value: "f776efa9-9a8b-4b2c-85af-e76f2fdee992");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 13,
                column: "ConcurrencyStamp",
                value: "1a78f621-a522-4e0a-b0de-30b23b361718");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 14,
                column: "ConcurrencyStamp",
                value: "710f743c-679f-40b4-a3a4-208b255dea3f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 15,
                column: "ConcurrencyStamp",
                value: "e746bf39-fb43-4cf7-b94b-1c3087b78a83");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 16,
                column: "ConcurrencyStamp",
                value: "dc14267a-61c6-4850-baf2-c1176d38eaef");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 17,
                column: "ConcurrencyStamp",
                value: "3d63a2ed-0946-4172-b02a-859d31ea3a87");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 18,
                column: "ConcurrencyStamp",
                value: "8fa43ba4-cc66-450f-afed-f6b74949d160");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 19,
                column: "ConcurrencyStamp",
                value: "bf556602-6c98-4376-aaef-49da03508c76");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 20,
                column: "ConcurrencyStamp",
                value: "51fb5382-09d2-4fdc-8975-6384bdd07b86");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 21,
                column: "ConcurrencyStamp",
                value: "827ee610-bfd9-47c7-a80a-2d4370a02811");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 22,
                column: "ConcurrencyStamp",
                value: "762d711a-7bac-4d9d-b03d-e2235645361a");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cf7b7940-705d-4986-bee8-494e2543588b", "AQAAAAEAACcQAAAAEI3NhDoQVrAJIsklWChYtwXokslXzMYJyQkTjzbzrftgNuzsq6BQXILOGYO4N+U0Hw==", "9a787879-caf7-42e5-a31c-a5ff6fc864e7" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8c626782-8395-4c15-94d0-4e8d01018ac5", "AQAAAAEAACcQAAAAEKS/MzZ1vtfKAkzUqNBZXY+SzC0Qq2lKT41YY9ZXCQVKrHmmDaQJQ4ABc5NKY4O8Vg==", "018c4249-f568-481a-8386-e907b78ad63d" });
        }
    }
}
