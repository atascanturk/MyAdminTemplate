using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyWebsite.DataAccess.Migrations
{
    public partial class SeoEntityAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Seos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SeoDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoAuthor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoTags = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seos", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Newss",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 1, 23, 23, 6, 8, 813, DateTimeKind.Local).AddTicks(1101));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "bf1e9464-81be-471c-a275-c58202b3813a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "a530b57a-1c74-4739-a751-a209f36d9f59");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "a6f3e3aa-8ab2-417a-9d67-c6591845a432");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "88db0eb9-49f8-4506-abb7-43b8ff1abc9e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "39ee3527-a1fb-4406-8123-fed910361d1a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 6,
                column: "ConcurrencyStamp",
                value: "61d4a927-4c9c-4a5d-a835-b65c9e7f0b10");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 7,
                column: "ConcurrencyStamp",
                value: "11618c43-21f2-4fa6-962a-2cc24f31a115");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 8,
                column: "ConcurrencyStamp",
                value: "67d0af68-067a-415f-9013-f7345192203c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 9,
                column: "ConcurrencyStamp",
                value: "334c272f-9e63-4f50-ac48-80c855472fac");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 10,
                column: "ConcurrencyStamp",
                value: "54ff6cc3-9ece-47c7-b17f-8ec3df6097be");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 11,
                column: "ConcurrencyStamp",
                value: "bfccf0ce-c276-4750-b820-544bf2f2be34");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 12,
                column: "ConcurrencyStamp",
                value: "0c8d8b61-c9b7-4438-8810-a0832bdf5a55");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 13,
                column: "ConcurrencyStamp",
                value: "e206367c-246e-49a9-aad9-2751951dea42");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 14,
                column: "ConcurrencyStamp",
                value: "a81665a2-63d3-4dcd-bffb-b704e2396309");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 15,
                column: "ConcurrencyStamp",
                value: "1e7b7e4c-5fc2-48a8-86d4-c16e41825998");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 16,
                column: "ConcurrencyStamp",
                value: "39b4b3b3-7480-4720-a414-027ac4b5aadb");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 17,
                column: "ConcurrencyStamp",
                value: "efdb06c6-723f-43b9-94c7-9898106bded0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 18,
                column: "ConcurrencyStamp",
                value: "d20d392b-a737-4e55-a940-689967ae145e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 19,
                column: "ConcurrencyStamp",
                value: "9a23c9e7-a28c-481c-a1b3-2d3602053da0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 20,
                column: "ConcurrencyStamp",
                value: "80e73098-2f5a-4e9a-93b6-d14e77d61ef1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 21,
                column: "ConcurrencyStamp",
                value: "91ada4d9-58f5-41eb-8571-4d9741bb05d7");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 22,
                column: "ConcurrencyStamp",
                value: "b65f3fd7-3343-40b7-85dd-f21821550175");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1cea19b6-6f8e-4e1f-ac70-bfdffcf194eb", "AQAAAAEAACcQAAAAEOc/+ftxf1EvLXfHENPZswAtdLig27huI5TsbVbt5OU0RAXIHipKufHzqY8KANifxQ==", "e6f95a4d-b624-4f86-a494-486ff9a39a46" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d33c64c2-4259-47ac-8b75-6985841405eb", "AQAAAAEAACcQAAAAEF/AaeoWY28apXjeRLqvyMF80t1uAUSteJgRf28C+T4Rq9DXTMyH5nMCTZuq/en3oQ==", "9ecbd3f0-1023-490b-9dda-c6a9ce84a12f" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Seos");

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
    }
}
