using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace indiGo.Data.Migrations
{
    public partial class precision : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Receipts_ReceiptId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_ReceiptId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ReceiptId",
                table: "Products");

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Products",
                type: "decimal(8,2)",
                precision: 8,
                scale: 2,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(2,2)",
                oldPrecision: 2);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Products",
                type: "decimal(2,2)",
                precision: 2,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(8,2)",
                oldPrecision: 8,
                oldScale: 2);

            migrationBuilder.AddColumn<int>(
                name: "ReceiptId",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "fb5319bf-68f7-4741-ac61-11413ad2d645");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "5458d8e2-f02a-4bbd-b88e-2817aafd8788");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "460d646c-3ef9-482a-8386-842a7cadb882");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "ef328f1c-620e-4b1a-8eab-53f74745a834");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5",
                column: "ConcurrencyStamp",
                value: "1de44c71-96a5-4cd6-9fa2-4b25c46b9985");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6",
                column: "ConcurrencyStamp",
                value: "4a174e1d-2a20-41d6-bccc-3e770b91a379");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7",
                column: "ConcurrencyStamp",
                value: "9a242cab-d083-44d3-8214-85bcacde176b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e443125-a24d-4543-a5g5-8223d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisterDate", "SecurityStamp" },
                values: new object[] { "54ee14ec-ddf0-4f21-9611-b088aaefd079", "AQAAAAEAACcQAAAAEMy1zIDF87Nl86YIsGosusa5CVxqiikhlUWGuR2sGTsifzTOR9vTuMHX/t5VDh3P2A==", new DateTime(2022, 6, 8, 11, 41, 56, 43, DateTimeKind.Utc).AddTicks(3905), "038ad562-a746-426b-b32c-c33e492ca3fe" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e443125-a24d-4543-a6c6-8223d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisterDate", "SecurityStamp" },
                values: new object[] { "98267260-5dcd-4911-8c82-83177a8bf43f", "AQAAAAEAACcQAAAAENezLagl83lrDCbe5oU4Jj5TmTcwNCiaYrQPTa/iWhgwednrfpGanX4FtB/mDfPFAQ==", new DateTime(2022, 6, 8, 11, 41, 56, 38, DateTimeKind.Utc).AddTicks(1823), "8dc5bf9e-acb6-4b0f-90c6-042e7db39189" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e443125-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisterDate", "SecurityStamp" },
                values: new object[] { "969cf7b0-80a7-4985-8a0a-9797a013c7e2", "AQAAAAEAACcQAAAAENOFXRX2yQV6HPkJ3Q518xj8q8zBenezMqxEblL5YtuWfDa6nKX7xKI6ouUt0iYlBg==", new DateTime(2022, 6, 8, 11, 41, 56, 32, DateTimeKind.Utc).AddTicks(9722), "972bb28c-2f79-4c0d-b175-b3289add4c07" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisterDate", "SecurityStamp" },
                values: new object[] { "37ba7aa1-3cb5-4046-8537-b49e78653638", "AQAAAAEAACcQAAAAEBQWbFbLX4bHsJa1TKbdyygbRrMudFfImqBtQkCm+7uPP33N4w+jc8BmmokYdgh90A==", new DateTime(2022, 6, 8, 11, 41, 56, 27, DateTimeKind.Utc).AddTicks(6041), "9e8635f4-6de2-4b30-ac27-23fdcb4b5a96" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e552862-a24d-4548-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisterDate", "SecurityStamp" },
                values: new object[] { "b8834802-70cc-4511-a2e0-39396f2787ef", "AQAAAAEAACcQAAAAENIRUeG5c25qspweR7s6a5KYYKo3RZgmeupw6OgH8mfT2zyQAwue6SYAHqL3w6DK3w==", new DateTime(2022, 6, 8, 11, 41, 56, 22, DateTimeKind.Utc).AddTicks(3582), "2d05fdcc-c8c5-435d-9537-f23262a603a3" });

            migrationBuilder.CreateIndex(
                name: "IX_Products_ReceiptId",
                table: "Products",
                column: "ReceiptId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Receipts_ReceiptId",
                table: "Products",
                column: "ReceiptId",
                principalTable: "Receipts",
                principalColumn: "Id");
        }
    }
}
