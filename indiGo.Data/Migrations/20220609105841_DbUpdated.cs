using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace indiGo.Data.Migrations
{
    public partial class DbUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Category",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "ded163df-d8c6-4d68-8aaa-612856d88c82");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "2b8c9a70-a6d1-4d68-8fe1-4d36f69a32d3");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "fdc9c330-42ca-4a20-8b0e-66988e95bf16");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "7726f99d-bea7-4415-b5db-c8cf7e641897");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5",
                column: "ConcurrencyStamp",
                value: "2c27783e-98d0-410f-bbaa-509d04b093fe");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6",
                column: "ConcurrencyStamp",
                value: "5abf22fa-5f66-4c46-b449-0548655689e9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7",
                column: "ConcurrencyStamp",
                value: "cea387e5-7164-45d6-84b0-83516ba14279");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e443125-a24d-4543-a5g5-8223d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisterDate", "SecurityStamp" },
                values: new object[] { "32969044-1fe3-4d6b-b5cf-a7697aecdb1b", "AQAAAAEAACcQAAAAEBBOPi+h3X6j+H3Elg6NZ6pFl9lFxUKCUUcjFUCPcn1iVz2IZUAv5VTZSOtslXyb0w==", new DateTime(2022, 6, 9, 10, 58, 41, 377, DateTimeKind.Utc).AddTicks(454), "1b692377-c048-4eee-8ba7-7917f9a8bc1e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e443125-a24d-4543-a6c6-8223d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisterDate", "SecurityStamp" },
                values: new object[] { "06137bb7-4a41-4c7b-9809-9ede38133df1", "AQAAAAEAACcQAAAAEORj9BNIAcKBnHxFvBxskJ8Z3awOgrKlrNLI5Q+CDLOgQQpLNvuROmHlNoDjwQpgHQ==", new DateTime(2022, 6, 9, 10, 58, 41, 371, DateTimeKind.Utc).AddTicks(5543), "dca57772-747c-4cb5-9240-7ac9b632129c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e443125-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisterDate", "SecurityStamp" },
                values: new object[] { "c05c413a-326b-4c8e-ab72-0cdf12478e2a", "AQAAAAEAACcQAAAAENrAGEoqTv5uVbDvWrZj6tZlYbsXWF93bsoV9sAqmtZRIx/8TbkEKETc9hvCZ3qzxA==", new DateTime(2022, 6, 9, 10, 58, 41, 366, DateTimeKind.Utc).AddTicks(391), "7fa71813-b365-4c1c-90de-56845c8d045f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisterDate", "SecurityStamp" },
                values: new object[] { "34a70ba7-0821-42fe-872f-3d5dd74b6d41", "AQAAAAEAACcQAAAAEEaoCKpJrZBKnXoCQCZO3vXVBnpKsM+yG9QgVSGxI6xR5opHwGvCY4IbnEFzWZOaCg==", new DateTime(2022, 6, 9, 10, 58, 41, 360, DateTimeKind.Utc).AddTicks(2779), "d880874b-a678-49fe-ae64-364496276669" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e552862-a24d-4548-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisterDate", "SecurityStamp" },
                values: new object[] { "cb51e1a8-bdd5-490e-b4c5-0931b078da19", "AQAAAAEAACcQAAAAEDIr1pNwx4KjdO//H+OQWbYSjlvIH5VUjhjMKLjiXDliVdZtsAeOLmVd6xuyuCVlug==", new DateTime(2022, 6, 9, 10, 58, 41, 354, DateTimeKind.Utc).AddTicks(5708), "d27bf5dc-e942-4b05-9ca3-601a249b0522" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Category",
                table: "Products");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "f1e6854c-ba30-42a9-bf23-0bc14d861947");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "a93a8fd1-9d60-42fe-a8e6-9b86fc3455b9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "7e0d1ae7-4eff-42a5-9fea-6d08515676e0");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "feb7c741-aac8-48b5-b1ec-e3b1db3bf502");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5",
                column: "ConcurrencyStamp",
                value: "31d3bc9c-ff52-4206-a92d-7df301f95354");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6",
                column: "ConcurrencyStamp",
                value: "f6666dd4-196a-47c0-9db3-296f504bda74");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7",
                column: "ConcurrencyStamp",
                value: "c2d09052-0196-49e4-8b60-4efe25d12e23");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e443125-a24d-4543-a5g5-8223d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisterDate", "SecurityStamp" },
                values: new object[] { "fae02e84-b57c-4343-889d-e2c617f97d8e", "AQAAAAEAACcQAAAAEJsUZqjrPOrSSwDD719kSzAmmGR521btThDtMrPE1HgjJhG5G3xphJsGxE2gJA/Anw==", new DateTime(2022, 6, 8, 11, 59, 37, 683, DateTimeKind.Utc).AddTicks(8233), "f90ec578-d547-4b19-b316-883188287367" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e443125-a24d-4543-a6c6-8223d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisterDate", "SecurityStamp" },
                values: new object[] { "7c916990-bed8-4d27-a836-4de02176c4b1", "AQAAAAEAACcQAAAAEMAoBgEChOCi1hliWZMCGv6Pe5IbMQfZV3xDi3Wh4UcuUljFT8qXUFqialM8VD1dnA==", new DateTime(2022, 6, 8, 11, 59, 37, 677, DateTimeKind.Utc).AddTicks(3163), "cd976a3a-f080-4f8b-836b-555e3c619a28" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e443125-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisterDate", "SecurityStamp" },
                values: new object[] { "246ad430-40c0-438e-aa93-97efdb1940f8", "AQAAAAEAACcQAAAAEB9MMYbUvQzBXg1KgPH6B1C1pYQBgPQpqCOMudwXf0Da5wGluMYSRnFQLzDKtGibUw==", new DateTime(2022, 6, 8, 11, 59, 37, 670, DateTimeKind.Utc).AddTicks(9259), "841999f6-024d-497d-bb93-ad5acd067c2c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisterDate", "SecurityStamp" },
                values: new object[] { "8f5c3ba9-b072-41ba-978e-1cc6fdd049b8", "AQAAAAEAACcQAAAAEG37UmI+WHZVt0ROENg5raDtxJ1IRssXd7Z/QZx0ztFBsGhEXVlx1RU5/xg2x18DoQ==", new DateTime(2022, 6, 8, 11, 59, 37, 664, DateTimeKind.Utc).AddTicks(3515), "aa0ab855-61c6-4acf-828b-569bbd3b4f2a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e552862-a24d-4548-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisterDate", "SecurityStamp" },
                values: new object[] { "eafa824b-8b87-4037-b572-01f8ba86a42d", "AQAAAAEAACcQAAAAEAsg6/N9NLcQnlwabubR1uJXvVkyqqLxx00UGmnchNlt87at4ZTEHs54k+SoUEKm0w==", new DateTime(2022, 6, 8, 11, 59, 37, 658, DateTimeKind.Utc).AddTicks(9805), "80f6ac25-fd74-43e1-b018-7d3ecd73b5b0" });
        }
    }
}
